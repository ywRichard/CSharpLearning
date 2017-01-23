using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace _键值对集合
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add(1,"张三");
            ht.Add(2,"李四");
            ht.Add(3, "王五");
            ht.Add(false, "错误的");
            ht.Add(true,"正确的");
            //ht[true] = "abc";
            ht.Add("abc","abc");

            if (!ht.Contains("abc"))
            {
                ht.Add("abc", "cba");
            }
            else
            {
                Console.WriteLine("已包含该值");
            }

            foreach (var item in ht.Keys)
            {
                Console.WriteLine("键是----{0},值是======{1}", item, ht[item]);
            }

            //Console.WriteLine(ht[true]);
            Console.ReadKey();


        }
    }
}
