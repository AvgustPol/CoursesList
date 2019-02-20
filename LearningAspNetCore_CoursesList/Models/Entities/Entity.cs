using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LearningAspNetCore_CoursesList.Models.Entities
{
    /// <summary>
    /// Just class for creating an abstraction
    /// </summary>
    public abstract class Entity
    {
        [Key]
        public int Id { get; set; }
    }
}