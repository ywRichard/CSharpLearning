using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _12正则表达式
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 冗余代码
            ////bool result = Regex.IsMatch("987", "[9][8][7]");
            //bool result = Regex.IsMatch("987", "\\d");

            //if (result)
            //{
            //    Console.WriteLine("Match Successfully");
            //}
            //else
            //{
            //    Console.WriteLine("Failed");
            //}

            //Console.ReadLine();          
            #endregion

            #region 匹配邮箱地址
            ////匹配邮箱 ywfire0620@163.com
            ////正则表达式：[0-9a-zA-Z_.-]+@[0-9a-zA-Z_.]+[.]+[a-zA-Z]{1,2}
            //while (true)
            //{
            //    Console.WriteLine("请输入邮箱地址：");

            //    string adress = Console.ReadLine();

            //    if (Regex.IsMatch(adress, "[0-9a-zA-Z_.-]+@[0-9a-zA-Z_.]+[.]+[a-zA-Z]{1,2}"))
            //    {
            //        Console.WriteLine("是邮箱");
            //    }
            //    else
            //    {
            //        Console.WriteLine("不是邮箱");
            //    }
            //}
            #endregion

            #region 匹配身份证
            while (true)
            {
                Console.WriteLine("请输入身份证号码：");
                string ID_Num = Console.ReadLine();

                if (Regex.IsMatch(ID_Num, "[1-9][0-9]{14}([0-9]{2}[0-9Xx])?"))
                {
                    Console.WriteLine("匹配");
                }
                else
                {
                    Console.WriteLine("不匹配");
                }
            }            
            #endregion
            //匹配身份证 15或18位数字，结尾为X或x
            //[1-9][0-9]{14}([0-9]{2}[0-9Xx])?



        }
    }
}
