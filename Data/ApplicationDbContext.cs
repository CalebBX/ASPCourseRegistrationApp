using System;
using System.Collections.Generic;
using System.Text;
using ASPCourseRegistrationApp.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ASPCourseRegistrationApp.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Faculty> FacultyMembers { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<StudentCourse>()
                .HasKey(sc => new { sc.StudentId, sc.CourseId });
            builder.Entity<StudentCourse>()
               .HasOne(sc => sc.Student)
               .WithMany(s => s.StudentCourses)
               .HasForeignKey(sc => sc.StudentId);
            builder.Entity<StudentCourse>()
                .HasOne(sc => sc.Course)
                .WithMany(c => c.StudentCourses)
                .HasForeignKey(sc => sc.CourseId);
           


            builder.Entity<Faculty>().HasData(
                new Faculty[]
                {
                    new Faculty
                    {
                        Id = 100,
                        FirstName = "Kick",
                        LastName = "Buttowski"
                    },
                    new Faculty
                    {
                        Id = 101,
                        FirstName = "Ace",
                        LastName = "Ventura"
                    }
                }
                );
            builder.Entity<Course>().HasData(
               new Course[]
               {
                    new Course
                    {
                        Id = 100,
                        CourseName = "Intro To Dare-Deviling",
                        InstructorId = 100,
                        CourseCode = "DD101",
                        StartTime = Convert.ToDateTime("10:00:00"),
                        EndTime =  Convert.ToDateTime("11:00:00"),
                        Location = "Granger Building RM340"
                    },
                    new Course
                    {
                        Id = 101,
                        CourseName = "Advanced Criminology",
                        InstructorId = 101,
                        CourseCode = "CM230",
                        StartTime = Convert.ToDateTime("08:00:00"),
                        EndTime =  Convert.ToDateTime("09:00:00"),
                        Location = "Apex Building RM110"
                    },

               }
               );
        }
    }
}
