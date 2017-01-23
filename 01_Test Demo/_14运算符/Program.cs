using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _14运算符
{
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

            int seconds = 107653;
            //int day = seconds / (24 * 60 * 60);
            //int hour = (seconds % (24 * 60 * 60))/(60*60);
            //int minute = (seconds % (60 * 60))/60;
            //int second = seconds % 60;

            int day = seconds / 86400;//计算剩余天数
            int secs = seconds % 86400;//计算完天数后，剩余的秒数
            int hour = seconds / 3600;//计算剩余小时数
            secs = secs % 3600;//计算完小时数后，剩余的秒数
            int minute = secs / 60;//计算分钟数，
            int second = secs % 60;//计算完分钟数之后，剩余的秒数

            Console.WriteLine("{0}天，{1}小时，{2}分钟，{3}秒钟", day, hour, minute, second);
            Console.ReadKey();
        }
    }
}
