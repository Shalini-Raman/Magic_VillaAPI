using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Magic_VillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedVillaTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "ID", "Amenity", "CreatedDate", "Details", "ImageUrl", "Name", "Occupancy", "Rate", "Sqft", "UpdateDate" },
                values: new object[,]
                {
                    { 1, "Pool", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "TEST kjhrjhh", "", "Royals", 5, 200.0, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "Pool", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "TEST kjhrjhh", "", "Royals 2", 3, 2000.0, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "Pool", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "TEST kjhrjhh", "", "Royals 3", 50, 20000.0, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "Pool", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "TEST kjhrjhh", "", "Royals 4", 500, 200000.0, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "Pool", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "TEST kjhrjhh", "", "Royals 5", 78, 20099.0, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "ID",
                keyValue: 5);
        }
    }
}
