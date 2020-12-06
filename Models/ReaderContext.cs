using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace CityLibraryApi.Models
{
    public class ReaderContext : DbContext
    {
        public DbSet<Reader> Readers { get; set; }
        public DbSet<Book> Books { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        modelBuilder.Entity<Book>()
            .HasOne(p => p.Reader)
            .WithMany(b => b.Books)
            .HasForeignKey(p => p.ReaderId);
        }
        public ReaderContext(DbContextOptions<ReaderContext> options)
            :base(options)
        {
        }
    }
}
