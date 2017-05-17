using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _008_PolyByVirtual
{
    /// <summary>
    /// 虚方法实现多态
    #region 虚方法
    //实现步骤：将父类标记为虚函数，使用关键字virtual，这个函数可以被子类重写一遍
    //注意点：
    //    1.父类中如果有方法需要让子类重写，则可以将该方法标记为virtual
    //    2.虚方法在父类中必须有实现，哪怕是空实现。
    //    3.虚方法子类可以重写（override），也可以不重写
    #endregion
    /// </summary>
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
