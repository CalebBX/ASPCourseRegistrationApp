using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPCourseRegistrationApp.Data;
using ASPCourseRegistrationApp.Models;
using ASPCourseRegistrationApp.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ASPCourseRegistrationApp.Controllers
{
    public class CourseController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CourseController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            IEnumerable<Course> allCourses = _context.Courses.Include(course => course.Instructor);

            List<Tuple<Course, bool>> viewModel = new List<Tuple<Course, bool>>();

            ApplicationUser student = User.Identity.IsAuthenticated ? _context.Users.FirstOrDefault(appUser => appUser.UserName == User.Identity.Name) : null;

            IEnumerable<Course> registeredCourses = student != null ?
                _context.StudentCourses.Where(sc => sc.StudentId == student.Id).Select(sc => sc.Course) : null;

            foreach (Course course in allCourses)
            {
                if (registeredCourses != null)
                {
                    bool isRegistered = registeredCourses.Any(registeredCourse => registeredCourse.Id == course.Id);
                    viewModel.Add(Tuple.Create(course, isRegistered));
                }
                else
                {
                    viewModel.Add(Tuple.Create(course, false));
                }

            }
            return View(viewModel);
        }
        [HttpPost]
        [Authorize]
        public IActionResult RegisterCourses(int[] registeredCourseIds)
        {
            if (ModelState.IsValid)
            {
                ApplicationUser student = User.Identity.IsAuthenticated ? _context.Users.FirstOrDefault(appUser => appUser.UserName == User.Identity.Name) : null;
                if (student != null)
                {
                    IEnumerable<Course> coursesToRegister = _context.Courses.Where(course => registeredCourseIds.Contains(course.Id));

                    IEnumerable<StudentCourse> studentCourses = _context.StudentCourses.Where(sc => sc.StudentId == student.Id);

                    // Add courses that were posted
                    foreach(Course courseToRegister in coursesToRegister)
                    {
                        if(!studentCourses.Any(sc => sc.CourseId == courseToRegister.Id))
                        {
                            StudentCourse studentCourse = new StudentCourse
                            {
                                Course = courseToRegister,
                                Student = student,
                            };
                            _context.StudentCourses.Add(studentCourse);
                        }
                    }
                    // Remove Courses that were not posted
                    foreach(StudentCourse studentCourse in studentCourses)
                    {
                        if(!coursesToRegister.Any(c => studentCourse.CourseId == c.Id))
                        {
                            _context.StudentCourses.Remove(studentCourse);
                        }
                    }
                    _context.SaveChanges();
                    return View(coursesToRegister);
                }

            }
            Response.StatusCode = 500;
            return View();
        }
        [Authorize]
        public IActionResult RegisteredCoursesReport()
        {
            IEnumerable<StudentCourse> studentCourses = _context.StudentCourses
                .Include(sc => sc.Course)
                .Include(sc => sc.Course.Instructor)
                .Include(sc=>sc.Student)
                .OrderBy(sc => sc.Course.CourseName);

            return View(studentCourses);
        }
        [Authorize]
        public IActionResult MyCourses()
        {
            ApplicationUser student = User.Identity.IsAuthenticated ? _context.Users.FirstOrDefault(appUser => appUser.UserName == User.Identity.Name) : null;
            if(student!= null)
            {
                ICollection<Course> courses = _context.StudentCourses
                    .Where(sc => sc.StudentId == student.Id)
                    .Include(sc => sc.Course.Instructor)
                    .Select(sc => sc.Course)
                    .OrderBy(c => c.StartTime)
                    .ThenBy(c => c.CourseName)
                    .ToList();
                return View(courses);
            }
            Response.StatusCode = 500;
            return View();
        }
    }
}
