using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _010_ListDictExcs
{
    /// <summary>
    /// List & Dict 集合练习
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            
            #region 练习一：将一个数组中的奇数放到一个集合中，再将偶数放到另一个集合中。最终将两个集合合并为一个集合，并且奇数显示在左边，偶数显示在右边
            //int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //List<int> listEven = new List<int>();
            //List<int> listOdd = new List<int>();

            //for (int i = 0; i < num.Length; i++)
            //{
            //    if (num[i] % 2 == 0)
            //    {
            //        listEven.Add(i);
            //    }
            //    else
            //    {
            //        listOdd.Add(i);
            //    }
            //}
            //listEven.AddRange(listOdd);
            //foreach (var item in listEven)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.ReadKey(); 
            #endregion

            #region 练习二：提示用户输入一个字符串，通过foreach循环将用户输入的字符串赋值给已字符数组
            //Console.WriteLine("请输入一个字符串！");
            //string input = Console.ReadLine();
            ////List<char> list=input.ToList<char>();
            //char[] chs = new char[input.Length];
            //int i = 0;

            //foreach (char item in input)
            //{
            //    chs[i] = item;
            //    i++;
            //}

            //foreach (char item in chs)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.ReadKey(); 
            #endregion

            #region 练习三：统计 Welcome to China 在每个字符中出现的次数，不考虑大小写。
            //string str = "Welcome to china";
            //Dictionary<char, int> dic = new Dictionary<char, int>();
            //char ch = ' ';

            //for (int i = 0; i < str.Length; i++)
            //{
            //    if (str[i] == ' ')
            //    {
            //        continue;
            //    }
            //    if (dic.ContainsKey(str[i]))
            //    {
            //        dic[str[i]]++;
            //    }
            //    else
            //    {
            //        dic[str[i]] = 1;
            //    }
            //}
            //foreach (KeyValuePair<char, int> kv in dic)
            //{
            //    Console.WriteLine("{0}---{1}", kv.Key, kv.Value);
            //} 
            #endregion

            //字符---键
            //次数---值
            
            string str = "Welcome to China";
            //Dictionary<char, int> dic = new Dictionary<char, int>();
            Dictionary<char,int> dic = new Dictionary<char,int>();
            for (int i = 0; i <str.Length; i++)
            {
                if (str[i]==' ')
                {
                    continue;
                }
                if (dic.ContainsKey(str[i]))
                {
                    dic[str[i]]++;
                }
                else
                {
                    dic[str[i]] = 1;
                }
            }

            foreach (KeyValuePair<char,int> kv in dic)
            {
                Console.WriteLine("{0}-----{1}", kv.Key, kv.Value);
            }
            Console.ReadKey();
        }
    }
}
