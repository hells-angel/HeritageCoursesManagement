using Microsoft.EntityFrameworkCore;
using RazorPagesCourse.Models;

namespace RazorPagesCourse.Models
{
    public class RazorPagesCourseContext :  DbContext
    {
        public RazorPagesCourseContext(DbContextOptions<RazorPagesCourseContext> options)
           : base(options)
        {
        }

        public DbSet<RazorPagesCourse.Models.Course>Course { get; set; }
    }
}
