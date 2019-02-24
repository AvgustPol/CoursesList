using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LearningAspNetCore_CoursesList.Models;
using LearningAspNetCore_CoursesList.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

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

        public void OnGet(int id)
        {
            Course = _dbContext.Courses.Find(id);
        }
    }
}