using Microsoft.EntityFrameworkCore;

namespace LocalBusinessAPI.Models
{
  public class LocalBusinessAPIContext : DbContext
  {
    public LocalBusinessAPIContext(DbContextOptions<LocalBusinessAPIContext> options)
        : base(options)
    {
    }

    public DbSet<Business> Businesses { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Business>()
          .HasData(
            new Business { BusinessId = 1, BusinessName = "United States", BusinessType = "New York City", BusinessAddress = "123 Main", OpeningHour = "11 AM", ClosingHour = "6 PM"}
          );
    }
  }
}