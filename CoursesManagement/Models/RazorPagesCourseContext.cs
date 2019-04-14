using Microsoft.EntityFrameworkCore;

namespace CoursesManagement.Models
{
    public class RazorPagesCourseContext : DbContext
    {
        public RazorPagesCourseContext(DbContextOptions<RazorPagesCourseContext> options)
            : base(options)
        {
        }

        public DbSet<CoursesManagement.Models.Course> Course { get; set; }
    }
}
