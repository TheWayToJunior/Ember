﻿using Ember.Server.Exceptions;
using Ember.Shared;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ember.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "Admin")]
    public class UserRolesController : ControllerBase
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly RoleManager<IdentityRole> roleManager;

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
            {
                return BadRequest($"The user \"{email}\" was not found");
            }

            return Ok(await CreateUserRoles(user)
                    .ConfigureAwait(true));
        }

        [HttpPut("Edit")]
        public async Task<ActionResult> Edit(string email, [FromBody] IEnumerable<string> roles)
        {
            var user = await userManager.FindByEmailAsync(email)
                .ConfigureAwait(true);

            if (user == null)
            {
                return BadRequest($"The user \"{email}\" was not found");
            }

            if (roles == null || !roles.Any())
            {
                return BadRequest("The role collection is null or empty");
            }

            /// Проверка валидности ролей
            foreach (var role in roles)
            {
                var anyRole = await roleManager.FindByNameAsync(role)
                    .ConfigureAwait(true);

                if (anyRole == null)
                {
                    return BadRequest($"Role \"{role}\" is not found");
                }
            }

            try
            {
                await СhangRoles(user, roles)
                    .ConfigureAwait(true);

                return NoContent();
            }
            catch (NoAccessChangRoleException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        private async Task СhangRoles(IdentityUser user, IEnumerable<string> roles)
        {
            var userRoles = await userManager.GetRolesAsync(user)
                 .ConfigureAwait(true);

            if (userRoles.Any(role => role == Roles.Admin))
            {
                throw new NoAccessChangRoleException($"Cannot change the {Roles.Admin} role");
            }

            if (roles.Any(role => role == Roles.Admin))
            {
                throw new NoAccessChangRoleException($"Cannot change the {Roles.Admin} role");
            }

            /// Поиск ролей которые необходимо добавить
            var addedRoles = roles.Except(userRoles);

            /// Поиск ролей которые необходимо удалить
            var removedRoles = userRoles.Except(roles);

            await userManager.AddToRolesAsync(user, addedRoles)
                .ConfigureAwait(true);

            await userManager.RemoveFromRolesAsync(user, removedRoles)
                .ConfigureAwait(true);
        }
    }
}