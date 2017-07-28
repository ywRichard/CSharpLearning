using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _009_params
{
    /// <summary>
    /// 将实参列表中跟可变参数数组类型一致的元素都当做数组的元素去处理。
    /// 必须是形参列表中的最后一个。
    /// 一个方法中只允许有一个params参数。
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int sum = ArraySum(1, 2, 3, 4);
            Console.WriteLine(sum);
            Console.ReadKey();
        }

        public static int ArraySum(params int[] number)
        {
            int sum = 0;
            for (int i = 0; i < number.Length; i++)
            {
                sum += number[i];
            }
            return sum;
        }
    }
}
