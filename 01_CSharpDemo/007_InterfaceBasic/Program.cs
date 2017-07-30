using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _007_InterfaceBasic
{
    /// <Common Sense>
    /// 接口:是一种规范或者能力，只允许有方法和属性
    /// 1、为了多态，接口不能被实例化，不能被new创建。抽象类，接口，静态类都不能是实例化。
    /// 2、只能有方法（属性，索引器、事件也是方法），不能有字段和构造函数。
    /// 3、接口和接口之间可以继承，并且可以多继承。
    /// 4、接口只能继承接口，而类可以继承接口。
    /// 5、一个类同时继承类和接口，类要写在接口前面
    /// 6、接口中的成员不能有任何访问修饰符----默认就是public的
    /// 7、实现接口的子类必须将接口中的所有成员全都实现。
    /// 8、子类实现接口的方法，不需要任何关键字，直接实现即可。
    /// 9、接口存在的意义就是为了多态。
    /// </Common Sense>

    /// <成员>
    /// 1、接口成员不允许添加访问修饰符，默认就是public
    /// 2、不允许写具体方法体的函数
    /// 3、不允许有字段
    /// </成员>

    class Program
    {
        static void Main(string[] args)
        {
            #region 接口实现多态
            //麻雀会飞，鹦鹉会飞，鸵鸟会飞，企鹅会飞，直升机会飞
            //用多态来实现，方法，抽象类，接口
            //IFlyable fly = new Helicopper();//new YinWu();//new MaQue();
            //fly.Fly();
            #endregion

            #region 接口的修饰符
            MyBase mb = new MyBase();
            MyDerivedClass dc = new MyDerivedClass();

            mb.DoSomething();
            IMyInterface imb = mb;
            imb.DoSomethingElse();

            Console.WriteLine("-------------------");
            dc.DoSomething();
            dc.DoSomethingElse();

            Console.WriteLine("-------------------");
            //MyDerivedClass dc1 = (MyDerivedClass) mb;//父类不能赋值给子类
            
            #endregion

            Console.ReadKey();
        }

        #region 接口实现多态
        public abstract class Bird
        {
            public abstract void Fly();
        }

        public interface IFlyable
        {
            void Fly();
        }

        public class MaQue : Bird, IFlyable
        {
            public override void Fly()
            {
                Console.WriteLine("麻雀会飞");
            }
        }

        public class YinWu : Bird, IFlyable
        {
            public override void Fly()
            {
                Console.WriteLine("鹦鹉会飞");
            }
        }

        public class TuoNiao : Bird, IFlyable
        {
            public override void Fly()
            {
                Console.WriteLine("鸵鸟会飞");
            }
        }

        public class QiE : Bird, IFlyable
        {
            public override void Fly()
            {
                Console.WriteLine("企鹅会飞");
            }
        }

        public class Helicopper : IFlyable
        {
            public void Fly()
            {
                Console.WriteLine("直升机会飞");
            }
        }
        #endregion

        #region 接口的修饰符
        public interface IMyInterface
        {
            void DoSomething();
            void DoSomethingElse();
        }

        class MyBase : IMyInterface
        {
            public virtual void DoSomething()
            {
                Console.WriteLine("我是父类的DoSomething");
            }

            void IMyInterface.DoSomethingElse()
            {
                Console.WriteLine("我是父类的DoSomethingElse");
            }
        }

        class MyDerivedClass : MyBase
        {
            public override void DoSomething()
            {
                Console.WriteLine("我是子类的DoSomething");
            }

            public void DoSomethingElse()
            {
                Console.WriteLine("我是子类的DoSomethingElse");
            }
        }
        #endregion
    }
}
