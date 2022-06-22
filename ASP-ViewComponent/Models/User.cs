using System.Collections.Generic;

namespace ASP_ViewComponent.Models
{
    public class User
    {
        public int Id{ get; set; }
        public string Name{ get; set; }
        public int age { get; set; }
        List<SosialAccount> sosialAccounts { get; set; }
    }
}
