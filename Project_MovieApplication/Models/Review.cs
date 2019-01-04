using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Project_MovieApplication.Models
{
    public class Review
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(2), MaxLength(2000)]
        public string Content { get; set; }

        [Required]
        [Range(0, 10)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Rating { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Date of review")]
        public DateTime ReviewDate { get; set; }

        public virtual Movie MovieReview { get; set; }
    }
}
