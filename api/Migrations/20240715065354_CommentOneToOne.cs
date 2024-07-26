using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class CommentOneToOne : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b95c9f31-b27f-4f51-a6d8-83f036c4460a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c4cea07f-1f59-47c4-880d-3dbf6491514a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "01e44d75-20fa-4caf-abd1-4022125b6c00", null, "User", "USER" },
                    { "eb9e7a71-9c2c-4086-a37c-1607c82ade6d", null, "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "01e44d75-20fa-4caf-abd1-4022125b6c00");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eb9e7a71-9c2c-4086-a37c-1607c82ade6d");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "b95c9f31-b27f-4f51-a6d8-83f036c4460a", null, "User", "USER" },
                    { "c4cea07f-1f59-47c4-880d-3dbf6491514a", null, "Admin", "ADMIN" }
                });
        }
    }
}
