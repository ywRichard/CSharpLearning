using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _方法的练习2
{
    class Program
    {
        static void Main(string[] args)
        {
            //有一个字符串数组：{ "马龙", "迈克尔乔丹", "雷吉米勒", "蒂姆邓肯", "科比布莱恩特" },请输出最长的字符串。
            string[] str = { "马龙", "迈克尔乔丹", "雷吉米勒", "蒂姆邓肯", "科比布莱恩特" };
            //int index = JudgeLength(str);
            int index;
            JudgeLength(out index, "马龙", "迈克尔乔丹", "雷吉米勒", "蒂姆邓肯", "科比布莱恩特");
            Console.WriteLine("最长的字符串：{0}", str[index]);
            Console.ReadKey();
        }
        //参数：字符串数组
        //方法体：比较字符串的长度
        //返回值：最长的字符串
        public static void JudgeLength(out int index, params string[] str)
        {
            //int index = -1;
            index = 0;
            int max = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (max < str[i].Length)
                {
                    index = i;
                }
            }

            //return index;
        }
    }
}
