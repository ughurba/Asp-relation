using System.Collections.Generic;

namespace ASP_ViewComponent.Models
{
    public class Genre
    {
        public int Id { get; set; }
        public string genre { get; set; }
        List<Book> books { get; set; }
    }
}
