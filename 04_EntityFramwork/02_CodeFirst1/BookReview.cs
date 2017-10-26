using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_CodeFirst1
{
    public class BookReview
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public virtual string Content { get; set; }
        public virtual Book Book { get; set; }
    }
}
