using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _方法的练习
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 只允许输入yes或者no
            ////只允许输入y或者n
            ////方法体：判断输入参数的是不是y或者n，是返回true 不是false.
            ////
            //string str = "";
            //bool result = false;
            //Console.WriteLine("请输入参数");
            //while (true)
            //{
            //    str = Console.ReadLine();
            //    result = IsYesOrNo(str);
            //    if (true == result)
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("请重新输入");
            //    }

            //}
            #endregion
            //计算输入数组的和，并且输出
            int[] number = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int sum = ArraySum(number);
            Console.WriteLine("数组的总和是");
            Console.WriteLine(sum);
            Console.ReadKey();

        }
        #region 只允许输入yes or no
        /// <summary>判断用户输入
        /// 限定用户只能输入yes or no，并且返回
        /// </summary>
        /// <param name="input">用户输入的字符</param>
        /// <returns>true:输入的是yes or no</returns>
        public static bool IsYesOrNo(string input)
        {
            bool flag = false;
            if (("yes" == input) || ("no" == input))
            {
                flag = true;
            }
            return flag;
        } 
            #endregion
        //方法体：计算输入数组的和,并返回
        public static int ArraySum(int[] nums)
        {
            int sum = 0;
            for (int i = 0; i < nums.Length-1; i++)
            {
                sum += nums[i];
            }
            return sum;
        }
    }
}
