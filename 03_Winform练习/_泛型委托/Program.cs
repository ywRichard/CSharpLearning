using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _泛型委托
{
    //public delegate int DelCompare(object o1, object o2);
    //public delegate int DelCompare<T>(T o1, T o2);
    public delegate int DelCompare<T>(T o1,T o2);

    class Program
    {
        #region MyRegion
        //static void Main(string[] args)
        //{
        //    object[] o = { "abc", "fdsfdsds", "fdsfdsfdsfdsfdsfds", "fdsfds" };
        //    //object result = GetMax(o, Compare2);
        //    //object result = GetMax(o, delegate(object o1, object o2) {
        //    //    string s1 = (string)o1;
        //    //    string s2 = (string)o2;
        //    //    return s1.Length - s2.Length;
        //    //});

        //    object result = GetMax(o, (object o1, object o2) =>
        //    {
        //        string s1 = (string)o1;
        //        string s2 = (string)o2;
        //        return s1.Length - s2.Length;
        //    });
        //    Console.WriteLine(result);
        //    Console.ReadKey();
        //}

        //public static object GetMax(object[] nums, DelCompare del)
        //{
        //    object max = nums[0];
        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        //要传一个比较的方法
        //        if (del(max, nums[i]) < 0)
        //        {
        //            max = nums[i];
        //        }
        //    }
        //    return max;
        //} 
        #endregion

        static void Main(string[] args)
        {
            //object[] nums = { 1, 2, 3, 4, 5 };
            //object max = GetMax(nums, delegate(object o1,object o2) {
            //    int num1 = (int)o1;
            //    int num2 = (int)o2;
            //    return num1 - num2;
            //});

            string[] strs = { "qwert", "adfsdfsadf", "tyutiuyi" };
            //object result = GetMax(strs,Compare);//委托
            //object result = GetMax(strs, delegate(object o1,object o2) {//匿名函数
            //    return ((string)o1).Length - ((string)o2).Length;
            //});
            //Console.WriteLine(max);
            //object result = GetMax(strs, (object o1, object o2) => { return ((string)o1).Length - ((string)o2).Length; });
            //Console.WriteLine(result);
            //Console.ReadKey();
            string result = GetMax<string>(strs, delegate(string s1, string s2) {
                return s1.Length - s2.Length;
            });
            Console.WriteLine(result);
            Console.ReadKey();
        }

        //public static object GetMax(object[] nums, DelCompare delCompare)
        //{
        //    object max = nums[0];
        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        if (delCompare(max, nums[i]) < 0)
        //        {
        //            max = nums[i];
        //        }
        //    }
        //    return max;
        //}
        public static T GetMax<T>(T[] o, DelCompare<T> delCompare)
        {
            T max = o[0];
            for (int i = 0; i < o.Length; i++)
            {
                if (delCompare(max, o[i]) < 0)
                {
                    max = o[i];
                }
            }
            return max;
        }
        //public static int Compare(object o1, object o2)
        //{
        //    string str1 = (string)o1;
        //    string str2 = (string)o2;
        //    return str1.Length - str2.Length;
        //}
    }
}
