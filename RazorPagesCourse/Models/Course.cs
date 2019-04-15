using System;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesCourse.Models
{
    public class Course
    {
        public int ID { get; set; }


        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Title { get; set; }

        
        public string Description { get; set; }


        [Range(1, 200)]
        public int Length { get; set; }

        [Range(1, 20)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Credit { get; set; }
    }
}