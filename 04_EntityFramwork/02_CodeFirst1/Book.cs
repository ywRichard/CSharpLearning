using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_CodeFirst1
{
    public class Book
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string Authors { get; set; }

        //导航属性是virtual时，EF默认使用“延迟加载 (Lazy Loading)”
        public virtual List<BookReview> Reviews { get; set; }
    }
}
