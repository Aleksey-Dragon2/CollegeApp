namespace CollegeApp.Models
{
    public class DepartmentHead
    {
        public int Id { get; set; }
        public int? DepartmentId { get; set; }
        public ApplicationUser User { get; set; } = null!;
        public Department Department { get; set; } = null!;
    }
}
