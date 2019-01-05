using Project_MovieApplication.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Project_MovieApplication.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(128)]
        public string Title { get; set; }

        [Required]
        [MaxLength(1000)]
        public string Description { get; set; }

        [Required]
        [Range(0, 10)]
        [Display(Name ="Movie score")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal AverageRating { get; set; }

        [EnumDataType(typeof(Genre))]
        [Display(Name = "Movie genre")]
        public Genre MovieGenre { get; set; }

        [Display(Name = "No of reviews")]
        public int NoOfReviews { get; set; }

        [Display(Name = "Posted by")]
        public virtual string UserName { get; set; }

        public virtual string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }
    }

    public enum Genre
    {
        Action,
        Adventure,
        Comedy,
        Crime,
        Drama,
        Historical,
        Horror,
        Romance,
        Musical,
        SF,
        Western
    }

}
