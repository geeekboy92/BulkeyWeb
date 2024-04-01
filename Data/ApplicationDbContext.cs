using BulkeyWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace BulkeyWeb.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options){}

    public DbSet<Category> Categories { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>().HasData(
            new Category { Id = 1, DisplayOrder = 1, Name = "Math"},
            new Category { Id = 2, DisplayOrder = 2, Name = "SiFi" },
            new Category { Id = 3, DisplayOrder = 3, Name = "History" },
            new Category { Id = 4, DisplayOrder = 4, Name = "Story" });
    }

}
