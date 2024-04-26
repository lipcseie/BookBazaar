using Bazaar.Models;
using Microsoft.EntityFrameworkCore;

namespace Bazaar.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Cooking", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Fantasy", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Self-Help", DisplayOrder = 3 },
                new Category { Id = 4, Name = "Adventure", DisplayOrder = 4 }
                );
        }
    }
}
