using ASP_ViewComponent.Models;
using Microsoft.EntityFrameworkCore;

namespace ASP_ViewComponent.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet <Book> Books { get; set; }
        public DbSet<Enrollments> enrollments { get; set; }
        public DbSet <Genre> Genres { get; set; }

        public DbSet <User> users { get; set; } 
        public DbSet<SosialAccount> sosialAccounts{ get; set; }
        public DbSet<Group> groups { get; set; }
        public DbSet<Student> students { get; set; }

       
    }
}
