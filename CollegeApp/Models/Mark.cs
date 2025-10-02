using CollegeApp.Enums;

namespace CollegeApp.Models
{
    public class Mark
    {
        public int Id { get; set; }
        public string? Comment { get; set; }
        public int StudentId { get; set; }
        public int SubjectId { get; set; }
        public TypeMarkEnum TypeMark { get; set; }
        public int Value { get; set; }
        public required DateOnly Date { get; set; }
        public Student Student { get; set; } = null!;
        public Subject Subject { get; set; } = null!;
    }
}
