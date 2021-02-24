using Courses.Api.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Courses.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CoursesController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            List<Course> CoursesList = new List<Course>()
            {
                new Course(){CourseId=1 ,CourseName ="CSE"},
                new Course(){CourseId=2 ,CourseName ="QA"},
                new Course(){CourseId=3 ,CourseName ="BA"},
                new Course(){CourseId=4 ,CourseName ="HW"},
            };
            return Ok(CoursesList);
        }
    }
}
