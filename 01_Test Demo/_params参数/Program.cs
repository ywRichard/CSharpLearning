using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _params参数
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = ArraySum(1, 2, 3, 4);
            Console.WriteLine(sum);
            Console.ReadKey();
        }
        //public static int ArraySum(params int[] number)
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
