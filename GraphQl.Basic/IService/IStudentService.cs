using GraphQl.Basic.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQl.Basic.IService
{
    public interface IStudentService
    {
        public List<Student> GetStudents();
    }
}
