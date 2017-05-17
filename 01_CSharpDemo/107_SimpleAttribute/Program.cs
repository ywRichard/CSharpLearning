#define DEBUG //Setting the code to debug mode no matter that the environment is debug or release
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
 
namespace _107_SimpleAttribute
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass.Message("In My Class");
            Function1("In Function1");
            Function2("In Function2");

            Console.ReadLine();
        }

        [Obsolete("Don't used old Method",true)]//remark method or class
        private static void Function1(string msg)
        {
            MyClass.Message(msg);
        }

        private static void Function2(string msg)
        {
            MyClass.Message(msg);
        }
    }

    public class MyClass
    {
        //[Conditional("DEBUG")]
        [Conditional("RELEASE")]
        public static void Message(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
