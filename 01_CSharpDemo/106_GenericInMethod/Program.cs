using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _106_GenericInMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericDemo gd = new GenericDemo();
            gd.OutputDirect<int>(100);
            gd.OutputDirect<string>("This is good!");

            Console.WriteLine("##################");
            int a = 101;
            int b = 202;
            string str1 = "aaa";
            string str2 = "bbb";
         
            Console.WriteLine("a:{0},b:{1}", a, b);
            Console.WriteLine("str1:{0},str2:{1}", str1, str2);

            gd.SwitchValue<int>(ref a, ref b);
            gd.SwitchValue<string>(ref str1, ref str2);

            Console.WriteLine("a:{0},b:{1}", a, b);
            Console.WriteLine("str1:{0},str2:{1}", str1, str2);

            Console.WriteLine("##################");
            gd.MultiGenericMed<int,string>(100,"one hundred");
            Console.ReadLine();
        }
    }

    public class GenericDemo
    {
        public void OutputDirect<T>(T t)
        {
            Console.WriteLine(t);
        }

        public void SwitchValue<T>(ref T t, ref T d)
        {
            T temp = t;
            t = d;
            d = temp;
        }

        public void MultiGenericMed<T, K>(T t, K k)
        {
            Console.WriteLine("{0} = {1}",k, t);
        }

    }
}
