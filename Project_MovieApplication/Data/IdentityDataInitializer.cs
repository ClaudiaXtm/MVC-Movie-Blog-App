using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Project_MovieApplication.Data
{
    public static class IdentityDataInitializer
    {
        public static void SeedIdentityData(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            SeedRoles(roleManager);
            SeedUsers(userManager);
        }

        public static void SeedRoles(RoleManager<IdentityRole> roleManager)
        {
            if (!roleManager.RoleExistsAsync("Member").Result)
            {
                IdentityRole role = new IdentityRole();
                role.Name = "Member";
                IdentityResult roleResult = roleManager.CreateAsync(role).Result;
            }


            if (!roleManager.RoleExistsAsync("Customer").Result)
            {
                IdentityRole role = new IdentityRole();
                role.Name = "Customer";
                IdentityResult roleResult = roleManager.CreateAsync(role).Result;
            }
        }

        public static void SeedUsers(UserManager<IdentityUser> userManager)
        {
            if (userManager.FindByEmailAsync("Member1@email.com").Result == null)
            {
                IdentityUser user = new IdentityUser();
                user.UserName = "Member1@email.com";
                user.Email = "Member1@email.com";
               

                IdentityResult result = userManager.CreateAsync(user, "Password123!").Result;

                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user,Roles.Member.ToString()).Wait();
                }
            }

            if (userManager.FindByEmailAsync("Test@email.com").Result == null)
            {
                IdentityUser user = new IdentityUser();
                user.UserName = "Test@email.com";
                user.Email = "Test@email.com";


                IdentityResult result = userManager.CreateAsync(user, "Password123!").Result;

                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "Customer").Wait();
                }
            }

            if (userManager.FindByEmailAsync("Customer1@email.com").Result == null)
            {
                IdentityUser user = new IdentityUser();
                user.UserName = "Customer1@email.com";
                user.Email = "Customer1@email.com";


                IdentityResult result = userManager.CreateAsync(user, "Password123!").Result;

                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "Customer").Wait();
                }
            }

            if (userManager.FindByEmailAsync("Customer2@email.com").Result == null)
            {
                IdentityUser user = new IdentityUser();
                user.UserName = "Customer2@email.com";
                user.Email = "Customer2@email.com";


                IdentityResult result = userManager.CreateAsync(user, "Password123!").Result;

                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "Customer").Wait();
                }
            }

            if (userManager.FindByEmailAsync("Customer3@email.com").Result == null)
            {
                IdentityUser user = new IdentityUser();
                user.UserName = "Customer3@email.com";
                user.Email = "Customer3@email.com";


                IdentityResult result = userManager.CreateAsync(user, "Password123!").Result;

                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "Customer").Wait();
                }
            }

            if (userManager.FindByEmailAsync("Customer4@email.com").Result == null)
            {
                IdentityUser user = new IdentityUser();
                user.UserName = "Customer4@email.com";
                user.Email = "Customer4@email.com";


                IdentityResult result = userManager.CreateAsync(user, "Password123!").Result;

                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "Customer").Wait();
                }
            }

            if (userManager.FindByEmailAsync("Customer5@email.com").Result == null)
            {
                IdentityUser user = new IdentityUser();
                user.UserName = "Customer5@email.com";
                user.Email = "Customer5@email.com";


                IdentityResult result = userManager.CreateAsync(user, "Password123!").Result;

                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "Customer").Wait();
                }
            }
        }

     
    }
}
