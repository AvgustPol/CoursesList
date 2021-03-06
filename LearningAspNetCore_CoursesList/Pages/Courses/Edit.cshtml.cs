﻿using LearningAspNetCore_CoursesList.Models;
using LearningAspNetCore_CoursesList.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

namespace LearningAspNetCore_CoursesList.Pages.Courses
{
    public class EditModel : PageModel
    {
        private readonly MyApplicationDbContext _dbContext;

        public EditModel(MyApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [BindProperty]
        public Course Course { get; set; }

        [TempData]
        public string Message { get; set; }

        public async Task OnGetAsync(int id)
        {
            Course = await _dbContext.Courses.FindAsync(id);
        }

        public async Task<IActionResult> OnPostAsync(int id)
        {
            if (ModelState.IsValid)
            {
                var course = await _dbContext.Courses.FindAsync(id);
                course.Name = Course.Name;
                course.Description = Course.Description;
                course.Author = Course.Author;

                await _dbContext.SaveChangesAsync();
                Message = AlertMessages.OnUpdateMessage;
                return RedirectToPage("Index");
            }

            return RedirectToPage();
        }
    }
}