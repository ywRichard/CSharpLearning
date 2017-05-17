using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Text.RegularExpressions;

namespace _13_获取职位
{
    class Program
    {
        static void Main(string[] args)
        {
            WebClient wc = new WebClient();
            string html = wc.DownloadString("");

            MatchCollection mc = Regex.Matches(html, "");//正则表达式，匹配文件类型

            foreach (Match item in mc)
            {
                if (item.Success)
                {
                    Console.WriteLine(item.Groups[2].Value);
                }
            }

            Console.ReadLine();
        }
    }
}
