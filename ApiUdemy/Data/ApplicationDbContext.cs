using ApiUdemy.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiUdemy.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> option) : base(option)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book_Author>()
                .HasOne(b => b.LibBook)
                .WithMany(ba => ba.Book_Authors)
                .HasForeignKey(bi => bi.BookId);

            modelBuilder.Entity<Book_Author>()
                .HasOne(a => a.Author)
                .WithMany(ba => ba.Book_Authors)
                .HasForeignKey(ai => ai.AuthorId);
                
        }

        public DbSet<LibBook> LibBook { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book_Author> Book_Authors { get; set; }

    }
}
