using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _009_ref
{
    /// <summary>
    /// 能够将一个变量带入一个方法中进行改变 ，改变完成后在将变量返回到方法中。
    /// 要求：在方法外必须被赋值，在方法内可以不用赋值。
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            #region ref
            //交换两个整数
            Console.WriteLine("输入第一个数字");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("输入第二个数字");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Exchange(ref num1, ref num2);
            Console.WriteLine("第一个数字：{0}", num1);
            Console.WriteLine("第二个数字：{0}", num2);
            #endregion

            Console.ReadKey();
        }

        public static void Exchange(ref int n1, ref int n2)
        {
            int temp = 0;
            temp = n1;
            n1 = n2;
            n2 = temp;
        }
    }
}
