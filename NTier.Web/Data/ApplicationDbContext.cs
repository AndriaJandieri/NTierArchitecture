using Microsoft.EntityFrameworkCore;
using NTier.Web.Models;

namespace NTier.Web.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Category> CategoriesN { get; set; }

        override protected void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "ActionN", DisplayOrder = 1 },
                new Category { Id = 2, Name = "SciFiN", DisplayOrder = 2 },
                new Category { Id = 3, Name = "HistoryN", DisplayOrder = 3 }
            );
        }
    }
}
