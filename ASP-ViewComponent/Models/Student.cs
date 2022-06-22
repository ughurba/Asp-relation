namespace ASP_ViewComponent.Models
{
    public class Student
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public int GroupId { get; set; }    
        public Group group { get; set; }
    }
}
