using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01_继承
{
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
