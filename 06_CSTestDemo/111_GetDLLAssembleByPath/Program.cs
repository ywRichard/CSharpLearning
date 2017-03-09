using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace _32_通过路径获得Dll的程序集
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly asb = Assembly.LoadFrom(@"Z:\Documents\GitHub\CSharpLearning\02_CSharpReview\32_提供程序集的DLL\bin\Debug\32_提供程序集的DLL.dll");
            Type[] tp = asb.GetTypes();
            foreach (var item in tp)
            {
                Console.WriteLine("*****************");
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Namespace);
            }

            Console.ReadLine();
        }
    }
}
