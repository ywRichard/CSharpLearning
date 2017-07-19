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
            #region ++ & --
            //Console.WriteLine("请输入一个数字");
            //string strNumber = Console.ReadLine();
            //double number = Convert.ToDouble(strNumber);
            //number = number * 2;
            //Console.WriteLine(number);
            //Console.ReadKey();

            //int a = 5;
            //int b = a++ + ++a * 2 + --a + a++;
            ////      5+7*2+6+6=31
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            #endregion

            #region << & >>
            int i = 3;
            int lg = 5;

            Console.WriteLine("0x{0:x}", i << 2);//0x4
            Console.WriteLine("0x{0:d}", Convert.ToString((i << 2),2));

            Console.WriteLine("0x{0:x}", Convert.ToString((i << 31),2));
            Console.WriteLine("0x{0:x}", Convert.ToString((lg << 2), 2));
            #endregion
            //Console.ReadKey();
        }
    }
}
