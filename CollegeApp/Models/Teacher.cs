namespace CollegeApp.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public ApplicationUser User { get; set; } = null!;
        public ICollection<TeacherSubject> TeacherSubjects { get; set; } = new List<TeacherSubject>();

    }
}
