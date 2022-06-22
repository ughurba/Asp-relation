using System.Collections.Generic;

namespace ASP_ViewComponent.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }

        List<Genre> genres { get; set; }

    }
}
