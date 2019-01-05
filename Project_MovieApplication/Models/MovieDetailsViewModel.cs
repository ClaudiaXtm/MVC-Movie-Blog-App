﻿using Project_MovieApplication.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Project_MovieApplication.Models
{
    public class MovieDetailsViewModel
    {
        public Movie Movie { get; set; }
        public List<Review> Reviews { get; set; }

        public int MovieId { get; set; }

        [Required]
        [MinLength(2), MaxLength(2000)]
        [Display(Name = "Comment")]
        public string Content { get; set; }

        [Required]
        [Range(0,10)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Rating { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = "Date of review")]
        public DateTime ReviewDate { get; set; }

        [Display(Name = "Posted by")]
        public virtual string UserName { get; set; }

        public virtual string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }
    }
}
