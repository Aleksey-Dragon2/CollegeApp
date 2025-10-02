using CollegeApp.Enums;

namespace CollegeApp.Models
{
    public class Student
    {
        public int Id { get; set; }
        public required ApplicationUser User { get; set; }
        public GenderEnum Gender { get; set; }
        public DateOnly Birthday { get; set; }
        public DateOnly StartDate { get; set; }
        public string? Address { get; set; }
        public int GroupId { get; set; }
        public required Group Group { get; set; }

        public ICollection<Mark> Marks { get; set; } = new List<Mark>();
    }
}
