using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2乘法表
{
    class Program
    {
        static void Main(string[] args)
        {
            //2.编程输出九九乘法表。
            for (int i = 1; i < 10; i++)
            {
                //for (int j = 1; j <= i; j++)//倒三角
                //{
                //    ChengFa(i,j);
                //}
                for (int k = 1; k < 10; k++)//矩形
                {
                    RectChengFa(i, k);
                }
            }

            Console.ReadKey();
        }



        /// <summary>
        /// 倒三角 输出I*J = result字符串
        /// </summary>
        /// <param name="i"></param>
        /// <param name="j"></param>
        public static void ChengFa(int i, int j)
        {
            if (i == j)
            {
                Console.WriteLine("{0}x{1}={2}", i, j, i * j);
            }
            else
            {
                Console.Write("{0}x{1}={2}\t", i, j, i * j);
            }

        }
        //矩形 输出
        /// <summary>
        /// 矩形输出乘法表
        /// </summary>
        /// <param name="i"></param>
        /// <param name="j"></param>
        public static void RectChengFa(int i, int j)
        {
            if (9 == j)
            {
                Console.WriteLine("{0}x{1}={2}", i, j, i * j);
            }
            else
            {
                Console.Write("{0}x{1}={2}\t", i, j, i * j);
            }
        }
    }
}
