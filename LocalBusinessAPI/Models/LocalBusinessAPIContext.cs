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
            new Business { BusinessId = 1, BusinessName = "Toro Bravo", BusinessType = "Restaurant", BusinessAddress = "120 NE Russell St, Portland, OR 97212", OpeningHour = "11 AM", ClosingHour = "6 PM"},
            new Business { BusinessId = 2, BusinessName = "Kachka", BusinessType = "Restaurant", BusinessAddress = "960 SE 11th Ave, Portland, OR 97214", OpeningHour = "12 PM", ClosingHour = "8 PM" },
            new Business { BusinessId = 3, BusinessName = "BAES", BusinessType = "Restaurant", BusinessAddress = "225 SW Ash St, Portland, OR 97204", OpeningHour = "11 AM", ClosingHour = "11 PM" },
            new Business { BusinessId = 4, BusinessName = "ROAR Cat Specialty Gift Shop", BusinessType = "Shop", BusinessAddress = "3012 NE Alberta St, Portland, OR 97211", OpeningHour = "11 AM", ClosingHour = "6 PM" },
            new Business { BusinessId = 5, BusinessName = "MadeHere PDX", BusinessType = "Shop", BusinessAddress = "40 NW 10th Ave, Portland, OR 97209", OpeningHour = "11 AM", ClosingHour = "6 PM" },
            new Business { BusinessId = 6, BusinessName = "Providore Fine Foods", BusinessType = "Shop", BusinessAddress = "2340 NE Sandy Blvd, Portland, OR 97232", OpeningHour = "10 AM", ClosingHour = "6 PM" }
          );
    }
  }
}