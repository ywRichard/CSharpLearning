using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _类的继承
{
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
