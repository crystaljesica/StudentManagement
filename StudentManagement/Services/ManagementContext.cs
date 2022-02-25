using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql;
using StudentManagement.Models;

namespace StudentManagement.Services
{
    public class ManagementContext: DbContext
    {
        public DbSet<Student> students { get; set; }
        public DbSet<Professor> professors { get; set; }

        public DbSet<Course> courses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "server=localhost;user=root;password=abc123;database=atguigudb";
            optionsBuilder.UseMySql(connectionString,ServerVersion.AutoDetect(connectionString));
        }
    }

   
}
