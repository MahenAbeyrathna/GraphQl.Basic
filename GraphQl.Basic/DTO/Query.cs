using GraphQl.Basic.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQl.Basic.DTO
{
    public class Query
    {
        IStudentService _studentService = null;

        public Query(IStudentService studentService)
        {
            _studentService = studentService;
        }
        public List<Student> Students => _studentService.GetStudents();
    }
}
