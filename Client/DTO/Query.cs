using System.Collections.Generic;
using System.Linq;

namespace GraphQI.Server.DTO
{
    public class Query
    {
        StudentCoursesData list;
        public Query()
        {
            list = new ServerManager().GetData().Result;
        }
        public StudentCoursesData StudentCourses => list;
    }
}
