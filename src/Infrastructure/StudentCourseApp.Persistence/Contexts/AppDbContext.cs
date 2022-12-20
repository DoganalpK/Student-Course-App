using Microsoft.EntityFrameworkCore;
using StudentCourseApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCourseApp.Persistence.Contexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(
                new Student()
                {
                    Id = Guid.NewGuid(),
                    Name = "ali",
                    Surname = "veli"
                },
                new Student()
                {
                    Id = Guid.NewGuid(),
                    Name = "ayşe",
                    Surname = "fatma"
                }
            );
            base.OnModelCreating(modelBuilder);
        }
        
    }
}
