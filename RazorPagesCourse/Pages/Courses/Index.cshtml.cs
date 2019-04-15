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

        public IList<Course> Course { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        // Requires using Microsoft.AspNetCore.Mvc.Rendering;
        public string Title { get; set; }
        [BindProperty(SupportsGet = true)]
        public string Description { get; set; }
        public async Task OnGetAsync()
        {
            var movies = from m in _context.Course
                         select m;
            if (!string.IsNullOrEmpty(SearchString))
            {
                movies = movies.Where(s => s.Title.Contains(SearchString));
            }

            Course = await _context.Course.ToListAsync();
        }
    }
}
