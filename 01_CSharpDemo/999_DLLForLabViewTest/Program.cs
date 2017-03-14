using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DemoForLabView;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            AddNum addNum = new AddNum();
            Console.WriteLine(addNum.Add(1, 11).ToString());
            Console.ReadLine();
        }
    }
}