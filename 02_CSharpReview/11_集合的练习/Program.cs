using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _11_集合的练习
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 练习一
            //两个List集合{a,b,c,d,e}和{d,e,f,g,h}，去除重复项，合并集合

            //List<string> list1 = new List<string>() { "a", "b", "c", "d", "e" };
            //List<string> list2 = new List<string>() { "d", "e", "f", "g", "h" };

            //List<string> list = new List<string>();
            //list.AddRange(list1.Union(list2).Distinct());

            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 练习二
            //随机生成1-100之间的数放到List中，要求这10个数不能重复，并且都是偶数.
            List<int> list = new List<int>();
            Random rd = new Random();
            int count = 0;

            while(list.Count<10)
            {
                int num = rd.Next(1,101);
                if (num%2==0)
                {
                    if (!list.Contains(num))
                    {
                        list.Add(num);   
                    }
                }

                count++;
            }

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("---------------");
            Console.WriteLine("循环次数{0}", count);

            #endregion
            Console.ReadLine();
        }
    }
}
