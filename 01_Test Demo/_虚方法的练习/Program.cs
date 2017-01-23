using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _虚方法的练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //实现员工9点打卡，经理11点打卡，程序员不打开
            Employee em = new Employee();
            Manger ma = new Manger();
            Programmer pm = new Programmer();

            Employee[] emArray = new Employee[] { em, ma, pm };

            for (int i = 0; i < emArray.Length; i++)
            {
                emArray[i].Daka();
            }
            Console.ReadKey();
        }

    }

    public class Employee
    {
        public virtual void Daka()
        {
            Console.WriteLine("员工9点打卡");
        }
    }

    public class Manger : Employee
    {
        public override void Daka()
        {
            Console.WriteLine("经理11点打卡");
        }
    }

    public class Programmer : Employee
    {
        public override void Daka()
        {
            Console.WriteLine("程序员不打卡");
        }
    }
}
