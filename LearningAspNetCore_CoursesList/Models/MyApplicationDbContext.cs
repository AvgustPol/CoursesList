using LearningAspNetCore_CoursesList.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace LearningAspNetCore_CoursesList.Models
{
    public class MyApplicationDbContext : DbContext
    {
        public MyApplicationDbContext(DbContextOptions<MyApplicationDbContext> dbContextOptions) : base(dbContextOptions)
        {
        }

        public DbSet<Course> Courses { get; set; }
    }
}