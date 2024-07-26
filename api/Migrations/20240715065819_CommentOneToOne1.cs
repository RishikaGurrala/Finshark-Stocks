using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class CommentOneToOne1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "01e44d75-20fa-4caf-abd1-4022125b6c00");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eb9e7a71-9c2c-4086-a37c-1607c82ade6d");

            migrationBuilder.AddColumn<string>(
                name: "AppUserId",
                table: "Comment",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1f9f1ba4-e1e8-4459-b090-0e68a0aa2e11", null, "Admin", "ADMIN" },
                    { "f7480d8c-62d7-42a5-b5a4-a1d15e73c370", null, "User", "USER" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comment_AppUserId",
                table: "Comment",
                column: "AppUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_AspNetUsers_AppUserId",
                table: "Comment",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comment_AspNetUsers_AppUserId",
                table: "Comment");

            migrationBuilder.DropIndex(
                name: "IX_Comment_AppUserId",
                table: "Comment");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1f9f1ba4-e1e8-4459-b090-0e68a0aa2e11");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f7480d8c-62d7-42a5-b5a4-a1d15e73c370");

            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "Comment");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "01e44d75-20fa-4caf-abd1-4022125b6c00", null, "User", "USER" },
                    { "eb9e7a71-9c2c-4086-a37c-1607c82ade6d", null, "Admin", "ADMIN" }
                });
        }
    }
}
