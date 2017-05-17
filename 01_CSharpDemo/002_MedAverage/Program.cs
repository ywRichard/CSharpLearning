using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _002_MedAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            //请计算出一个整型数组的平均值。
            int[] array = { 1, 2, 3, 5, 5, 6, 7, 8, 9 };
            //double aver = ArrayAverage(array);
            double aver;
           ArrayAverage(out aver,1, 2, 3, 5, 5, 6, 7, 8, 9);
            Console.WriteLine("平均值为：{0}", aver);
            Console.ReadKey();
        }

        //参数:int 数组
        //方法体:数组的平均值
        //返回值：double平均值
        /// <summary>
        /// 计算数组的平均值
        /// </summary>
        /// <param name="array">数组</param>
        /// <returns>平均值</returns>
        //public static double ArrayAverage(params int[] array)
        public static void ArrayAverage(out double average, params int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            average = (double)sum / array.Length;
            //return average;
        }
    }
}
