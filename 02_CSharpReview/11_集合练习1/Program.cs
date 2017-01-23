using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _11_集合练习1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "1壹 2贰 3叁 4肆 5伍 6陸 7柒 8捌 9玖";
            string[] number = str.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, string> dc = new Dictionary<string, string>();

            for (int i = 0; i < number.Length; i++)
            {
                dc.Add(number[i].Substring(0, 1), number[i].Substring(1, 1));
            }

            Console.WriteLine("请输入数字:");
            string strRead = Console.ReadLine();

            for (int i = 0; i < strRead.Length; i++)
            {
                if (dc.ContainsKey(strRead[i].ToString()))
                {
                    Console.Write(dc[strRead[i].ToString()]);
                }
                else
                {
                    Console.Write(strRead[i].ToString());
                }
            }

            Console.ReadLine();
        }
    }
}
