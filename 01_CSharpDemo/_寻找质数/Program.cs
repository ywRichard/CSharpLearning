using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _寻找质数
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            for (int i = 2; i <= 100; i++)
            {
                flag = true;
                for (int j = 2; j <= i-1; j++)
                {
                    //if(j == 1 || j == i)
                    //{
                    //    continue;
                    //}
                    if(i % j == 0)
                    {
                        flag = false;
                        break;//只要能整除一个就不是质数，不用进行后面的计算。
                    }
                }
                if(true == flag)
                {
                    Console.WriteLine(i);
                }
            }//i的for循环括号
            Console.ReadKey();
        }
    }
}
