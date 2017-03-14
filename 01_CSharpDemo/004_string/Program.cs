using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _004_string
{
    /// <summary>
    /// 测试字符串的基本操作
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //道墟排列的方法
            //第一题“abc-cba”
            

            #region 方法一:for循环倒序排列
            //string str = "abc";
            //for (int i = str.Length-1; i >=0; i--)
            //{
            //    Console.Write(str[i]);   
            //}
            //Console.ReadLine();
            #endregion

            #region 方法二：对调首尾元素

            //string str="我自横刀向天笑，去留肝胆两昆仑";
            //str = ReversString(str);

            //Console.WriteLine(str);
            //Console.ReadLine();

            #endregion

            //I Love You- I evoL ouY---重点是句子顺序不变，单词倒序。

            string str = "I Love You";

            string[] strArray = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < strArray.Length; i++)
            {
                strArray[i] = ReversString(strArray[i]);
            }

            string newStr = string.Join(" ", strArray);

            Console.WriteLine(newStr);

            Console.ReadLine();
        }

            private static string ReversString(string str)
            {
                char[] strChar = str.ToCharArray();

                for (int i = 0; i < strChar.Length/2; i++)
                {
                    char temp = strChar[i];
                    strChar[i] = strChar[strChar.Length - 1 - i];
                    strChar[strChar.Length - 1 - i] = temp;
                }

                return new string(strChar);
            }
    }
}
