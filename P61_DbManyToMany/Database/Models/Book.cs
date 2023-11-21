using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P61_DbManyToMany.Database.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        // category prijungimas
        public List<BookCategory> BookCategories { get; set; }
        public Author Author { get; set; }
    }
}
