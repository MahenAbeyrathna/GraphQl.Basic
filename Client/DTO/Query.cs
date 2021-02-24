using System.Collections.Generic;
using System.Linq;

namespace GraphQI.Server.DTO
{
    public class Query
    {
        List<StudentCourses> list;
        public Query()
        {
            list = new ServerManager().GetData().Result.ToList();
        }
        public List<StudentCourses> StudentCourses => list;
    }
}
