using GraphQl.Basic.DTO;
using GraphQl.Basic.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQl.Basic.Service
{
    public class StudentService : IStudentService
    {
        public List<Student> GetStudents()
        {
            return new List<Student>() {
                new Student(){Name ="abc",Roll ="101",StudentID=1},
                new Student(){Name ="def",Roll ="102",StudentID=2},
                new Student(){Name ="ghi",Roll ="103",StudentID=3},
                new Student(){Name ="jkl",Roll ="104",StudentID=4}
            };
        }
    }
}
