using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CoursesManagement.Models;

namespace CoursesManagement.Pages.Courses
{
    public class IndexModel : PageModel
    {
        private readonly CoursesManagement.Models.RazorPagesCourseContext _context;

        public IndexModel(CoursesManagement.Models.RazorPagesCourseContext context)
        {
            _context = context;
        }

        public IList<Course> Course { get;set; }

        public async Task OnGetAsync()
        {
            Course = await _context.Course.ToListAsync();
        }
    }
}
