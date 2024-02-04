namespace Onion.Models
{
    public class Course
    {
        public int id { get; set; }
        public string? name { get; set; }
        public double? duration { get; set; }
        public List<StudentCourse>? StudentCourseList { get; set; }
    }
}
