using System.ComponentModel.DataAnnotations;

namespace StudentManagement.Models
{
    public class Course
    {
        public string CourseName { get; set; }
        public int CourseId { get; set; }
        public string CourseSection { get; set;}

        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
    }
}
