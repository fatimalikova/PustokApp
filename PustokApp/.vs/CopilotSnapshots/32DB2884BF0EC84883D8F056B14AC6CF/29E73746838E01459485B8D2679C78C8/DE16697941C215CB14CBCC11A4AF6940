using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PustokApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class seed_all : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Tags",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Code", "Description", "DiscountPercentage", "HoverImageUrl", "InStock", "IsFeatured", "IsNew", "MainImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), new Guid("11111111-1111-1111-1111-111111111111"), 1001, "Dystopian social science fiction novel and cautionary tale.", 10, "books/1984-hover.jpg", true, true, false, "books/1984.jpg", "1984", 19.99m },
                    { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), new Guid("22222222-2222-2222-2222-222222222222"), 1002, "A romantic novel of manners written by Jane Austen.", 0, "books/pride-and-prejudice-hover.jpg", true, false, false, "books/pride-and-prejudice.jpg", "Pride and Prejudice", 14.99m },
                    { new Guid("cccccccc-cccc-cccc-cccc-cccccccccccc"), new Guid("33333333-3333-3333-3333-333333333333"), 1003, "A novel by Mark Twain, first published in 1884.", 5, "books/huckleberry-finn-hover.jpg", true, false, false, "books/huckleberry-finn.jpg", "Adventures of Huckleberry Finn", 12.50m }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("44444444-4444-4444-4444-444444444444"), "Classic" },
                    { new Guid("55555555-5555-5555-5555-555555555555"), "Romance" },
                    { new Guid("66666666-6666-6666-6666-666666666666"), "Adventure" }
                });

            migrationBuilder.InsertData(
                table: "BookImage",
                columns: new[] { "Id", "BookId", "Image" },
                values: new object[,]
                {
                    { new Guid("aaaaaaaa-0000-0000-0000-aaaaaaaa0001"), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), "books/1984-1.jpg" },
                    { new Guid("aaaaaaaa-0000-0000-0000-aaaaaaaa0002"), new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), "books/pride-1.jpg" },
                    { new Guid("aaaaaaaa-0000-0000-0000-aaaaaaaa0003"), new Guid("cccccccc-cccc-cccc-cccc-cccccccccccc"), "books/huck-1.jpg" }
                });

            migrationBuilder.InsertData(
                table: "BookTags",
                columns: new[] { "BookId", "TagId", "Id" },
                values: new object[,]
                {
                    { new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), new Guid("44444444-4444-4444-4444-444444444444"), new Guid("bbbbbbbb-0000-0000-0000-bbbbbbbb0001") },
                    { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), new Guid("55555555-5555-5555-5555-555555555555"), new Guid("bbbbbbbb-0000-0000-0000-bbbbbbbb0002") },
                    { new Guid("cccccccc-cccc-cccc-cccc-cccccccccccc"), new Guid("66666666-6666-6666-6666-666666666666"), new Guid("bbbbbbbb-0000-0000-0000-bbbbbbbb0003") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BookImage",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-0000-0000-0000-aaaaaaaa0001"));

            migrationBuilder.DeleteData(
                table: "BookImage",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-0000-0000-0000-aaaaaaaa0002"));

            migrationBuilder.DeleteData(
                table: "BookImage",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-0000-0000-0000-aaaaaaaa0003"));

            migrationBuilder.DeleteData(
                table: "BookTags",
                keyColumns: new[] { "BookId", "TagId" },
                keyValues: new object[] { new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), new Guid("44444444-4444-4444-4444-444444444444") });

            migrationBuilder.DeleteData(
                table: "BookTags",
                keyColumns: new[] { "BookId", "TagId" },
                keyValues: new object[] { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), new Guid("55555555-5555-5555-5555-555555555555") });

            migrationBuilder.DeleteData(
                table: "BookTags",
                keyColumns: new[] { "BookId", "TagId" },
                keyValues: new object[] { new Guid("cccccccc-cccc-cccc-cccc-cccccccccccc"), new Guid("66666666-6666-6666-6666-666666666666") });

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("cccccccc-cccc-cccc-cccc-cccccccccccc"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Tags",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
