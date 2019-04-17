using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesCourse.Models;

namespace RazorPagesCourse.Pages.Courses
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesCourse.Models.RazorPagesCourseContext _context;

        public IndexModel(RazorPagesCourse.Models.RazorPagesCourseContext context)
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
