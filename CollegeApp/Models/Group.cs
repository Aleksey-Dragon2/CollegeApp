using CollegeApp.Enums;
namespace CollegeApp.Models
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public FormEducationEnum FormEducation { get; set; }
        public BaseLearnEnum BaseLearn { get; set; }
        public int SpecializationId { get; set; }
        public Specialization Specialization { get; set; } = null!;
        public int CourseNumber { get; set; }
        public ICollection<Student> Students { get; set; } = new List<Student>();
    }
}
