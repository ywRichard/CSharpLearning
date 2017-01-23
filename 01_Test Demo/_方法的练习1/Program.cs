using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _方法的练习1
{
    class Program
    {
        static void Main(string[] args)
        {
            //提示用户输入两个数字  计算这两个数字之间所有整数的和
            //1、用户只能输入数字
            //2、计算两个数字之间和
            //3、要求第一个数字必须比第二个数字小  就重新输入
            int num1 = 0;
            int num2 = 0;
            int sum = 0;
            while (true)
            {
                Console.WriteLine("请输入第一个数字");
                try
                {
                    num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("请输入第二个数字");
                    try
                    {
                        num2 = Convert.ToInt32(Console.ReadLine());
                        if (num1 < num2)
                        {
                            sum = NumberSum(num1, num2);
                            Console.WriteLine("Total:{0}", sum);
                            Console.ReadKey();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("第一个数字大于第二个数字，请重新输入");
                        }
                    }

                    catch 
                    {
                        Console.WriteLine("输入的第二个值不是数字");
                    }

                }
                catch
                {
                    Console.WriteLine("输入的第一个值不是数字");
                }

            }
        }
        //参数：输入的两个数字，返回值：两个数字之间所有整数的和。
        /// <summary>
        /// 计算两个数字之间所有整数的和
        /// </summary>
        /// <param name="n1">第一个参数</param>
        /// <param name="n2">第二个参数</param>
        /// <returns>整数和</returns>
        public static int NumberSum(int n1,int n2)
        {
            int sum = 0;
            for (int i = 0; i <= n2-n1; i++)
            {
                sum += n1 + i;
            }
            return sum;
        }

        /// <summary>
        /// 如果输入的是浮点数
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public static int NumberSum(double n1, double n2)
        {
            int sum = 0;
            int num1 = (int) n1;
            int num2 = (int) n2;
            for (int i = 0; i <= num2-num1; i++)
            {
                sum += num1 + i;
            }
            return sum;
        }

    }
}
