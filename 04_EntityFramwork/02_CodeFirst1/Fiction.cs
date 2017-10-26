using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_CodeFirst1
{
    public class Fiction : Book
    {
        //在生成表单时，会将父类和子类同时生成到一张表中
        public string Content { get; set; }
    }
}
