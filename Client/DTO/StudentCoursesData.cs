using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQI.Server.DTO
{
    public class StudentCoursesData
    {
        public List<StudentCourses> StudentCoursesList { get; set; }
        public List<Student> StudentList { get; set; }
        public List<Course> CourseList { get; set; }
    }
}
