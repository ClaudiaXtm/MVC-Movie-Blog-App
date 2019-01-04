using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_MovieApplication.Data
{
    public class SeedUserRoles
    {
        private readonly RoleManager<IdentityRole> _roleManager;

        public SeedUserRoles(RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
        }

        public async void SeedAsync()
        {
            if((await _roleManager.FindByIdAsync("Member")) == null)
            {
                await _roleManager.CreateAsync(new IdentityRole { Name = "Member" });
            }
            
        }
    }
}
