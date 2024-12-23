using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Course.DAL.Models;
using Microsoft.EntityFrameworkCore;


namespace Course.DAL.Data
{
    public class CourseContext : DbContext
    {
        public CourseContext() { }


        public CourseContext(DbContextOptions<CourseContext> options) : base(options) { }

        public DbSet Courses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Instructor> Instructors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Add configurations if needed, e.g., relationships, constraints, etc.
        }
    }
}
