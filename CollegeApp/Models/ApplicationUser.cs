using Microsoft.AspNetCore.Identity;
namespace CollegeApp.Models
{
    public class ApplicationUser : IdentityUser
    {
       public string Name { get; set; } = null!;
       public string LastName { get; set; } = null!;
       public string? MiddleName{ get; set; }
        public ICollection<Student> Students { get; set; } = new List<Student>();
        public ICollection<Teacher> Teachers { get; set; } = new List<Teacher>();
        public ICollection<Curator> Curators { get; set; } = new List<Curator>();
        public ICollection<DepartmentHead> DepartmentHeads { get; set; } = new List<DepartmentHead>();
    }
}
