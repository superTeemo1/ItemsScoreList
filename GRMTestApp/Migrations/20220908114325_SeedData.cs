using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GRMTestApp.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Item",
                columns: new[] { "ItemID", "Name", "Position", "Score" },
                values: new object[,]
                {
                    { 1, "Item1", 1, 0 },
                    { 2, "Item2", 2, 0 },
                    { 3, "Item3", 3, 0 },
                    { 4, "Item4", 4, 0 },
                    { 5, "Item5", 5, 0 },
                    { 6, "Item6", 6, 0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "ItemID",
                keyValue: 6);
        }
    }
}
