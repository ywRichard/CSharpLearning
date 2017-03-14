using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _009_RefAndOut
{
    /// <summary>
    /// ref和out：
    /// 1、传递的是变量在栈上的值。
    /// 2、实现方法的多个返回值。
    /// 3、ref可进可出, out只出不进
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //int num = 1000;
            int num =100;
            Add(ref num);
            //Sub(out num);
            Console.WriteLine(num);
            Console.ReadLine();
        }

        //private static void Sub(out int num)
        //{
        //    num = 30;
        //}

        private static void Add(ref int n)
        {
            n = 20;
        }
    }
}
