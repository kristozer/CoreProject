using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CoreProject.Models
{
    public class SeedData
    {
        public static async Task InitializeAsync(Context context)
        {
            if (context.Companies.Any())
                return;
            context.Companies.AddRange(new Company { Id = 1, Name = "First company" },
            new Company { Id = 2, Name = "Second company" },
            new Company { Id = 3, Name = "Third company" });

            context.Users.AddRange(new User { Id = 1, Name = "UserF", Age = 20, CompanyId = 1 },
            new User { Id = 2, Name = "UserS", Age = 30, CompanyId = 2 },
            new User { Id = 3, Name = "UserT", Age = 40, CompanyId = 3 });

            await context.SaveChangesAsync();
        }
    }
}