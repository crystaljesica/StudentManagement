using System.ComponentModel.DataAnnotations;

namespace StudentManagement.Models
{
    public class Professor
    {
        public string Name { get; set; }

        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
    }
}
