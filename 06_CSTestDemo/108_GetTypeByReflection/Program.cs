using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace _108_GetTypeByReflection
{
    class Program
    {
        static void Main(string[] args)
        {
            //several functions to get type
            string str = "Hello World!";
            Type t = str.GetType();
            //Console.WriteLine(t.FullName);

            //Type t1 = Type.GetType("System.String");
            //Console.WriteLine(t1.FullName);

            //Type t2 = typeof(string);
            //Console.WriteLine(t2.FullName); 

            //Get method info
            //GetMethodInfo(t);
            //Console.WriteLine("*****************");
            //Console.WriteLine(t.GetMethod("Copy"));

            //Console.WriteLine("*****************");
            //GetMethodInfoByFlag(t, BindingFlags.Public|BindingFlags.Static);

            Console.WriteLine("*****************");
            GetProperties(t,BindingFlags.Public);
            Console.ReadLine();
        }

        public static void GetMethodInfo(Type t)
        {
            foreach (MethodInfo mi in t.GetMethods())
            {
                Console.WriteLine(mi.Name);
            }
        }

        public static void GetMethodInfoByFlag(Type t,BindingFlags bf)
        {
            foreach (MethodInfo mi in t.GetMethods(bf))
            {
                Console.WriteLine(mi.Name);
            }
        }

        public static void GetProperties(Type t,BindingFlags bf)
        {
            foreach (PropertyInfo pi in t.GetProperties(bf))
            {
                Console.WriteLine(pi.Name);
            }
        }
    }
}
