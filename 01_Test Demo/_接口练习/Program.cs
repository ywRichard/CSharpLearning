using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _接口练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //麻雀会飞，鹦鹉会飞，鸵鸟会飞，企鹅会飞，直升机会飞
            //用多态来实现，方法，抽象类，接口
            IFlyable fly = new Helicopper();//new YinWu();//new MaQue();
            fly.Fly();
            Console.ReadKey();
        }

        public abstract class Bird
        {
            public abstract void Fly();
        }

        public interface IFlyable
        {
            void Fly();
        }

        public class MaQue:Bird,IFlyable
        {
            public override void Fly()
            {
                Console.WriteLine("麻雀会飞");
            }
        }

        public class YinWu:Bird,IFlyable
        {
            public override void Fly()
            {
                Console.WriteLine("鹦鹉会飞");
            }
        }

        public class TuoNiao:Bird,IFlyable
        {
            public override void Fly()
            {
                Console.WriteLine("鸵鸟会飞");
            }
        }

        public class QiE:Bird,IFlyable
        {
            public override void Fly()
            {
                Console.WriteLine("企鹅会飞");
            }
        }

        public class Helicopper:IFlyable
        { 
            public void Fly()
            {
                Console.WriteLine("直升机会飞");
            }
        }
    }
}
