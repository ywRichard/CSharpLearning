using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _000_Expression
{
    /// <summary>
    /// 一元运算符优先级高于二元运算符。
    /// 一元运算符：一个操作数；
    /// 二元运算符：两个操作数。
    /// 唯一的三元表达式
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //比较两个数，输出较大值
            Console.WriteLine("请输入第一个数字");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入第二个数字");
            int n2 = Convert.ToInt32(Console.ReadLine());

            //int max = n1 > n2 ? n1 : n2;//三元运算符
            string max = n1 > n2 ? "shaX" : "niuB";

            Console.WriteLine(max);
            Console.ReadKey();
        }
    }
}
