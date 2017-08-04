using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_NestName
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass mc = new MyClass();

            MyClass.MyNestedClass nc = new MyClass.MyNestedClass();
            Console.WriteLine(nc.Info);
        }
    }

    /// <summary>
    /// 嵌套类
    /// </summary>
    class MyClass
    {
        public class MyNestedClass
        {
            public string Info { get; set; }

            public MyNestedClass()
            {
                Info = "我的嵌套类";
            }
        }
    }
}
