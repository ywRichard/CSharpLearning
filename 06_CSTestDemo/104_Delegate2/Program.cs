using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _23_委托案例
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu = new Student();
            stu.DoSth(Show);
            Console.ReadLine();
        }

        public static void Show()
        {
            Console.WriteLine("哈哈，终于明白委托是干嘛的了");
        }
    }
}
