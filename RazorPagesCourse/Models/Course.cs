﻿using System;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesCourse.Models
{
    public class Course
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Length { get; set; }
        public decimal Credit { get; set; }
    }
}