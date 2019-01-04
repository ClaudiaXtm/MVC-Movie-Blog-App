using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;


namespace Project_MovieApplication.Data
{
    public static class DbInitializer
    {
        public static void SeedDb(ApplicationDbContext context)
        {
            SeedMovie(context);
        }

        private static void SeedMovie(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();

            if (!context.Movie.Any())
            {
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




}
