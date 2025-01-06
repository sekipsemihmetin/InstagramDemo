using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InstagramDemo.Migrations
{
    /// <inheritdoc />
    public partial class IsAdmin1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 8, 15, 4, 31, 297, DateTimeKind.Local).AddTicks(8426));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 8, 15, 4, 31, 297, DateTimeKind.Local).AddTicks(8441));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 8, 15, 4, 31, 297, DateTimeKind.Local).AddTicks(8443));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedDate", "Email", "ImagePath", "IsAdmin", "Password", "Username" },
                values: new object[,]
                {
                    { 3, new DateTime(2024, 11, 8, 15, 4, 31, 297, DateTimeKind.Local).AddTicks(8507), "admin@gmail.com", null, true, "admin", "Admin" },
                    { 4, new DateTime(2024, 11, 8, 15, 4, 31, 297, DateTimeKind.Local).AddTicks(8527), "admin1@gmail.com", null, true, "admin1", "Admin1" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 8, 14, 23, 1, 853, DateTimeKind.Local).AddTicks(5331));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 8, 14, 23, 1, 853, DateTimeKind.Local).AddTicks(5346));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 8, 14, 23, 1, 853, DateTimeKind.Local).AddTicks(5348));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedDate", "Email", "ImagePath", "IsAdmin", "Password", "Username" },
                values: new object[] { 2, new DateTime(2024, 11, 8, 14, 23, 1, 853, DateTimeKind.Local).AddTicks(5446), "admin@gmail.com", null, true, "admin", "Admin" });
        }
    }
}
