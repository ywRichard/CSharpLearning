using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05大项目
{
    public class MyEventArgs:EventArgs
    {
        public int temp { get; set; }
        public object Obj { get; set; }
    }
}
