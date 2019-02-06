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
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Company>().HasData(
                new Company { Id = 1, Name = "First company" },
                new Company { Id = 2, Name = "Second company" },
                new Company { Id = 3, Name = "Third company" });

            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, Name = "UserF", Age = 20, CompanyId = 1 },
                new User { Id = 2, Name = "UserS", Age = 30, CompanyId = 2 },
                new User { Id = 3, Name = "UserT", Age = 40, CompanyId = 3 });

            base.OnModelCreating(modelBuilder);
        }

    }
}