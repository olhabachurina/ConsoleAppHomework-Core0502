using ConsoleAppHomework_Core0502.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHomework_Core0502.Context
{
   public class BookStoreContext:DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=BookStoreDb;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>()
                .HasMany(a => a.Books)
                .WithOne(b => b.Author)
                .HasForeignKey(b => b.AuthorId);
        }
        public void UpdateBookPricesByAuthor(int authorId, decimal newPrice)
        {
            var authorIdParam = new SqlParameter("@AuthorId", authorId);
            var newPriceParam = new SqlParameter("@NewPrice", newPrice);

            this.Database.ExecuteSqlRaw("EXEC UpdateBookPricesByAuthor @AuthorId, @NewPrice", authorIdParam, newPriceParam);
        }
    }
}
