using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        public ActionResult Index()
        {
            var data =
               from review in _context.Review
               group review by review.UserName into userGroup
               select new AccountsAndReviews()
               {
                   UserName = userGroup.Key,
                   CountReviews = userGroup.Count()
               };

            return View(data.ToList());
        }

        
    }
}