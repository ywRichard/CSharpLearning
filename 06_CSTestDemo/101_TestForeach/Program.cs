using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;

            string[] aryTest = new string[] { "OK", "Name", "surName" };
            string[] mainTest = new string[] { "haha", "heihei", "hehe" };
            foreach (var main in mainTest)
            {
                foreach (string item in aryTest)
                {
                    if ("Name" == item)
                    {
                        break;
                    }

                    Console.WriteLine("Count:{0}", count);
                }

                Console.WriteLine(main);
            }

            Console.ReadLine();
        }
    }
}
