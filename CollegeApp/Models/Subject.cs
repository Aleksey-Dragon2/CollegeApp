namespace CollegeApp.Models
{
    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int SpecializationId { get; set; }
        public Specialization Specialization { get; set; } = null!;
        public int CourseId { get; set; }
        public required Course Course { get; set; } = null!;
    }
}
