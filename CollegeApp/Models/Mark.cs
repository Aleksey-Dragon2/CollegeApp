using CollegeApp.Enums;

namespace CollegeApp.Models
{
    public class Mark
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int SubjectId { get; set; }
        public TypeMarkEnum TypeMark { get; set; }
        public int Value { get; set; }
        public required DateOnly Date { get; set; }
    }
}
