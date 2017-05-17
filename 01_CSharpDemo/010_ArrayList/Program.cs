using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace _010_ArrayList
{
    /// <summary>
    /// ArrayList 集合：很多数据的集合。集合可以转换为数组
    /// 集合：长度可变，类型随便; 数组：长度不变，类型单一
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            ////创建一个集合，里面添加一些数字，求平均值与和。
            //ArrayList List = new ArrayList();
            //List.Add(10);
            //List.Add(20);
            //List.AddRange(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });
            //int sum = 0;
            //for (int i = 0; i < List.Count; i++)
            //{
            //    sum += (int)List[i];
            //}
            //double average = (double)sum / 2;
            //Console.WriteLine(List.Count);
            //Console.WriteLine(average);
            //Console.WriteLine(sum);
            //Console.ReadKey();

            //写一个长度为10的集合，要求在里面随机存放10个数字（0-9）
            //要求所有的数字不同。
            ArrayList List = new ArrayList();
            Random r = new Random();
            int count = 0;
            while (true)
            {
                int num = r.Next(0, 10);
                count++;
                if (List.Count <10)
                {
                    if (!List.Contains(num))
                    {
                        List.Add(num);
                    }
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine("一共执行了{0}次",count);
            for (int i = 0; i < List.Count; i++)
            {
                Console.WriteLine(List[i]);                
            }
            Console.ReadKey();
        }
    }
}
