using System.Collections.Generic;

namespace ASP_ViewComponent.Models
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        List<Student> students { get; set; }    
    }
}
