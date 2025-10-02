namespace CollegeApp.Models
{
    public class Curator
    {
        public int Id { get; set; }
        public int? GroupId { get; set; }
        public Group Group { get; set; } = null!;
        public ApplicationUser User { get; set; } = null!;

    }
}
