using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InstagramDemo.Migrations
{
    /// <inheritdoc />
    public partial class PostHasTags : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hasthags",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hasthags", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PostHashTags",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PostID = table.Column<int>(type: "int", nullable: false),
                    HashTagID = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostHashTags", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PostHashTags_Hasthags_HashTagID",
                        column: x => x.HashTagID,
                        principalTable: "Hasthags",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PostHashTags_Posts_PostID",
                        column: x => x.PostID,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PostHashTags_HashTagID",
                table: "PostHashTags",
                column: "HashTagID");

            migrationBuilder.CreateIndex(
                name: "IX_PostHashTags_PostID",
                table: "PostHashTags",
                column: "PostID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PostHashTags");

            migrationBuilder.DropTable(
                name: "Hasthags");
        }
    }
}
