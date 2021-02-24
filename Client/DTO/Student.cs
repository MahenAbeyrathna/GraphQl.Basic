using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQI.Server.DTO
{
    public class Student
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public int CouserId { get; set; }
    }
}
