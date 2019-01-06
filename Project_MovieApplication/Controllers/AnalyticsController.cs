using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project_MovieApplication.Data;
using Project_MovieApplication.Models;

namespace Project_MovieApplication.Controllers
{
    public class AnalyticsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AnalyticsController(ApplicationDbContext context)
        {
            _context = context;
        }


        [Authorize(Roles = "Member")]
        public ActionResult Index()
        {
            var activeCustomers = from review in _context.Review
                                   group review by review.UserName into userGroup
                                   select new AccountsAndReviews()
                                   {
                                       UserName = userGroup.Key,
                                       CountReviews = userGroup.Count()
                                   };

            return View(activeCustomers.ToList());
        }


        [Authorize(Roles = "Member")]
        public ActionResult TopMovies()
        {
            
           var movies = _context.Movie.OrderByDescending(m => m.NoOfReviews).Take(5);
           return View(movies.ToList());
        }


        [Authorize(Roles = "Member")]
        public ActionResult LatestReviews()
        {
            var lastReviews = _context.Review.OrderByDescending(c => c.ReviewDate).Take(10);
            return View(lastReviews.ToList());
        }


    }
}