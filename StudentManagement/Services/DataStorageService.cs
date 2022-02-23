using StudentManagement.Models;

namespace StudentManagement.Services
{
    
    public class DataStorageService
    {
        public List<Student> Students = new();
        public List<Professor> Professors = new();
        public List<Course> Courses = new();

        public DataStorageService() {
            this.Dummy();
        }
        public void Dummy() 
        {
            Students.Add(new Student { Name = "dongdong" });
            Students.Add(new Student { Name = "dongdongzhu" });
            Students.Add(new Student { Name = "zoudongdong" });
            Professors.Add(new Professor { Name = "mengdi" });
            Professors.Add(new Professor { Name = "keaimengdi" });
            Professors.Add(new Professor { Name = "qinqinmengdi" });
            Courses.Add(new Course
            {
                CourseName = "algorithm",
                CourseId = 5008,
                CourseSection = "vancouver"
            });
            Courses.Add(new Course
            {
                CourseName = "web",
                CourseId = 5610,
                CourseSection = "vancouver"
            });
            Courses.Add(new Course
            {
                CourseName = "database",
                CourseId = 5200,
                CourseSection = "online"
            });
        }
    }
}
