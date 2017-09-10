using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4字符串的操作
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("请输入一个首字母小写字符串");
            //string str = Console.ReadLine();            
            //Console.WriteLine(ShowUpLetter(str));

            //Console.WriteLine("请输入一个首字母大写字符串");
            //str = Console.ReadLine();
            //Console.WriteLine(ShowLowLetter(str));
            
            KeSou();
            Console.ReadKey();
        }
        /// <summary>
        /// 统计出该字符中“咳嗽”二字的出现次数，以及每次“咳嗽”出现的索引位置。
        /// </summary>
        private static void KeSou()
        {
            string str = "患者：“大夫，我咳嗽得很重。”     大夫：“你多大年记？”     患者：“七十五岁。”     大夫：“二十岁咳嗽吗”患者：“不咳嗽。”     大夫：“四十岁时咳嗽吗？”     患者：“也不咳嗽。”     大夫：“那现在不咳嗽，还要等到什么时咳嗽？”";
            List<int> list = new List<int>();
            int index = 0;
            while (true)
            {
                index = str.IndexOf("咳嗽", index);
                if (-1 == index)
                {
                    break;
                }
                list.Add(index);
                index++;
            }
            Console.WriteLine("咳嗽的次数：{0}", list.Count);

            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i].ToString() + "\t");
            }
        }
        //返回值大写首字母
        /// <summary>
        /// 将输入的字符串的首字母大写，输出
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string ShowUpLetter(string str)
        {
            string letter = str.Substring(0, 1);
            letter = letter.ToUpper();
            return letter;
        }
        /// <summary>
        /// 将输入的字符串的首字母小写，输出
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string ShowLowLetter(string str)
        {
            string letter = str.Substring(0, 1);
            letter = letter.ToLower();
            return letter;
        }


    }
}
