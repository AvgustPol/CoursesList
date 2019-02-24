using System.ComponentModel.DataAnnotations;

namespace LearningAspNetCore_CoursesList.Models.Entities
{
    public class Course : Entity
    {
        public string Author { get; set; }

        public string Description { get; set; }

        [Required]
        [Display(Name = "Course name")]
        public string Name { get; set; }
    }
}