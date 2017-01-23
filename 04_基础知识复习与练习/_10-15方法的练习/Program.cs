using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10_15方法的练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("1-100之间的所有整数的和:{0}", Sum());
            //Console.WriteLine("1-100之间的所有奇数的和:{0}", OddSum());

            #region 判断质数
            //Console.WriteLine("请输入一个数字");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("{0}质数",PrimeNumber(a)); 
            #endregion

            #region 计算1-100之间的所有质数（素数）的和。
            //List<int> list;
            //Console.WriteLine("1-100之间的所有素数的和:{0}", PrimeSum(out list));
            //for (int i = 0; i < list.Count; i++)
            //{
            //    Console.Write(list[i].ToString() + "\t");
            //} 
            #endregion

            //Console.WriteLine(MaxString());//输出最大的字符串
            Console.WriteLine("平均值为{0:n2}",Average());//计算结果如果有小数，则显示小数点后两位（四舍五入）。

            Console.ReadKey();
        }

        /// <summary>
        /// 10计算1-100之间的所有整数的和。
        /// </summary>
        /// <returns>和</returns>
        public static int Sum()
        {
            int sum = 0;
            for (int i = 1; i <= 100; i++)
            {
                sum += i;
            }
            return sum;
        }
        /// <summary>
        /// 计算1-100之间的所有奇数的和。
        /// </summary>
        /// <returns></returns>
        public static int OddSum()
        {
            int sum = 0;
            for (int i = 1; i <= 50; i++)
            {
                sum += 2 * i - 1;
            }
            return sum;
        }        
        /// <summary>
        /// 判断一个给定的整数是否为“质数”。
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static string PrimeNumber(int a)
        {
            string str = "是";
            for (int i = 2; i < a; i++)
            {
                if (0 == a % i)
                {
                    str = "不是";
                }
            }
            return str;
        }        
        /// <summary>
        /// 计算1-100之间的所有质数（素数）的和。
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public static int PrimeSum(out List<int> list)
        {
            int sum = 0;
            list = new List<int>();
            for (int i = 1; i <= 100; i++)
            {
                for (int j = 2; j < i; j++)
                {
                    if (0 == i % j)
                    {
                        break;
                    }
                    if (j == i - 1)
                    {
                        list.Add(i);
                        sum += i;
                    }
                }
            }
            return sum;
        }        
        /// <summary>
        /// 输出最长的字符串
        /// </summary>
        /// <returns></returns>
        public static string MaxString()
        {
            string[] strArray = { "马龙", "迈克尔乔丹", "雷吉米勒", "蒂姆邓肯", "科比布莱恩特" };
            string str = strArray[0];

            for (int i = 0; i < strArray.Length; i++)
            {
                if (strArray[i].Length>str.Length)
                {
                    str = strArray[i];
                }
            }
            return str;
        }
        /// <summary>
        /// 整型数组的平均值
        /// </summary>
        /// <returns></returns>
        public static double Average()
        {
            int[] numArray = { 1, 3, 5, 7, 93, 33, 4, 4, 6, 8, 10 };
            double aver = (double)numArray.Sum()/numArray.Length;

            return aver;
        }
    }
}
