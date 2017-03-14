using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _106_GenericInDelegate
{
    delegate T GenerDel<T>(T t);
    class Program
    {
        public static int AddNum(int n)
        {
            return n + n - 1;
        }

        public static int MultiNum(int n)
        {
            return n * n - 1;
        }

        static void Main(string[] args)
        {
            GenerDel<int> gd = new GenerDel<int>(AddNum);
            Console.WriteLine(gd(10));

            gd = MultiNum;

            Console.WriteLine(gd(10));

            Console.ReadLine();
        }
    }
}
