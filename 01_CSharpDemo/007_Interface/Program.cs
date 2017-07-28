using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _007_Interface
{
    /// <summary>
    /// 登记案例，接口练习。
    /// 接口就是一种能力或者方法，主要是为了实现类的多态，类是具有某种特性的事物。
    /// 什么是多态呢？---多态就是让一个对象通过接口，抽象，重写和虚方法等让同一个方法表现出不同的状态。
    /// 抽象与接口的应用范围，鸭子会飞，飞机也会飞。
    /// 接口中的成员不需要写访问修饰符，默认public。
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            IDengJi dj = new House();
            dj.DengJi();

            GetDengji(new Car());

            Console.ReadLine();
        }

        public static void GetDengji(IDengJi dj)
        {
            dj.DengJi();
        }
    }
}
