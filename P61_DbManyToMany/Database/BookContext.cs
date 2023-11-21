using Microsoft.EntityFrameworkCore;
using P61_DbManyToMany.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P61_DbManyToMany.Database
{
    public class BookContext : DbContext
    {
        public BookContext() : base()
        {
        }
        public BookContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<BookCategory> BookCategories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder); galima istrinti

            // universali sintaxe norint uztikrinti sujungima tarp lenteliu
            // cia mes konfiguruojame sarysi su many to many
            modelBuilder.Entity<BookCategory>()
                .HasKey(bc => new { bc.BookId, bc.CategoryId });        // du pirminiai raktai nurodomi skirti sujungti sarysi daug su daug

            modelBuilder.Entity<BookCategory>()
                .HasOne(bc => bc.Book)
                .WithMany(b => b.BookCategories)
                .HasForeignKey(bc => bc.BookId);        // Sarysis su Book lentele

            modelBuilder.Entity<BookCategory>()
                .HasOne(bc => bc.Category)
                .WithMany(c => c.BookCategories)
                .HasForeignKey(bc => bc.CategoryId);        // sarysis su Catergory lentele
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=NETUA2_books;Trusted_Connection=True;");
        //    }
        //}
    }
}
