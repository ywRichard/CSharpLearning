using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _15运算符的学习
{
    /// <summary>
    /// 运算符：输出数据的类型由运算成员的类型决定。
    /// 难点自加自减
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个数字");
            string strNumber = Console.ReadLine();
            double number = Convert.ToDouble(strNumber);
            number = number * 2;
            Console.WriteLine(number);
            Console.ReadKey();

            int a = 5;
            int b = a++ + ++a * 2 + --a + a++;
            //      5+7*2+6+6=31
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.ReadKey();
        }
    }
}
