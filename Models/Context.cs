using Microsoft.EntityFrameworkCore;
namespace CoreProject.Models
{
    public class Context : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Company> Companies { get; set; }
        public Context(DbContextOptions<Context> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
        
    }
}