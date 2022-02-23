using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentManagement.Models;
using StudentManagement.Services;

namespace StudentManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentManagementController : ControllerBase
    {
        private readonly DataStorageService data;
        private readonly ManagementContext management;

        public StudentManagementController(DataStorageService d, ManagementContext m)
        {
            this.data = d;
            this.management = m;
        }

        [HttpGet("students")]
        public List<Student> GetStudents() {
            return management.students.ToList();
        }

        [HttpGet("professors")]
        public List<Professor> GetProfesors()
        {
            return data.Professors;
        }

        [HttpGet("courses")]
        public List<Course> GetCourses()
        {
            return data.Courses;
        }

        [HttpPost("students")]
        public IActionResult AddStudents(Student s)
        {
            management.students.Add(s);
            management.SaveChanges();
            return Ok();
        }

        [HttpGet("selectstudents")]
        public List<Student> SelectStudents(int i)
        {
            var result = from s in management.students
                         where s.Age > i
                         select s;
            return result.ToList();
        }


    }
}
