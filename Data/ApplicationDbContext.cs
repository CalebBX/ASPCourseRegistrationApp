using System;
using System.Collections.Generic;
using System.Text;
using ASPCourseRegistrationApp.Models;
using Microsoft.AspNetCore.Identity;
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


            //Seed Data

            builder.Entity<ApplicationUser>().HasData(SeedData.SeedUsers);
            builder.Entity<Faculty>().HasData(SeedData.SeedFaculty);
            builder.Entity<Course>().HasData(SeedData.SeedCourses);
            builder.Entity<StudentCourse>().HasData(SeedData.SeedStudentCourses);

            base.OnModelCreating(builder);
        }
    }
}
