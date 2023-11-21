using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P61_DbManyToMany.Database.Models
{
    public class Category
    {
        [Key] // nurodome Primary Key
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        //todo: padaryti kompozicija i Book

        public List<BookCategory> BookCategories { get; set; }
    }
}
