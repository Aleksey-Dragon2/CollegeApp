namespace CollegeApp.Models
{
    public class Curator
    {
        public int Id { get; set; }
        public required ApplicationUser User { get; set; }

    }
}
