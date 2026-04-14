using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PustokApp.Models;

namespace PustokApp.Data.Configurations
{
    public class BookTagConfiguration : IEntityTypeConfiguration<BookTag>
    {
        public void Configure(EntityTypeBuilder<BookTag> builder)
        {
            builder.HasKey(x => new { x.BookId, x.TagId });

            builder.HasOne(x => x.Book)
                .WithMany(b => b.BookTags)
                .HasForeignKey(x => x.BookId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(x => x.Tag)
                .WithMany(t => t.BookTags)
                .HasForeignKey(x => x.TagId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasData(
                new BookTag { BookId = Guid.Parse("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), TagId = Guid.Parse("44444444-4444-4444-4444-444444444444"), Id = Guid.Parse("bbbbbbbb-0000-0000-0000-bbbbbbbb0001") },
                new BookTag { BookId = Guid.Parse("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), TagId = Guid.Parse("55555555-5555-5555-5555-555555555555"), Id = Guid.Parse("bbbbbbbb-0000-0000-0000-bbbbbbbb0002") },
                new BookTag { BookId = Guid.Parse("cccccccc-cccc-cccc-cccc-cccccccccccc"), TagId = Guid.Parse("66666666-6666-6666-6666-666666666666"), Id = Guid.Parse("bbbbbbbb-0000-0000-0000-bbbbbbbb0003") }
            );
        }
    }
}
