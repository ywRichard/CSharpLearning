using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_DbTableRelation
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        public string Title { get; set; }

        public virtual ICollection<BookReview> BookReview { get; set; }
    }
}
