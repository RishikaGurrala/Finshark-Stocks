using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1f9f1ba4-e1e8-4459-b090-0e68a0aa2e11");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f7480d8c-62d7-42a5-b5a4-a1d15e73c370");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "837fde29-6ea2-4992-b391-a58ab59a3d7e", null, "Admin", "ADMIN" },
                    { "9dd14f23-2dac-41e3-b8b5-0596f289f96e", null, "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "837fde29-6ea2-4992-b391-a58ab59a3d7e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9dd14f23-2dac-41e3-b8b5-0596f289f96e");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1f9f1ba4-e1e8-4459-b090-0e68a0aa2e11", null, "Admin", "ADMIN" },
                    { "f7480d8c-62d7-42a5-b5a4-a1d15e73c370", null, "User", "USER" }
                });
        }
    }
}
