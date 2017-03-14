using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _010_ListBasic
{
    /// <summary>
    /// List基本操作
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //创建泛型集合对象
            //List<int> list=new List<int>();
            //List<int> list = new List<int>();
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);

            list.AddRange(new int[] { 3, 4, 5, 6, 7, 8, 9, 0 });


            //List泛型集合可以转换为数组
            //int[] num = list.ToArray();
            //for (int i = 0; i < num.Length; i++)
            //{
            //    Console.WriteLine(num[i]);
            //}

            //数组转换为List泛型集合
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            char[] chs = new char[] { 'a', 'b', 'c' };
            //List<char> listChs = chs.ToList();
            //char[] chs = new char[] { 'a', 's', 'd' };
            //List<char> listChs = chs.ToList();
            List<char> listChs = chs.ToList();
            for (int i = 0; i < listChs.Count; i++)
            {
                Console.WriteLine(listChs[i]);
            }

            Console.ReadKey();
        }
    }
}
