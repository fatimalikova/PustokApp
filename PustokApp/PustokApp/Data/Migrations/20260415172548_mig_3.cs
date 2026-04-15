using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PustokApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class mig_3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Insert seed data for Authors
            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "FullName", "ImageUrl" },
                values: new object[,]
                {
                    { new Guid("11111111-1111-1111-1111-111111111111"), "George Orwell", "assets/image/products/product-1.jpg" },
                    { new Guid("22222222-2222-2222-2222-222222222222"), "Jane Austen", "assets/image/products/product-2.jpg" },
                    { new Guid("33333333-3333-3333-3333-333333333333"), "Mark Twain", "assets/image/products/product-3.jpg" }
                });

            // Insert seed data for Tags
            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("44444444-4444-4444-4444-444444444444"), "Classic" },
                    { new Guid("55555555-5555-5555-5555-555555555555"), "Romance" },
                    { new Guid("66666666-6666-6666-6666-666666666666"), "Adventure" }
                });

            // Insert seed data for Books
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Name", "Description", "DiscountPercentage", "Price", "AuthorId", "MainImageUrl", "HoverImageUrl", "IsNew", "IsFeatured", "InStock", "Code" },
                values: new object[,]
                {
                    { new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), "1984", "Dystopian social science fiction novel and cautionary tale.", 10, 19.99m, new Guid("11111111-1111-1111-1111-111111111111"), "assets/image/products/product-1.jpg", "assets/image/products/product-2.jpg", false, true, true, 1001 },
                    { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), "Pride and Prejudice", "A romantic novel of manners written by Jane Austen.", 0, 14.99m, new Guid("22222222-2222-2222-2222-222222222222"), "assets/image/products/product-3.jpg", "assets/image/products/product-4.jpg", false, false, true, 1002 },
                    { new Guid("cccccccc-cccc-cccc-cccc-cccccccccccc"), "Adventures of Huckleberry Finn", "A novel by Mark Twain, first published in 1884.", 5, 12.50m, new Guid("33333333-3333-3333-3333-333333333333"), "assets/image/products/product-5.jpg", "assets/image/products/product-6.jpg", false, false, true, 1003 }
                });

            // Insert seed data for BookImages
            migrationBuilder.InsertData(
                table: "BookImage",
                columns: new[] { "Id", "BookId", "Image" },
                values: new object[,]
                {
                    { new Guid("aaaaaaaa-0000-0000-0000-aaaaaaaa0001"), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), "assets/image/products/product-1.jpg" },
                    { new Guid("aaaaaaaa-0000-0000-0000-aaaaaaaa0002"), new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), "assets/image/products/product-3.jpg" },
                    { new Guid("aaaaaaaa-0000-0000-0000-aaaaaaaa0003"), new Guid("cccccccc-cccc-cccc-cccc-cccccccccccc"), "assets/image/products/product-5.jpg" }
                });

            // Insert seed data for BookTags
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
            // Delete seed data in reverse order of insertion
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

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"));
        }
    }
}
