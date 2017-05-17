using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace _32_Type的几个常用方法
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly asb = Assembly.LoadFrom(@"Z:\Documents\GitHub\CSharpLearning\02_CSharpReview\32_提供程序集的DLL\bin\Debug\32_提供程序集的DLL.dll");
            Type tyPer = asb.GetType("_MyClass.Person");
            Type tyStu = asb.GetType("_MyClass.Student");

            //动态创建对象
            object obj = Activator.CreateInstance(tyPer);
            bool flag;
            //判断tyStu是不是可以给tyPer赋值
            //flag = tyPer.IsAssignableFrom(tyStu);

            //判断tyStu是不是tyPer的子类
            //flag = tyStu.IsSubclassOf(tyPer);

            //判断tyStu是不是抽象类
            //flag = tyStu.IsAbstract;
            flag = asb.GetType("_MyClass.Animal").IsAbstract;

            Console.WriteLine(flag.ToString());

            Console.ReadLine();
        }
    }
}
