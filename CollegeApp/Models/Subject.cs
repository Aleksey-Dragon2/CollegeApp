namespace CollegeApp.Models
{
    public class Subject
    {
        public int Id { get; set; }
        public required string Name { get; set; } = null!;
        public int CursId { get; set; }
        public required Curs Curs { get; set; } = null!;
    }
}
