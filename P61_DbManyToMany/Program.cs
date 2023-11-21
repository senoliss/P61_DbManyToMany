using Microsoft.EntityFrameworkCore;
using P61_DbManyToMany.Database;
using P61_DbManyToMany.Database.Models;

/*
 User Story:
1. **Data Entry for a New Book: **
-
The system should allow me to enter the title and publication year of the book.
I should be able to link the book to an author by selecting from a
list of authors in the 'Author' table. If the author is not present,
I should have the option to add a new author, requiring only the last name.

2. **Categorizing the Book:**
-
I can assign one or more categories to the book from a predefined list in the 'Category' table.
If a suitable category is not available, I have the option to create a new category.

3. **Saving the Information:**
-
- Upon entering all the details, I can save the book information.
The book should now be linked with the selected author in the 'Author' table,
and its categories in the 'Category' table should be updated accordingly in the 'BookCategory' table.

4. **Validation and Feedback:**
-
-
The system should validate the data to ensure that all required fields are filled and the data is formatted correctly.
After successful insertion, the system should display a confirmation message.

5. **Error Handling:**
- In case of an error (e.g., a duplicate title or a missing mandatory field),
the system should display a clear error message guiding me to correct the issue.

 */
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