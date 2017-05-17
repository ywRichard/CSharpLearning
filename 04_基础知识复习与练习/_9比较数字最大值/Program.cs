using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _9比较数字最大值
{
    class Program
    {
        static void Main(string[] args)
        {
            //用方法来实现：计算两个数的最大值。思考：方法的参数？返回值？扩展（*）：计算任意多个数间的最大值（提示：params）。
            Console.WriteLine("请输入a:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入b:");
            int b = Convert.ToInt32(Console.ReadLine());
            //int max = Judge(a,b);//方法比较

            //int max = (a > b) ? a : b;//三元运算符

            int max = Judge(a, b, 10, 30, 599);//params参数

            Console.WriteLine("最大值为{0}", max);
            Console.ReadKey();
        }

        public static int Judge(int a, int b)
        {
            int max = 0;
            if (a > b)
            {
                max = a;
            }
            else
            {
                max = b;
            }
            return max;
        }
        //params
        public static int Judge(params int[] num)
        {
            int max = 0;

            for (int i = 0; i < num.Length; i++)
            {
                max = num[0];
                if (num[i]>max)
                {
                    max = num[i];
                }
            }
            return max;
        }
    }
}
