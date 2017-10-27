using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_DbTableRelation
{
    public class BookReview
    {
        [Key]
        public int Id { get; set; }
        public int BookId { get; set; }
        public string Content { get; set; }

        public virtual Book Book { get; set; }
    }
}
