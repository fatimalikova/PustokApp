using Microsoft.EntityFrameworkCore;
using PustokApp.Models;

namespace PustokApp.Data.Configurations
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Book> builder)
        {
            builder.HasMany(b => b.BookImages)
                .WithOne(b => b.Book)
                .HasForeignKey(b => b.BookId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Property(x => x.Name).IsRequired().HasMaxLength(255);
        }
    }
}
