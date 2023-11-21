using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P61_DbManyToMany.Database.Models
{
    public class BookCategory   // many to many jungiamoji lentele
    {   // sie du properciai yra sujungimas tarp lenteliu, pagr key is dvieju lenteliu ko uztenka kad uztikrinti sarysi many to many
        public int BookId { get; set; }
        public int CategoryId { get; set; }

        public Book Book { get; set; }
        public Category Category { get; set; }
    }
}
