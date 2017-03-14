using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _001_inherit
{
    /// <summary>
    /// 类的继承：解决类中代码的冗余
    /// 
        #region 继承的知识点
        //1、子类（派生类）：继承了父类的属性和方法，但是没有继承父类的私有字段。
        //2、子类可以调用父类的成员，父类不能调用子类的成员。
        //3、构造函数：子类不继承父类的构造函数。但是子类会默认的调用父类的构造函数，创建父类对象，让子类可以使用父类中的成员。
        //如果在父类中重新写一个有参数的构造函数之后，那个无参数的就被干掉了，子类就调用不到了，所以子类会报错。
        //解决办法：1、在父类中重新写一个无参数的构造函数。
        //         2、在子类中显示的调用父类的构造函数，使用关键字:base()
        #endregion
        #region 继承特性
        //1、继承的单根性：一个子类只能有一个父类。
        //2、继承的传递性：多重继承。
        #endregion
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //记者：我是记者 爱好偷拍 年龄34岁 我是一个男狗仔
            //司机：我叫舒马赫，年龄45 男人 驾龄23年
            //程序员：我叫孙权 年龄44 男生 工作年限3年
            Reporter Rep = new Reporter("记者",34,'男',"偷拍");
            Programmer Pro = new Programmer("孙权", 44, '男', 3);
            Driver Dri = new Driver("舒马赫", 45, '男', 23);

            Rep.ReportSayHello();
            Rep.SayHello();
            Pro.ProgrammerSayHello();
            Pro.SayHello();
            Dri.DriverSayHello();
            Dri.SayHello();

            Console.ReadKey();
        }
    }
}
