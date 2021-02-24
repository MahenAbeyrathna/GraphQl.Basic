using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Students.Api.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Students.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentsController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            List<Student> studentList = new List<Student>()
            {
                new Student(){Id=1,CouserId=1,Name="abc"},
                new Student(){Id=2,CouserId=2,Name="def"},
                new Student(){Id=3,CouserId=3,Name="ghi"},
                new Student(){Id=4,CouserId=1,Name="jkl"},
                new Student(){Id=5,CouserId=2,Name="mno"},
                new Student(){Id=6,CouserId=1,Name="pqr"},
            };

            return Ok(studentList);
        }
    }
}
