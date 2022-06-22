namespace ASP_ViewComponent.Models
{
    public class SosialAccount
    {
        public int Id { get; set; }
        public string Name{ get; set; }
        public int UserId { get; set; }
        public User user { get; set; }

    }
}
