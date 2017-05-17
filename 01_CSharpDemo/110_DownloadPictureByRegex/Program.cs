using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Text.RegularExpressions;

namespace _15_下载图片
{
    class Program
    {
        static void Main(string[] args)
        {
            string htmlAdress = Console.ReadLine();

            WebClient wc = new WebClient();

            string html = wc.DownloadString(htmlAdress);
            MatchCollection mc = Regex.Matches(html, "");//把图片下载地址提取出来

            foreach (Match item in mc)
            {
                wc.DownloadFile(item.Value, "");
            }

            Console.WriteLine("已下载{0}",mc.Count);
            Console.WriteLine("开始新的下载请按回车，如果不下载请关闭程序");
            Console.ReadKey();
        }
    }
}
