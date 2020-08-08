using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPCourseRegistrationApp.Data;
using ASPCourseRegistrationApp.Models;
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

            return View(allCourses);
        }
    }
}
