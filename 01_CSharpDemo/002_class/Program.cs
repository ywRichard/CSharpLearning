using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _002_class
{
    /// <summary>
    /// 类的学习案例
    /// 类是个抽象的概念，只申明对象的属性和方法。
    /// 对象：是类的实例，有属性和方法。类不占内存，对象占。
        #region new关键字
        //new的作用
        // 1、创建对象（）
        // 2、隐藏从父类那里继承过来得同名成员。隐藏的后果就是子类调用不到父类。

        //new一个对象的步骤
        // 1、在内存开辟空间
        // 2、在开辟的空间中创建对象
        // 3、调用对象的构造函数进行初始化对象。(new)调用
        #endregion
        #region this关键字
        //1、代表当前这个类的对象。
        //2、在类当中显示的调用本类的构造函数:this
        #endregion
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            ////Person ZhanSan = new Person("战三", 117, '男');

            ////Person Lisi = new Person("李四", 10, '人');
            //Person ZhanSan = new Person("战三", '男');

            //Person Lisi = new Person("李四", '人');

            //ZhanSan.CHLSS();
            //Lisi.CHLSS();
            //Console.ReadKey();

            Ticket T1 = new Ticket(220);
            //T1.TotalPrice();
            T1.ShowPrice();
            Console.ReadKey();
        }
    }
}
