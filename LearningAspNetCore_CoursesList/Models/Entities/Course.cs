using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LearningAspNetCore_CoursesList.Models.Entities
{
    public class Course : Entity
    {
        [Required]
        [Display(Name = "Course name")]
        public string Name { get; set; }

        public string Description { get; set; }

        public string Author { get; set; }
    }
}