using Microsoft.EntityFrameworkCore;
using P61_DbManyToMany.Database;
using P61_DbManyToMany.Database.Models;

namespace P61_DbManyToMany
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Many to Many!");

            //var dbContext = new BookContext(new DbContextOptionsBuilder<BookContext>()
            //    .UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=NETUA2_books;Trusted_Connection=True;")
            //    .Options);
            //dbContext.Database.EnsureDeleted();
            //dbContext.Database.EnsureCreated();
            ////dbContext.SaveChanges();

            var rowling = new Author { LastName = "Rowling" };
            var hawkins = new Author { LastName = "Hawkins" };
            var carnagie = new Author { LastName = "Carnagie" };
            var adams = new Author { LastName = "Adams" };


        }
    }
}