using CollegeApp.Enums;
using System.Text.RegularExpressions;

namespace CollegeApp.Models
{
    public class Student
    {
        public int Id { get; set; }
        public GenderEnum Gender { get; set; }
        public DateOnly Birthday { get; set; }
        public DateOnly StartDate { get; set; }
        public string? Address { get; set; }
        public string? PhoneNumber { get; set; }
        public int GroupId { get; set; }
        public required Group Group { get; set; }
    }
}
