using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _015_TryCatch
{
    /// <summary>
    /// 异常捕获
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //读取输入的数字，输出读取数字的3倍
            #region try-catch练习
            int number = 0;
            bool flag = true;

            try
            {
                number = Convert.ToInt32(Console.ReadLine());
            }
            catch(Exception e)
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
