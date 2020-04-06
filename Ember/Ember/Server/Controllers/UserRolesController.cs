using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ember.Shared;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Ember.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "Admin")]
    public class UserRolesController : ControllerBase
    {
        private UserManager<IdentityUser> userManager;
        private RoleManager<IdentityRole> roleManager;

        public UserRolesController(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            this.userManager = userManager ?? throw new ArgumentNullException(nameof(userManager));
            this.roleManager = roleManager ?? throw new ArgumentNullException(nameof(roleManager));
        }

        private async Task<UserRoles> CreateUserRoles(IdentityUser user)
        {
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }

            return new UserRoles
            {
                Email = user.Email,
                AllRoles = await roleManager.Roles.ToListAsync().ConfigureAwait(true),
                AllUserRoles = await userManager.GetRolesAsync(user).ConfigureAwait(true)
            };
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserRoles>>> GetAll() 
        {
            var users = new List<UserRoles>();

            foreach (var user in userManager.Users)
            {
                users.Add(await CreateUserRoles(user)
                    .ConfigureAwait(true));
            }

            return Ok(users);
        }

        [HttpGet("Get")]
        public async Task<ActionResult<IEnumerable<UserRoles>>> GetByEmail([FromQuery] string email)
        {
            var user = await userManager.FindByEmailAsync(email)
                .ConfigureAwait(true);

            if (user == null)
                return BadRequest();

            return Ok(await CreateUserRoles(user)
                    .ConfigureAwait(true));
        }

        [HttpPut("Edit")]
        public async Task<ActionResult<IEnumerable<UserRoles>>> Edit(string email, [FromBody] IEnumerable<string> roles)
        {
            var user = await userManager.FindByEmailAsync(email)
                .ConfigureAwait(true);

            if (user == null)
                return BadRequest("Not user");

            if (roles == null || !roles.Any())
                return BadRequest("Not roles");

            foreach (var role in roles)
            {

                var anyRole = await roleManager.FindByNameAsync(role)
                    .ConfigureAwait(true);

                if (anyRole == null)
                    return BadRequest($"Role \"{role}\" is not found");
            }

            var userRoles = await userManager.GetRolesAsync(user)
                .ConfigureAwait(true);

            /// Поиск ролей которые необходимо добавить
            var addedRoles = roles.Except(userRoles);

            /// Поиск ролей которые необходимо удалить
            var removedRoles = userRoles.Except(roles);

            await userManager.AddToRolesAsync(user, addedRoles)
                .ConfigureAwait(true);

            await userManager.RemoveFromRolesAsync(user, removedRoles)
                .ConfigureAwait(true);

            return NoContent();
        }
    }
}