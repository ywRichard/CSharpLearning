using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_CodeFirst
{
    public class BookInfo1
    {

        [Key]
        public int BId { get; set; }
        [StringLength(50)]
        public string BookTitle { get; set; }
        [ForeignKey("BookType1")]
        public int TypeId { get; set; }

        public virtual BookType1 BookType1 { get; set; }
    }
}
