using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _异常捕获
{
    class Program
    {
        static void Main(string[] args)
        {
#region 练习
            ////读取输入的数字，输出读取的2倍
            //int number = 0;
            //bool flag = true;//判断是否异常

            ////捕获异常语句
            //try
            //{
            //    number = Convert.ToInt32(Console.ReadLine());
            //}
            //catch 
            //{
            //    Console.WriteLine("转换字符有误");
            //    flag = false;
            //}
            ////如果没有异常就正常输出倍数，有异常不输出
            //if (true == flag)
            //{
            //    Console.WriteLine(number*2);
            //}
            //Console.ReadKey();
#endregion
            //读取输入的数字，输出读取数字的3倍
            #region try-catch练习
            int number = 0;
            bool flag = true;

            try
            {
                number = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("输入内容不正确");
                flag = false;
            }

            if (true == flag)
            {
                Console.WriteLine(number * 2);
            }
            Console.ReadKey(); 
            #endregion
        }
    }
}
