using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace _004_StringMethds
{
    /// <summary>
    /// string类型的常用方法
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            ////string s = "abcdefg";
            ////char[] chs = s.ToCharArray();
            ////chs[0] = 'y';
            ////s = new string(chs);
            //string s = "abcdefg";
            //char[] chs = s.ToCharArray();
            //chs[0] = 'y';
            ////s = new string(chs);//将字符数组转换为字符串数组
            //s=new string(chs);

            //Console.ReadKey();

            //StringBuilder sb = new StringBuilder();
            //string str = null;

            //Stopwatch sw = new Stopwatch();
            //sw.Start();
            //for (int i = 0; i < 100; i++)
            //{
            //    //str += i;
            //    sb.Append(i);
            //}
            //sw.Stop();
            //Console.WriteLine(sw.Elapsed);
            //Console.WriteLine(sb.ToString());
            //Console.ReadKey();

            //Console.WriteLine("你心中所想的人");
            //string str = Console.ReadLine();
            //Console.WriteLine("长度是{0}", str.Length);
            //Console.ReadKey();

            //Console.WriteLine("输入你喜欢的课程");
            //string lessonOne = Console.ReadLine();
            ////lessonOne = lessonOne.ToUpper();

            //Console.WriteLine("输入你喜欢的课程");
            //string lessonTwo = Console.ReadLine();
            ////lessonTwo = lessonTwo.ToUpper();

            ////if (lessonOne == lessonTwo)
            //if(lessonOne.Equals(lessonTwo,StringComparison.OrdinalIgnoreCase))
            //{
            //    Console.WriteLine("你们喜欢的课程一样");
            //}
            //else
            //{
            //    Console.WriteLine("你们喜欢的课程不一样");
            //}
            //Console.ReadKey();

            //string str = "q   qw   df-- ff +++sdfsdf.....";
            //char[] chs = { ' ', '-', '+', '.' };

            //string[] str1 = str.Split(chs, StringSplitOptions.RemoveEmptyEntries);
            //Console.ReadKey();

            //string str = "2008-08-08";
            //char[] chs = { '-' };

            //string[] date = str.Split(chs, StringSplitOptions.RemoveEmptyEntries);

            //Console.WriteLine("{0}年{1}月{2}日", date[0], date[1], date[2]);
            //Console.ReadKey();

            string ID = "P1";
            Console.WriteLine(ID.Remove(0, 1));
            
            Console.ReadKey();
        }
    }
}
