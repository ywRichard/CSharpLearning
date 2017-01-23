using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3数组的复习
{
    class Program
    {
        static void Main(string[] args)
        {
            //3.	定义长度50的数组,随机给数组赋值,并可以让用户输入一个数字n,按一行n个数输出数组  
            //int[]  array = new int[50];     Random r = new Random();  r.Next();
            ShowArray(50);

            Console.WriteLine("输入自定义数组长度");
            int length = Convert.ToInt32(Console.ReadLine());

            ShowArray(length);
            Console.ReadKey();

        }

        /// <summary>
        /// 输出数组的元素
        /// </summary>
        /// <param name="length">数组长度</param>
        public static void ShowArray(int length)
        {
            int[] array = new int[length];
            Random r = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = r.Next(0,10);
                Console.Write(array[i].ToString());
            }
            Console.WriteLine();
        }
    }
}
