using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PustokApp.Models;

namespace PustokApp.Data.Configurations
{
    public class AuthorConfiguration : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            
            builder.HasMany(x => x.Books)
                .WithOne(x => x.Author)
                .HasForeignKey(x => x.AuthorId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Property(x => x.FullName)
                .IsRequired()
                .HasMaxLength(100);

            // Seed authors with product images
            builder.HasData(
                new { Id = Guid.Parse("11111111-1111-1111-1111-111111111111"), FullName = "George Orwell", ImageUrl = "assets/image/products/product-1.jpg" },
                new { Id = Guid.Parse("22222222-2222-2222-2222-222222222222"), FullName = "Jane Austen", ImageUrl = "assets/image/products/product-2.jpg" },
                new { Id = Guid.Parse("33333333-3333-3333-3333-333333333333"), FullName = "Mark Twain", ImageUrl = "assets/image/products/product-3.jpg" }
            );
        }


    };


}
