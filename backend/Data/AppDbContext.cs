using Microsoft.EntityFrameworkCore;
using FeedBackPortal.Models;

namespace FeedBackPortal.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base (options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Seeding categories to be sent to drop down menu client side
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, Name = "Customer Service" },
                new Category { CategoryId = 2, Name = "Product Selection" },
                new Category { CategoryId = 3, Name = "Accessibility" },
                new Category { CategoryId = 4, Name = "Price & Value" }
            );
        }
    }
}