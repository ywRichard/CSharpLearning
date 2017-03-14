using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _002_LSP
{
    /// <summary>
    /// 里氏转换（Liskov Substitution Principle LSP）
    /// 子类可以扩展父类的功能，但不能改变父类原有的功能。
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //1、子类可以赋值给父类：如果有一个地方需要一个父类作为参数，我们可以给一个子类代替。
            //Person p = new Student();
            //2、如果父类中装的是子类对象，那么可以将这个父类强转为子类对象。
            //Person p = new Student();
            //Student ss = (Student)p;
            //if(p is Student)
            //{
            //    Console.WriteLine("succeed");
            //}
            //ss.StudentSayHello();
            //Console.ReadKey();
            #region MyRegion
	        Person[] per = new Person[10];
            Random r = new Random();

            for (int i = 0; i < 10; i++)
            {
                int index = r.Next(1, 7);
                switch (index)
                {
                    case 1:
                        per[i] = new Person();
                        break;
                    case 2:
                        per[i] = new Student();
                        break;
                    case 3:
                        per[i] = new Teacher();
                        break;
                    case 4:
                        per[i] = new ShuaiGuo();
                        break;
                    case 5:
                        per[i] = new MeiLv();
                        break;
                    case 6:
                        per[i] = new Animal();
                        break;
                    default: break;
                }
            }

            for (int i = 0; i < per.Length; i++)
            {
                if (per[i] is Student)
                {
                    ((Student)per[i]).StudentSayHello();
                }
                else if (per[i] is Teacher)
                {
                    ((Teacher)per[i]).TeacherSayHello();
                }
                else if (per[i] is ShuaiGuo)
                {
                    ((ShuaiGuo)per[i]).ShuaiGuoSayHello();
                }
                else if (per[i] is MeiLv)
                {
                    ((MeiLv)per[i]).MeiLvSayHello();
                }
                else if (per[i] is Animal)
                {
                    ((Animal)per[i]).AnimalSayHello();
                }
                else
                {
                    ((Person)per[i]).SayHello();
                }
            }
            Console.ReadKey();
	        #endregion
        } 
    }

    public class Person
    {
        public void SayHello()
        {
            Console.WriteLine("我是人");
        }
    }

    public class Student : Person
    {
        public void StudentSayHello()
        {
            Console.WriteLine("我是学生");
        }
    }

    public class Teacher : Person
    {
        public void TeacherSayHello()
        {
            Console.WriteLine("我是老师");
        }
    }

    public class ShuaiGuo : Person
    {
        public void ShuaiGuoSayHello()
        {
            Console.WriteLine("我是帅锅");
        }
    }

    public class MeiLv : Person
    {
        public void MeiLvSayHello()
        {
            Console.WriteLine("我是镁铝");
        }
    }

    public class Animal : Person
    {
        public void AnimalSayHello()
        {
            Console.WriteLine("我是野兽");
        }
    }

}
