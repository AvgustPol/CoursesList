using LearningAspNetCore_CoursesList.Models;
using LearningAspNetCore_CoursesList.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

namespace LearningAspNetCore_CoursesList.Pages.Courses
{
    public class CreateModel : PageModel
    {
        private readonly MyApplicationDbContext _dbContext;

        public CreateModel(MyApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [BindProperty]
        public Course Course { get; set; }

        [TempData]
        public string Message { get; set; }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            await _dbContext.Courses.AddAsync(Course);
            await _dbContext.SaveChangesAsync();
            Message = AlertMessages.OnCreateMessage;
            return RedirectToPage("Index");
        }
    }
}