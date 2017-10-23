using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace _07_EFCodeFirst.Models
{
    public class BookInfo1
    {
        [Key]
        public int BookId { get; set; }
        [StringLength(50)]
        public string BookTitle { get; set; } 
        [ForeignKey("BookType1")]
        public int TId { get; set; }

        public BookType1 BookType1 { get; set; }
    }
}