using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _007_InterfaceBasic1
{
    /// <summary>
    /// 接口和方法成员重名
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            IFlyable fly = new Bird();
            fly.fly();
            Bird bird = new Bird();
            bird.fly();
            Console.ReadKey();
        }
    }

    public class Bird:IFlyable
    {
        public void fly()
        {
            Console.WriteLine("类的飞");
        }

        void IFlyable.fly()
        {
            Console.WriteLine("接口的飞");
        }
    }

    public interface IFlyable
    {
        void fly();
    }

    public class MaQue : IFlyable
    {
        public void fly()
        {
            Console.WriteLine("接口的飞");
        }
    }

    public interface ISkyable : IFlyable//接口只能继承接口
    { 
    
    }

    //public class YinWu : IFlyable//类可以继承接口
    //{ 
    
    //}

}
