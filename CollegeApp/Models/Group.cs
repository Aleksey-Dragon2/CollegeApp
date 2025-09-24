using CollegeApp.Enums;
namespace CollegeApp.Models
{
    public class Group
    {
        public int Id { get; set; }
        public required string Name { get; set; } = null!;
        public string? Specialization { get; set; }
        public FormEducationEnum FormEducation { get; set; }
        public BaseLearnEnum BaseLearn { get; set; }
        public int CursId { get; set; }

        public required Curs Curs { get; set; } = null!;
    }
}
