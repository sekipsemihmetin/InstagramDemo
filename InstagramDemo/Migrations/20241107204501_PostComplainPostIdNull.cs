using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InstagramDemo.Migrations
{
    /// <inheritdoc />
    public partial class PostComplainPostIdNull : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PostComplains_Posts_PostId",
                table: "PostComplains");

            migrationBuilder.AlterColumn<int>(
                name: "PostId",
                table: "PostComplains",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 7, 23, 45, 0, 957, DateTimeKind.Local).AddTicks(4794));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 7, 23, 45, 0, 957, DateTimeKind.Local).AddTicks(4809));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 7, 23, 45, 0, 957, DateTimeKind.Local).AddTicks(4810));

            migrationBuilder.AddForeignKey(
                name: "FK_PostComplains_Posts_PostId",
                table: "PostComplains",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PostComplains_Posts_PostId",
                table: "PostComplains");

            migrationBuilder.AlterColumn<int>(
                name: "PostId",
                table: "PostComplains",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 7, 14, 22, 28, 599, DateTimeKind.Local).AddTicks(8224));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 7, 14, 22, 28, 599, DateTimeKind.Local).AddTicks(8241));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 7, 14, 22, 28, 599, DateTimeKind.Local).AddTicks(8244));

            migrationBuilder.AddForeignKey(
                name: "FK_PostComplains_Posts_PostId",
                table: "PostComplains",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
