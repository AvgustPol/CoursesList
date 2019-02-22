using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LearningAspNetCore_CoursesList.Models;
using LearningAspNetCore_CoursesList.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace LearningAspNetCore_CoursesList.Pages.Courses
{
    public class IndexModel : PageModel
    {
        private readonly MyApplicationDbContext _dbContext;

        public IEnumerable<Course> Courses { get; set; }

        public IndexModel(MyApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task OnGet()
        {
            Courses = await _dbContext.Courses.ToListAsync();
        }
    }
}