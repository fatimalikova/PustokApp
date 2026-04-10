using Azure;
using Microsoft.EntityFrameworkCore;
using PustokApp.Models;

namespace PustokApp.Data
{
    public class PustokAppDbContext : DbContext
    {
        public PustokAppDbContext(DbContextOptions<PustokAppDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(PustokAppDbContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<BookTag> BookTags { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Slider> Sliders { get; set; }
    }
}
