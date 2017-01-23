using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _练习1
{
    class Program
    {
        static void Main(string[] args)
        {
            //用户输入成绩
            //输出成绩的分类
            //分类：等级={优 （90~100分）；良 （80~89分）；中 （60~69分）；差 （0~59分）；
            
            //得到用户的输入
            Console.WriteLine("请输入成绩：");
            string str = Console.ReadLine();
            int grade = Convert.ToInt32(str);
            //string result = Panduan(grade);
            Console.WriteLine(Panduan(grade));
            Console.ReadKey();

        }

        public static string Panduan(int grade)
        {
            string result = "";
            switch (grade / 10)
            {
                case 9: result = "优";
                    break;
                case 8:
                case 7: result = "良";
                    break;
                case 6: result = "中";
                    break;
                default: result = "差";
                    break;
            }
            return result;
        }

    }
}
