using Microsoft.EntityFrameworkCore.Migrations;

namespace LocalBusinessAPI.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "BusinessId", "BusinessAddress", "BusinessName", "BusinessType", "ClosingHour", "OpeningHour" },
                values: new object[,]
                {
                    { 1, "120 NE Russell St, Portland, OR 97212", "Toro Bravo", "Restaurant", "6 PM", "11 AM" },
                    { 2, "960 SE 11th Ave, Portland, OR 97214", "Kachka", "Restaurant", "8 PM", "12 PM" },
                    { 3, "225 SW Ash St, Portland, OR 97204", "BAES", "Restaurant", "11 PM", "11 AM" },
                    { 4, "3012 NE Alberta St, Portland, OR 97211", "ROAR Cat Specialty Gift Shop", "Shop", "6 PM", "11 AM" },
                    { 5, "40 NW 10th Ave, Portland, OR 97209", "MadeHere PDX", "Shop", "6 PM", "11 AM" },
                    { 6, "2340 NE Sandy Blvd, Portland, OR 97232", "Providore Fine Foods", "Shop", "6 PM", "10 AM" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 6);
        }
    }
}
