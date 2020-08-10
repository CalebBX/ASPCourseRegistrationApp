using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ASPCourseRegistrationApp.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string CourseName { get; set; }
        public int? InstructorId { get; set; }
        [ForeignKey("InstructorId")]
        public Faculty Instructor { get; set; }
        public string CourseCode { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public string Location { get; set; }
        public IList<StudentCourse> StudentCourses { get; set; }

    }
}
