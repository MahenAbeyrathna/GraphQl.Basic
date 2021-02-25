using GraphQI.Server.DTO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace GraphQI.Server
{
    public class ServerManager
    {
        public  async Task<StudentCoursesData> GetData()
        {
            List<Student> studentList = new List<Student>();
            List<Course> courseList = new List<Course>();
            // calling student api
            using (HttpClient client = GetHttpClient("http://localhost:4111"))
            {
                var response = await client.GetAsync("students");
                if (response.IsSuccessStatusCode)
                {
                    var studentData = await response.Content.ReadAsStringAsync();
                    studentList = JsonConvert.DeserializeObject<List<Student>>(studentData);

                }
            }

            // calling courses api
            using (HttpClient client = GetHttpClient("http://localhost:4131"))
            {
                var response = await client.GetAsync("courses");
                if (response.IsSuccessStatusCode)
                {
                    var CourseData = await response.Content.ReadAsStringAsync();
                    courseList = JsonConvert.DeserializeObject<List<Course>>(CourseData);
                }
            }
            var result = from s in studentList
                         join c in courseList on s.CouserId equals c.CourseId
                         select ( new StudentCourses()
                         {
                             Name = s.Name,
                             Id = s.Id,
                             Courses = c.CourseName
                         });
            StudentCoursesData data = new StudentCoursesData()
            {
                StudentCoursesList = result.ToList(),
                StudentList = studentList,
                CourseList = courseList
            };
            return data;
        }
        private static HttpClient GetHttpClient(string baseUrl)
        {
            HttpClient client = new HttpClient()
            {
                BaseAddress = new Uri(baseUrl),
                Timeout = TimeSpan.FromMilliseconds(300000)
            };

            return client;
        }

    }
}
