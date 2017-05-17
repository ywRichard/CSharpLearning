using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _000_Enum
{
    /// <summary>
    /// 枚举类型，
    /// </summary>
    public enum gender
    {
        男,
        女
    }
    class Program
    {
        static void Main(string[] args)
        {
            #region 枚举复制
            //gender g = gender.男;
            //Console.WriteLine(g);
            //Console.ReadKey(); 
            #endregion

            #region string类型转换
            //所有类型都可以转换成string类型
            //int number = 10;
            //string n = number.ToString();
            //Console.WriteLine(n);
            //Console.ReadKey(); 
            #endregion
            //gender gen = gender.男;
            //string g = gen.ToString();
            //将枚举类型转换成字符串类型

            #region 字符串转换枚举
            //string s = "3";
            //gender gen = (gender)Enum.Parse(typeof(gender),s);
            //Console.WriteLine(gen);
            //Console.ReadKey(); 
            #endregion
                       
        }
    }
}
