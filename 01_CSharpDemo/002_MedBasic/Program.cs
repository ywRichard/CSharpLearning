using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _002_MethodBasic
{
    /// <summary>
    /// 方法标签
    /// 返回值，方法体，参数
    /// </summary>
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

            #region 计算输入数组的和，并且输出
            //int[] number = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //int sum = ArraySum(number);
            //Console.WriteLine("数组的总和是");
            //Console.WriteLine(sum);
            #endregion

            #region 比较字符串的长度
            ////有一个字符串数组：{ "马龙", "迈克尔乔丹", "雷吉米勒", "蒂姆邓肯", "科比布莱恩特" },请输出最长的字符串。
            //string[] str = { "马龙", "迈克尔乔丹", "雷吉米勒", "蒂姆邓肯", "科比布莱恩特" };
            ////int index = JudgeLength(str);
            //int index;
            //JudgeLength(out index, "马龙", "迈克尔乔丹", "雷吉米勒", "蒂姆邓肯", "科比布莱恩特");
            //Console.WriteLine("最长的字符串：{0}", str[index]);
            #endregion

            #region 用来判断用户输入的数字是不是质数
            //Console.WriteLine("输入数字");
            //int number = Convert.ToInt32(Console.ReadLine());
            //bool flag = IsOrNoPrime(number);

            //if (true == flag)
            //    Console.WriteLine("是质数");
            //else
            //    Console.WriteLine("不是质数");
            #endregion

            #region 计算这两个数字之间所有整数的和
            //提示用户输入两个数字  计算这两个数字之间所有整数的和
            //1、用户只能输入数字
            //2、计算两个数字之间和
            //3、要求第一个数字必须比第二个数字小  就重新输入
            //int num1 = 0;
            //int num2 = 0;
            //int sum = 0;
            //while (true)
            //{
            //    Console.WriteLine("请输入第一个数字");
            //    try
            //    {
            //        num1 = Convert.ToInt32(Console.ReadLine());
            //        Console.WriteLine("请输入第二个数字");
            //        try
            //        {
            //            num2 = Convert.ToInt32(Console.ReadLine());
            //            if (num1 < num2)
            //            {
            //                sum = NumberSum(num1, num2);
            //                Console.WriteLine("Total:{0}", sum);
            //                Console.ReadKey();
            //                break;
            //            }
            //            else
            //                Console.WriteLine("第一个数字大于第二个数字，请重新输入");
            //        }
            //        catch
            //        {
            //            Console.WriteLine("输入的第二个值不是数字");
            //        }
            //    }
            //    catch
            //    {
            //        Console.WriteLine("输入的第一个值不是数字");
            //    }
            //}
            #endregion


            Console.ReadKey();
        }

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

        /// <summary>
        /// 计算输入数组的和
        /// </summary>
        public static int ArraySum(int[] nums)
        {
            int sum = 0;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                sum += nums[i];
            }
            return sum;
        }

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

        /// <summary>
        /// 判断是否为质数 -> 只能被1和自身整除
        /// </summary>
        public static bool IsOrNoPrime(int number)
        {
            //int judge = -1;
            bool flag = true;
            for (int i = 2; i <= number - 1; i++)
            {
                if (0 == number % i)//不能被整除
                {
                    flag = false;
                }
            }
            return flag;
        }

        /// <summary>
        /// 计算两个数字之间所有整数的和
        /// </summary>
        public static int NumberSum(int n1, int n2)
        {
            int sum = 0;
            for (int i = 0; i <= n2 - n1; i++)
            {
                sum += n1 + i;
            }
            return sum;
        }

        /// <summary>
        /// 如果输入的是浮点数
        /// </summary>
        public static int NumberSum(double n1, double n2)
        {
            int sum = 0;
            int num1 = (int)n1;
            int num2 = (int)n2;
            for (int i = 0; i <= num2 - num1; i++)
            {
                sum += num1 + i;
            }
            return sum;
        }
    }
}
