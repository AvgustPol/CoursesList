using LearningAspNetCore_CoursesList.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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