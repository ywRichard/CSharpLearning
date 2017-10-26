using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_CodeFirst
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

        public virtual ICollection<BookInfo1> BookInfo1 { get; set; }
    }
}
