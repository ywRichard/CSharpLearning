using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Text.RegularExpressions;

namespace _13_提取邮箱
{
    class Program
    {
        static void Main(string[] args)
        {
            //提取页面的所有邮箱
            WebClient wc = new WebClient();
            wc.Encoding=Encoding.UTF8;
            string html = wc.DownloadString("");

            //MatchCollection mc = Regex.Matches(html, "[0-9a-zA-Z_.-]+@[0-9a-zA-Z_.]+[.]+[a-zA-Z]{1,2}");

            MatchCollection mc = Regex.Matches(html, "([0-9a-zA-Z_.-]+)@([0-9a-zA-Z_.]+[.]+[a-zA-Z]{1,2})");

            foreach (Match item in mc)
            {
                if (item.Success)
                {
                    //Console.WriteLine(item.Value);
                    Console.WriteLine(item.Groups[1].Value+"==="+item.Groups[2].Value);
                }
            }

            Console.ReadLine();
        }
    }
}
