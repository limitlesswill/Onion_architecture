namespace Onion.Models
{
    public class Student
    {
        public int id {  get; set; }
        public string? name { get; set; }
        public List<StudentCourse>? StudentCourseList { get; set; }
    }
}
