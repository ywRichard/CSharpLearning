using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _17冒泡法排序
{
    class Program
    {
        static void Main(string[] args)
        {
            //冒泡排序法对整数数组{ 1, 3, 5, 7, 90, 2, 4, 6, 8, 10 }实现升序排序。
            int[] numArray = { 1, 3, 5, 7, 9, 2, 4, 6, 8, 10 };
            int temp = 0;
            for (int i = 0; i < numArray.Length; i++)
            {
                for (int j = i; j < numArray.Length; j++)
                {
                    if (numArray[j]>numArray[i])
                    {
                        temp = numArray[i];
                        numArray[i] = numArray[j];
                        numArray[j] = temp;
                    }
                }
            }
            for (int i = 0; i < numArray.Length; i++)
            {
                Console.Write(numArray[i].ToString()+"\t");
            }
            Console.ReadKey();
        }
    }
}
