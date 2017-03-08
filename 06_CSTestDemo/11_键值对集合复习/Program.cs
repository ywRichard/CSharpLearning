using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _11_键值对集合复习
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dc = new Dictionary<string, string>();

            dc.Add("qwe", "屌丝1");
            dc.Add("asd", "码农");
            dc.Add("zxc", "变帅了");

            //遍历键值对中的键
            foreach (string item in dc.Keys)
            {
                Console.WriteLine(item);   
            }

            //遍历键值对中值
            foreach (var item in dc.Values)
            {
                Console.WriteLine(item);
            }

            //遍历键值对
            foreach (KeyValuePair<string,string> item in dc)
            {
                Console.WriteLine(item.Key+"===="+item.Value);
            }

            Console.ReadLine();
        }
    }
}
