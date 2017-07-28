using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _001_InheritClass
{
    /// <summary>
    /// 类的继承，子类可以给父类赋值，那么父类在调用方法的时候，实现的是子类方法的实现
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            Animal Chicken = new Chicken();
            Dog dog = new Dog();

            cat.Eat();
            cat.Shout();
            Chicken.Eat();
            Chicken.Shout();
            dog.Eat();
            dog.Shout();
            Console.ReadLine();
        }
    }
}
