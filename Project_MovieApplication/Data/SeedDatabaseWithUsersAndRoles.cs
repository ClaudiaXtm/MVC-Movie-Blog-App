using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_MovieApplication.Data
{
    public class SeedDatabaseWithUsersAndRoles
    {
        public static async Task Initialize(ApplicationDbContext context, UserManager<ApplicationUser> userManager,
            RoleManager<ApplicationRole> roleManager)
        {
            context.Database.EnsureCreated();

            String memberId = "";

            string roleMember = "Member";
            string descriptionMember = "This is the members role";

            string roleCustomer = "Customer";
            string descriptionCustomer = "This is the customers role";

            string password = "Password123!";

            if (await roleManager.FindByNameAsync(roleMember) == null)
            {
                await roleManager.CreateAsync(new ApplicationRole(roleMember, descriptionMember, DateTime.Now));
            }
            if (await roleManager.FindByNameAsync(roleCustomer) == null)
            {
                await roleManager.CreateAsync(new ApplicationRole(roleCustomer, descriptionCustomer, DateTime.Now));
            }

            if (await userManager.FindByNameAsync("Member1") == null)
            {
                var user = new ApplicationUser
                {
                    UserName = "Member1@email.com",
                    Email = "Member1@email.com",
                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, password);
                    await userManager.AddToRoleAsync(user, roleMember);
                }
                memberId = user.Id;
            }


            if (await userManager.FindByNameAsync("Customer1") == null)
            {
                var user = new ApplicationUser
                {
                    UserName = "Customer1@email.com",
                    Email = "Customer1@email.com",
                   
                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, password);
                    await userManager.AddToRoleAsync(user, roleCustomer);
                }
            }

            if (await userManager.FindByNameAsync("Customer2") == null)
            {
                var user = new ApplicationUser
                {
                    UserName = "Customer2@email.com",
                    Email = "Customer2@email.com",
                    
                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, password);
                    await userManager.AddToRoleAsync(user, roleCustomer);
                }
            }

            if (await userManager.FindByNameAsync("Customer3") == null)
            {
                var user = new ApplicationUser
                {
                    UserName = "Customer3@email.com",
                    Email = "Customer3@email.com",

                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, password);
                    await userManager.AddToRoleAsync(user, roleCustomer);
                }
            }

            if (await userManager.FindByNameAsync("Customer4") == null)
            {
                var user = new ApplicationUser
                {
                    UserName = "Customer4@email.com",
                    Email = "Customer4@email.com",

                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, password);
                    await userManager.AddToRoleAsync(user, roleCustomer);
                }
            }

            if (await userManager.FindByNameAsync("Customer5") == null)
            {
                var user = new ApplicationUser
                {
                    UserName = "Customer5@email.com",
                    Email = "Customer5@email.com",

                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, password);
                    await userManager.AddToRoleAsync(user, roleCustomer);
                }
            }

        }
    }
}
