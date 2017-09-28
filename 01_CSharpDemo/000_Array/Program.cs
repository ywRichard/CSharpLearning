using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _000_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 数据的声明和赋值
            //int[] nums = new int[10];
            //int[] numsTwo = { 1, 2, 3 };
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    nums[i] = i + 1;
            //}

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    Console.WriteLine(nums[i]);
            //}
            //Console.ReadKey(); 
            #endregion
            #region 数组的练习
            ////从一个整数数组中取出最大值，最小值，总和和平均值
            //int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            ////声明两个变量储存最大值和最小值。
            //int max = 0;
            //int min = 0;
            ////声明两个变量储存总和和平均值
            //int sum = 0;
            //double average = 0;
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (0 == i)
            //    {
            //        max = nums[i];
            //        min = nums[i];
            //    }
            //    else
            //    {
            //        if (nums[i] > max)
            //        {
            //            max = nums[i];
            //        }

            //        if (nums[i] < min)
            //        {
            //            min = nums[i];
            //        }
            //    }
            //    sum += nums[i];
            //}
            //average = (double)sum / nums.Length;
            //Console.WriteLine("max:{0}", max);
            //Console.WriteLine("min:{0}", min);
            //Console.WriteLine("sum:{0}", sum);
            //Console.WriteLine("average:{0}", average);
            //Console.ReadKey();
            //average = nums.Average; 
            #endregion

            #region 升序降序排列
            //int[] nums = { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
            //Array.Sort(nums);//升序的排列
            //Array.Reverse(nums);//元素倒序反转

            ////int temp = 0;
            ////int count = 0;
            ////for (int i = 0; i < nums.Length;  i++)
            ////{
            ////    Console.Write(nums[i] + "\t");
            ////}
            ////Console.WriteLine();

            ////for (int i = 0; i < nums.Length - 1; i++)
            ////{
            ////    for (int j = 0;  j < nums.Length - 1;  j++)
            ////    {
            ////        if (nums[j] > nums[j+1])
            ////        {
            ////            temp = nums[j];
            ////            nums[j] = nums[j+1];
            ////            nums[j+1] = temp;
            ////            count++;
            ////        }
            ////    }           
            ////}
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    Console.Write(nums[i] + "\t");
            //}
            #endregion

            #region 引用类型数组的初始化和实例化
            //方法一
            var ps = new Person[3];//声明
            for (int i = 0; i < ps.Length; i++)
            {
                ps[i] = new Person();//实例化
            }

            //方法二
            var ps2 = new Person[]//声明的同时，实例化
            {
                new Person(),
                new Person(),
            };
            ps.ToList().ForEach(p => Console.WriteLine(p.Name));
            #endregion
            Console.WriteLine();
            Console.ReadKey();
        }

        public class Person
        {
            private int _age;
            private string _name;

            public int Age { get => _age; set => _age = value; }
            public string Name { get => _name; set => _name = value; }
        }
    }
}
