namespace CollegeApp.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public ICollection<Specialization> Specializations { get; set; } = new List<Specialization>();
        public ICollection<DepartmentHead> Heads { get; set; } = new List<DepartmentHead>();

    }
}
