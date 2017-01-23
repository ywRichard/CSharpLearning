using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _ref参数练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //交换两个整数
            #region 第一次
            //Console.WriteLine("输入第一个数字");
            //int n1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("输入第二个数字");
            //int n2 = Convert.ToInt32(Console.ReadLine());
            //Trange(ref n1, ref n2);
            //Console.WriteLine("第一个数字{0}",n1);
            //Console.WriteLine("第二个数字{0}",n2);
            //Console.ReadKey(); 
            #endregion
            Console.WriteLine("输入第一个数字");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("输入第二个数字");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Exchange(ref num1, ref num2);
            Console.WriteLine("第一个数字：{0}", num1);
            Console.WriteLine("第二个数字：{0}", num2);
            Console.ReadKey();
        }
        #region 第一次
        //public static void Trange(ref int n1, ref int n2)
        //{
        //    int temp = n1;
        //    n1 = n2;
        //    n2 = temp;
        //} 
        #endregion

        public static void Exchange(ref int n1, ref int n2)
        {
            int temp = 0;
            temp = n1;
            n1 = n2;
            n2 = temp;
        }
    }
}
