using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddRefreshTokenFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "RefreshToken",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "RefreshTokenExpiryTime",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "10444c43-0072-4795-9064-17ab25cd5780", null, "Admin", "ADMIN" },
                    { "69e6c6a8-c7ad-47aa-a2d5-6c588569c532", null, "User", "USER" },
                    { "f430d7ee-21f3-4dba-9473-c5c4ac5a991a", null, "Editor", "EDITOR" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "10444c43-0072-4795-9064-17ab25cd5780");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "69e6c6a8-c7ad-47aa-a2d5-6c588569c532");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f430d7ee-21f3-4dba-9473-c5c4ac5a991a");

            migrationBuilder.DropColumn(
                name: "RefreshToken",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "RefreshTokenExpiryTime",
                table: "AspNetUsers");

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
    }
}
