using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _002_MedPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            //用来判断用户输入的数字是不是质数
            while (true)
            {
                Console.WriteLine("输入数字");
                int number = Convert.ToInt32(Console.ReadLine());
                bool flag = IsOrNoPrime(number);
                if (true == flag)
                {
                    Console.WriteLine("是质数");
                }
                else
                {
                    Console.WriteLine("不是质数");
                }
            }
        }
        //参数：int 
        //方法体：是否为质数，只能被1和自身整除
        //返回类型：bool
        /// <summary>
        /// 判断是否为质数
        /// </summary>
        /// <param name="number">输入的数字</param>
        /// <returns>true 质数 false不是质数</returns>
        public static bool IsOrNoPrime(int number)//true 质数，false 不是质数
        {
            //int judge = -1;
            bool flag = true;
            for (int i = 2; i <= number-1; i++)
            {
                if(0 == number%i)//不能被整除
                {
                    flag = false;
                }
            }
            return flag;
        }
    }
}
