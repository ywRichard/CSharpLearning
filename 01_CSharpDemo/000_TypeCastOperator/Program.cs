using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _000_TypeCastOperator
{
    /// <summary>
    /// 运算符 显示&隐示 转换
    /// 输出数据的类型由运算成员的类型决定，两边的数据类型必须一致。
    /// 如果不一致，
    //###############################################################
    //  1、自动类型转换，或者称之为隐式类型转换。
    //      1、两种类型兼容，例如：int和double都是数字类型
    //      2、目标类型大于源类型，例如：double>int
    //      小转大     int----->double

    //  2、强制类型转换，显示类型转换  int n = (int) double;
    //      1、两种类型相兼容
    //      2、大的转成小的
    //      大转小     double--->int
    //###############################################################
    /// 注意：转换数据的类型必须兼容（面上过的去）
    /// 所有类型都可以和string类型转换
    /// Convert.ToInt32(), int.parse(), int.TryParse()
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //int n1 = 10;
            //int n2 = 3;
            //double result = (double)n1 / n2;
            //Console.WriteLine("结果是{0:0.000}", result);
            //Console.ReadKey();
            //int T_shirt = 35;
            //int trousers = 120;
            //double pays = 3 * T_shirt + 2 * trousers;
            //Console.WriteLine("总计{0}元\n折后价{1}",pays,pays*0.88);
            //Console.ReadKey();
            //int days = 46;
            //int week = days / 7;
            //int day = days % 7;
            //Console.WriteLine("{0}周，{1}天", week, day);
            //Console.ReadKey();

            //int seconds = 107653;
            ////int day = seconds / (24 * 60 * 60);
            ////int hour = (seconds % (24 * 60 * 60))/(60*60);
            ////int minute = (seconds % (60 * 60))/60;
            ////int second = seconds % 60;

            //int day = seconds / 86400;//计算剩余天数
            //int secs = seconds % 86400;//计算完天数后，剩余的秒数
            //int hour = seconds / 3600;//计算剩余小时数
            //secs = secs % 3600;//计算完小时数后，剩余的秒数
            //int minute = secs / 60;//计算分钟数，
            //int second = secs % 60;//计算完分钟数之后，剩余的秒数

            //Console.WriteLine("{0}天，{1}小时，{2}分钟，{3}秒钟", day, hour, minute, second);

            #region TryParse

            //string str = "1.11";
            string str = "aaa";
            double result;
            Console.WriteLine($"Result:{double.TryParse(str, out result)},Value:{result}");
            #endregion

            Console.ReadKey();
        }
    }
}
