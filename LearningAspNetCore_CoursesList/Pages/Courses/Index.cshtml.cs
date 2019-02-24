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

        public IndexModel(MyApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Course> Courses { get; set; }
        public bool IsCoursesAvaible => Courses.Count() != 0;

        [TempData]
        public string Message { get; set; }

        public async Task OnGetAsync()
        {
            Courses = await _dbContext.Courses.ToListAsync();
        }

        public async Task<IActionResult> OnPostDeleteAsync(int id)
        {
            var courseToDelete = await _dbContext.Courses.FindAsync(id);
            if (courseToDelete == null)
            {
                return NotFound(AlertMessages.ThereIsNoCourseWithId(id));
            }

            _dbContext.Courses.Remove(courseToDelete);
            await _dbContext.SaveChangesAsync();

            Message = AlertMessages.OnDeleteMessage;
            return RedirectToPage();
        }
    }
}