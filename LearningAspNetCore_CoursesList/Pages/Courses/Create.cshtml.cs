using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LearningAspNetCore_CoursesList.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LearningAspNetCore_CoursesList.Pages.Courses
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public Course Course { get; set; }

        public void OnGet()
        {
        }
    }
}