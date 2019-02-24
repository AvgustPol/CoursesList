using System.ComponentModel.DataAnnotations;

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