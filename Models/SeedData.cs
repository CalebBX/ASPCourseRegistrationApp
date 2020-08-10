using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPCourseRegistrationApp.Models
{
    public class SeedData
    {
        public static PasswordHasher<ApplicationUser> hasher = new PasswordHasher<ApplicationUser>();

        public static ApplicationUser[] SeedUsers = new ApplicationUser[]
        {
            new ApplicationUser
            {
                Id = "seeduser1",
                UserName = "user1@test.com",
                Email = "user1@test.com",
                NormalizedEmail = "user1@test.com".ToUpper(),
                NormalizedUserName = "user1@test.com".ToUpper(),
                FirstName = "John",
                LastName = "Adel",
                TwoFactorEnabled = false,
                EmailConfirmed = true,
                SecurityStamp = string.Empty,
                PasswordHash = hasher.HashPassword(null, "password")
            },
            new ApplicationUser
            {
                Id = "seeduser2",
                UserName = "user2@test.com",
                Email = "user2@test.com",
                NormalizedEmail = "user2@test.com".ToUpper(),
                NormalizedUserName = "user2@test.com".ToUpper(),
                FirstName = "Sara",
                LastName = "Rogers",
                TwoFactorEnabled = false,
                EmailConfirmed = true,
                SecurityStamp = string.Empty,
                PasswordHash = hasher.HashPassword(null, "password")
            },
            new ApplicationUser
            {
                Id = "seeduser3",
                UserName = "user3@test.com",
                Email = "user3@test.com",
                NormalizedEmail = "user3@test.com".ToUpper(),
                NormalizedUserName = "user3@test.com".ToUpper(),
                FirstName = "Pete",
                LastName = "Smith",
                TwoFactorEnabled = false,
                EmailConfirmed = true,
                SecurityStamp = string.Empty,
                PasswordHash = hasher.HashPassword(null, "password")
            },
            new ApplicationUser
            {
                Id = "seeduser4",
                UserName = "user4@test.com",
                Email = "user4@test.com",
                NormalizedEmail = "user4@test.com".ToUpper(),
                NormalizedUserName = "user4@test.com".ToUpper(),
                FirstName = "Jane",
                LastName = "Write",
                TwoFactorEnabled = false,
                EmailConfirmed = true,
                SecurityStamp = string.Empty,
                PasswordHash = hasher.HashPassword(null, "password")
            }
        };
        public static Faculty[] SeedFaculty = new Faculty[] 
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
            },
            new Faculty
            {
                Id = 102,
                FirstName = "Gregory",
                LastName = "House"
            },
                new Faculty
            {
                Id = 103,
                FirstName = "Heinz",
                LastName = "Doofenshmirtz"
            }
        };
        public static Course[] SeedCourses = new Course[]
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
            new Course
            {
                Id = 102,
                CourseName = "Infection Diseases",
                InstructorId = 102,
                CourseCode = "MED502",
                StartTime = Convert.ToDateTime("10:00:00"),
                EndTime =  Convert.ToDateTime("13:00:00"),
                Location = "Apex Building RM130"
            },
            new Course
            {
                Id = 103,
                CourseName = "Medicine and General Smart-Assery",
                InstructorId = 102,
                CourseCode = "MED120",
                StartTime = Convert.ToDateTime("14:00:00"),
                EndTime =  Convert.ToDateTime("15:00:00"),
                Location = "Apex Building RM130"
            },
            new Course
            {
                Id = 104,
                CourseName = "Intro To Villany",
                InstructorId = 103,
                CourseCode = "VIL101",
                StartTime = Convert.ToDateTime("6:00:00"),
                EndTime =  Convert.ToDateTime("7:00:00"),
                Location = "Tech Complex RM20"
            },
            new Course
            {
                Id = 105,
                CourseName = "Inator-Creation and other Evil Inventions",
                InstructorId = 103,
                CourseCode = "VIL203",
                StartTime = Convert.ToDateTime("8:00:00"),
                EndTime =  Convert.ToDateTime("9:00:00"),
                Location = "Tech Complex RM20"
            },
            new Course
            {
                Id = 106,
                CourseName = "Advanced Platapus Countermeasures",
                InstructorId = 103,
                CourseCode = "VIL210",
                StartTime = Convert.ToDateTime("10:00:00"),
                EndTime =  Convert.ToDateTime("11:00:00"),
                Location = "Tech Complex RM20"
            },
        };
        public static StudentCourse[] SeedStudentCourses = new StudentCourse[]
        {
            new StudentCourse
            {
                StudentId = "seeduser1",
                CourseId = 103
            },
            new StudentCourse
            {
                StudentId = "seeduser1",
                CourseId = 100
            },
            new StudentCourse
            {
                StudentId = "seeduser1",
                CourseId = 104
            },
            new StudentCourse
            {
                StudentId = "seeduser2",
                CourseId = 104
            },
            new StudentCourse
            {
                StudentId = "seeduser2",
                CourseId = 105
            },
            new StudentCourse
            {
                StudentId = "seeduser2",
                CourseId = 106
            },
            new StudentCourse
            {
                StudentId = "seeduser3",
                CourseId = 104
            }
        };

    }

}
