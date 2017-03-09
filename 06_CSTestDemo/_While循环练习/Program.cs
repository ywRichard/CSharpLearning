using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _000_while
{
    /// <summary>
    /// while循环的练习
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //要求：求1-100之间所有的整数之和
            //循环体：result=result+n;
            //循环条件：n<=100
            int n = 1;
            int result = 0;
            while (n <= 100)
            {
                //result = result + n;
                result += n;
                n++;
            }
            Console.WriteLine("1-100之间所有的整数之和：{0}", result);
            Console.ReadKey();

            //for (int i = 0; i < length; i++)
            //{
            //    for (int i = 0; i < length; i++)
            //    {
                    
            //    }
            //}
        }
    }
}
