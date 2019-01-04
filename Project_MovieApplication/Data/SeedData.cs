using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_MovieApplication.Data
{
    public static class SeedData
    {
        public static async Task InitializeAsync(IServiceProvider service)
        {
            var roleManager = service.GetRequiredService<RoleManager<IdentityRole>>();
            await EnsureRolesAsync(roleManager);

            var userManager = service.GetRequiredService<UserManager<IdentityUser>>();
            await EnsureMemberAsync(userManager);
        }

        private static async Task EnsureRolesAsync(RoleManager<IdentityRole> roleManager)
        {
            var alreadyExists = await roleManager.RoleExistsAsync("Member");

            if (alreadyExists) return;

            await roleManager.CreateAsync(new IdentityRole("Member"));
        }

        private static async Task EnsureMemberAsync(UserManager<IdentityUser> userManager)
        {
            var member = await userManager.Users.Where(x => x.UserName == "Member1@email.com").SingleOrDefaultAsync();

            if (member != null) return;


            member  =  new IdentityUser
            {
                UserName = "Member1@email.com",
                Email = "Member1@email.com"
            };

            await userManager.CreateAsync(member, "Password123!");
            await userManager.AddToRoleAsync(member, "Member");
        }


    }
}
