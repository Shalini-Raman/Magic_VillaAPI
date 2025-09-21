using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Magic_VillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedVillaTableWithCreatedDate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 21, 21, 18, 20, 112, DateTimeKind.Local).AddTicks(4543));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 21, 21, 18, 20, 112, DateTimeKind.Local).AddTicks(4553));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 21, 21, 18, 20, 112, DateTimeKind.Local).AddTicks(4555));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 21, 21, 18, 20, 112, DateTimeKind.Local).AddTicks(4556));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 9, 21, 21, 18, 20, 112, DateTimeKind.Local).AddTicks(4558));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
