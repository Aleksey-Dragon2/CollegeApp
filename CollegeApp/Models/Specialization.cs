namespace CollegeApp.Models
{
    public class Specialization
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public ICollection<Group> Groups { get; set; } = new List<Group>();
        public ICollection<Subject> Subjects { get; set; } = new List<Subject>();

    }
}
