using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Project_MovieApplication.Models;

namespace Project_MovieApplication.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<Project_MovieApplication.Models.Movie> Movie { get; set; }
        public DbSet<Project_MovieApplication.Models.Review> Review { get; set; }
     
    
    }
}
