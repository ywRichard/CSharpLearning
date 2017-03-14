using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_DictionaryBasic
{
    /// <summary>
    /// Dictionary: 键和值对 KeyValuePair
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<int,string> dic=new Dictionary<int,string>();
            //Dictionary<int, string> dic = new Dictionary<int, string>();
            Dictionary<int, string> dic = new Dictionary<int, string>();

            //dic.Add(1,"张三");
            //dic.Add(2,"李四");
            //dic.Add(3,"王五");

            dic.Add(1,"张三");
            dic.Add(2,"李四");
            dic.Add(3,"王五");

            //foreach(var item in dic.Keys)
            //{
            //    Console.WriteLine(item);
            //}

            //foreach (KeyValuePair<int,string> kv in dic)
            //{
            //    Console.WriteLine("{0}--------{1}",kv.Key,kv.Value);
            //}

            foreach (KeyValuePair<int,string> kv in dic)
            {
                Console.WriteLine("{0}-------{1}", kv.Key, kv.Value);
            }

            Console.ReadKey();

        }
    }
}
