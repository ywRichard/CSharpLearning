using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_EFCodeFirst
{
    public class Blog
    {
        public int BlogId { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }

        public string SubName { get; set; }//在类中添加新的字段

        /// <summary>
        /// POCO; POCO Proxry 要用ICollection修饰
        /// </summary>
        public virtual List<Post> Posts { get; set; }
    }
}
