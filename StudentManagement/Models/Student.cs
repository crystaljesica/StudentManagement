using System.ComponentModel.DataAnnotations;

namespace StudentManagement.Models
{
    public class Student
    {
        public string Name { get; set; }

        public int Age { get; set; }

        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
    }
}
