using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _07_EFCodeFirst.Models
{
    public class BookType1
    {
        public BookType1()
        {
            BookInfo1 = new HashSet<BookInfo1>();
        }

        [Key]
        public int TId { get; set; }
        public string TypeTitle { get; set; }

        public ICollection<BookInfo1> BookInfo1 { get; set; }
    }
}