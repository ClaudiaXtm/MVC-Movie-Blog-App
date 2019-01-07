using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;


namespace Project_MovieApplication.Data
{
    public static class SeedDatabaseWithMoviesAndReviews
    {
        public static void SeedDb(ApplicationDbContext context)
        {
            SeedMovie(context);
            SeedReviews(context);
        }

        private static void SeedMovie(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();

            if (context.Movie.Any())
            {
                return;   
            }

            context.Movie.Add(
                    new Models.Movie()
                    {
                      
                        Title = "Pulp fiction",
                        Description = "Vincent Vega (John Travolta) and Jules Winnfield (Samuel L. Jackson) are hitmen with a penchant for philosophical discussions.",
                        MovieGenre = Models.Genre.Action,
                        NoOfReviews = 0,
                        UserName = "Member1@email.com",
                        AverageRating = 8
                    });
             context.Movie.Add(
                    new Models.Movie()
                    {
                      
                        Title = "Dunkirk",
                        Description = "In May 1940, Germany advanced into France, trapping Allied troops on the beaches of Dunkirk.",
                        MovieGenre = Models.Genre.Historical,
                        NoOfReviews = 0,
                        UserName = "Member1@email.com",
                        AverageRating = 10
                    });
            context.Movie.Add(
                  new Models.Movie()
                  {
                    
                      Title = "Bohemian Rhapsody",
                      Description = "Bohemian Rhapsody is a foot-stomping celebration of Queen, their music and their extraordinary lead singer Freddie Mercury.",
                      MovieGenre = Models.Genre.Historical,
                      NoOfReviews = 0,
                      UserName = "Member1@email.com",
                      AverageRating = 10
                  });
            context.Movie.Add(
                  new Models.Movie()
                  {
                   
                      Title = "Black Panther",
                      Description = "After the death of his father, T'Challa returns home to the African nation of Wakanda to take his rightful place as king. ",
                      MovieGenre = Models.Genre.SF,
                      NoOfReviews = 0,
                      UserName = "Member1@email.com",
                      AverageRating = 18,

                   
                  });
            context.SaveChanges();
            
        }


        private static void SeedReviews(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();

            if (context.Review.Any())
            {
                return;
            }

            context.Review.Add(
                 new Models.Review()
                 {
                     Content = "It's hot, it's cool and-- for a movie that sometimes comes at you like a blindsiding fist-- it's unfailingly playful.",
                     Rating = 10,
                     ReviewDate = DateTime.Parse("2019-09-01"),
                     UserName = "Customer1@email.com"
              
                 });

            context.Review.Add(
              new Models.Review()
              {
                  Content = "The talk is dirty and funny, the violence always waiting just around the corner.",
                  Rating = 10,
                  ReviewDate = DateTime.Parse("2019-08-01"),
                  UserName = "Customer2@email.com"

              });

            context.Review.Add(
         new Models.Review()
         {
             Content = "Whether you call it razzmatazz, pizazz or sizzle, Pulp Fiction's got it, enough style for a dozen movies and, truth be told, enough story for five.",
             Rating = 9,
             ReviewDate = DateTime.Parse("2019-08-01"),
             UserName = "Customer2@email.com"

         });

            context.SaveChanges();
        }

        }




}
