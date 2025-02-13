using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddRolesToDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "240da404-c0d1-453c-b0ce-5434fe2f4c47", null, "Admin", "ADMIN" },
                    { "a5b8467b-4af4-4e77-adb5-cb7f1e60c945", null, "Editor", "EDITOR" },
                    { "ea7d512a-75a0-4dbd-87fe-f4e5b5ce0b2c", null, "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "240da404-c0d1-453c-b0ce-5434fe2f4c47");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a5b8467b-4af4-4e77-adb5-cb7f1e60c945");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ea7d512a-75a0-4dbd-87fe-f4e5b5ce0b2c");
        }
    }
}
