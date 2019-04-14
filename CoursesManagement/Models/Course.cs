using System;
using System.ComponentModel.DataAnnotations;

namespace CoursesManagement.Models
{
    public class Course
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public double Credits { get; set; }
        public int Length { get; set; }
    }
}