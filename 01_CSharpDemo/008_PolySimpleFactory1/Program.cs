using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _008_PolySimpleFactory1
{
    /// <summary>
    /// 通过简单工厂模型，理解面向对象的多态
    /// 通过抽象类实现
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("你要什么牌子的电脑？");
            string brand = Console.ReadLine();

            Notebook nb = MakeNotebook(brand);

            nb.SayHello();
            Console.ReadKey();

        }
        /// <summary>
        /// 简单工厂的核心 根据用户的输入创建对象复制给父类
        /// </summary>
        /// <param name="brand"></param>
        /// <returns></returns>
        public static Notebook MakeNotebook(string brand)
        {
            Notebook nb = null;

            switch (brand)
            {
                case "Lenovol": nb = new Lenovol();
                    break;
                case "Dell": nb = new Dell();
                    break;
                case "Acer": nb = new Acer();
                    break;
                case "Apple": nb = new Apple();
                    break;
                default:
                    break;
            }
            return nb;
        }
    }

    public abstract class Notebook
    {
        public abstract void SayHello();
    }

    public class Lenovol : Notebook
    {
        public override void SayHello()
        {
            Console.WriteLine("我是联想笔记本");
        }
    }

    public class Dell : Notebook
    {
        public override void SayHello()
        {
            Console.WriteLine("我是戴尔笔记本");
        }
    }

    public class Acer : Notebook
    {
        public override void SayHello()
        {
            Console.WriteLine("我是宏碁笔记本");
        }
    }

    public class Apple : Notebook
    {
        public override void SayHello()
        {
            Console.WriteLine("我是苹果笔记本");
        }
    }
}
