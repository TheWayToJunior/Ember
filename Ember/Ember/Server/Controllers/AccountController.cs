using Ember.Shared;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Ember.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;
        private readonly IConfiguration configuration;

        public AccountController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager,
            IConfiguration configuration)
        {
            this.userManager   = userManager   ?? throw new ArgumentNullException(nameof(userManager));
            this.signInManager = signInManager ?? throw new ArgumentNullException(nameof(signInManager));
            this.configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
        }

        // Invoke-RestMethod https://localhost:44381/api/account/create 
        // -Method POST 
        // -Body (@{email = "test@test.com"; password = tEst1234} | ConvertTo-Json)
        // -ContentType "application/json; charset=utf-8"
        [HttpPost("Create")]
        public async Task<ActionResult<UserToken>> Create([FromBody] UserInfo userInfo)
        {
            if (userInfo == null)
            {
                throw new ArgumentNullException(nameof(userInfo));
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var user = new IdentityUser { Email = userInfo.Email, UserName = userInfo.Email };
            var result = await userManager.CreateAsync(user, userInfo.Password)
                .ConfigureAwait(true);

            if (result.Succeeded)
            {
                return BildToken(userInfo);
            }
            else
            {
                return BadRequest("Username or password invalid");
            }
        }

        // Invoke-RestMethod https://localhost:44381/api/account/login 
        // -Method POST 
        // -Body (@{email = "test@test.com"; password = tEst1234} | ConvertTo-Json)
        // -ContentType "application/json; charset=utf-8"
        [HttpPost("Login")]
        public async Task<ActionResult<UserToken>> Login([FromBody] UserInfo userInfo)
        {
            if (userInfo == null)
            {
                throw new ArgumentNullException(nameof(userInfo));
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var result = await signInManager.PasswordSignInAsync(userInfo.Email, userInfo.Password,
                isPersistent: false, lockoutOnFailure: false)
                .ConfigureAwait(true);

            if (result.Succeeded)
            {
                return BildToken(userInfo);
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                return BadRequest(ModelState);
            }
        }

        private UserToken BildToken(UserInfo userInfo)
        {
            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.UniqueName, userInfo.Email),
                new Claim(ClaimTypes.Name, userInfo.Email)
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["jwt:key"]));
            var cred = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            // Expiration time
            var expiration = DateTime.UtcNow.AddYears(1);

            JwtSecurityToken jwt = new JwtSecurityToken(
               issuer: null,
               audience: null,
               claims: claims,
               expires: expiration,
               signingCredentials: cred);

            return new UserToken()
            {
                Token = new JwtSecurityTokenHandler().WriteToken(jwt),
                Expiration = expiration
            };
        }
    }
}