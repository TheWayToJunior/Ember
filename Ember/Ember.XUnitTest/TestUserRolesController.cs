using Ember.Server.Controllers;
using Ember.Shared;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using Microsoft.EntityFrameworkCore;

namespace Ember.XUnitTest
{
    public class TestUserRolesController
    {
        private IQueryable<IdentityUser> GetUsers()
        {
            return new List<IdentityUser>()
            {
                new IdentityUser() 
                {
                    UserName = "User"
                },
                new IdentityUser() 
                {
                    UserName = "Editor"
                },
                new IdentityUser() 
                {
                    UserName = "Admin"
                },
            }
            .AsQueryable<IdentityUser>();
        }

        private IQueryable<IdentityRole> GetRoles()
        {
            return new List<IdentityRole>()
            {
                new IdentityRole()
                {
                    Name = "User"
                },
                new IdentityRole()
                {
                    Name = "Editor"
                },
                new IdentityRole()
                {
                    Name = "Admin"
                },
            }
            .AsQueryable<IdentityRole>();
        }
    }
}
