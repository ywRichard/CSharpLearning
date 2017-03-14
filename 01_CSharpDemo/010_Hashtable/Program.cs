using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace _010_Hashtable
{
    /// <summary>
    /// 哈希表，键值对集合
    /// 键必须是唯一的，值可以重复。在键值对对象中，我们是根据键去找值的。
    /// </summary>
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
