using Microsoft.EntityFrameworkCore;
using Onion.Models;

namespace Onion.Infrastructure.Context
{
    public class OnionContext : DbContext
    {
        public DbSet<Student> student { get; set; }
        public DbSet<Course> course { get; set; }
        public DbSet<StudentCourse> studentCourse { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=next;Database=day12;integrated security=yes;trustservercertificate=yes;");

            base.OnConfiguring(optionsBuilder);
        }
    }
}
