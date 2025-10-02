using CollegeApp.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace CollegeApp.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Mark>()
    .HasOne(m => m.Subject)
    .WithMany() // или с коллекцией Marks
    .HasForeignKey(m => m.SubjectId)
    .OnDelete(DeleteBehavior.Restrict); // SQL Server больше не ругается
        }
        public DbSet<DepartmentHead> DepartmentHeads { get; set; }
        public DbSet<Curator> Curator { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<TeacherSubject> TeachersSubjects { get; set; }
        public DbSet<Specialization> Specializations { get; set; }
        public DbSet<Mark> Marks { get; set; }

    }
}
