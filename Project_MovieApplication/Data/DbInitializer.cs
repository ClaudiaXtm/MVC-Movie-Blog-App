using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;


namespace Project_MovieApplication.Data
{
    public static class DbInitializer
    {
  

        public static void SeedDb(ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            SeedMovie(context);
            SeedUser(userManager);
      
            
        }


      

        private static void SeedUser(UserManager<IdentityUser> userManager)
        {
            //IdentityUser user = new IdentityUser
            //{
            //    UserName = "Member1@email.com",
            //    Email = "Member1@email.com"
            //};

            //userManager.CreateAsync(user, "Password123!").Wait();

            IdentityUser customer1 = new IdentityUser
            {
                UserName = "Customer1@email.com",
                Email = "Customer1@email.com"
            };

            userManager.CreateAsync(customer1, "Password123!").Wait();

            IdentityUser customer2 = new IdentityUser
            {
                UserName = "Customer2@email.com",
                Email = "Customer2@email.com"
            };

            userManager.CreateAsync(customer2, "Password123!").Wait();

            IdentityUser customer3 = new IdentityUser
            {
                UserName = "Customer3@email.com",
                Email = "Customer3@email.com"
            };

            userManager.CreateAsync(customer3, "Password123!").Wait();

            IdentityUser customer4 = new IdentityUser
            {
                UserName = "Customer4@email.com",
                Email = "Customer4@email.com"
            };

            userManager.CreateAsync(customer4, "Password123!").Wait();

            IdentityUser customer5 = new IdentityUser
            {
                UserName = "Customer5@email.com",
                Email = "Customer5@email.com"
            };

            userManager.CreateAsync(customer5, "Password123!").Wait();
        }

        private static void SeedMovie(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();
        
                context.Movie.Add(
                    new Models.Movie()
                    {
                        Title = "Pulp fiction",
                        Description = "Vincent Vega (John Travolta) and Jules Winnfield (Samuel L. Jackson) are hitmen with a penchant for philosophical discussions.",
                        AverageRating = 8
                    });
                context.Movie.Add(
                    new Models.Movie()
                    {
                        Title = "Harry Potter",
                        Description = "best movie ever",
                        AverageRating = 10
                    });
                context.SaveChanges();
            
        } 



     
    }




}
