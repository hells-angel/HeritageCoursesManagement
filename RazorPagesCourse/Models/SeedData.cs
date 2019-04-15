using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace RazorPagesCourse.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesCourseContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorPagesCourseContext>>()))
            {
                // Look for any movies.
                if (context.Course.Any())
                {
                    return;   // DB has been seeded
                }

                context.Course.AddRange(
                    new Course
                    {
                        Title = "When Harry Met Sally",
                        Description = "hsey",
                        Length = 1,
                        Credit = 20
                    },

                    new Course
                    {
                        Title = "When lly",
                        Description = "shey",
                        Length = 1,
                        Credit = 20
                    },

                    new Course
                    {
                        Title = "When  Sally",
                        Description = "hedy",
                        Length = 1,
                        Credit = 20
                    },

                    new Course
                    {
                        Title = "Harry Met Sally",
                        Description = "hfey",
                        Length = 1,
                        Credit = 20
                    }
                );
                context.SaveChanges();
            }
        }
    }
}