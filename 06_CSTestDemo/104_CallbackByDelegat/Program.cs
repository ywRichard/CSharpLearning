using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _104_CallbackByDelegat
{
    public delegate void NoticeList();

    class Program
    {
        static void Main(string[] args)
        {
            Employee em = new Employee();
            Robot r = new Robot();
            Leader ld = new Leader();
            Boss bs = new Boss();

            r.NoticeOther += ld.GetTheNotice;
            r.NoticeOther += bs.GetTheNotice;

            em.DoSth("my laundry");

            r.NoticeOther();

            Console.ReadLine();
            
        }
    }

    public class Employee
    {
        public void DoSth(string work)
        {
            Console.WriteLine("I'm doing {0}",work);
        }
    }

    public class Robot
    {
        public NoticeList NoticeOther;

        public void DoneSth()
        {
            Console.WriteLine("He has finished his work!");
            if (NoticeOther != null)
            {
                NoticeOther();
            }
        }
    }

    public class Leader
    {
        public void GetTheNotice()
        {
            Console.WriteLine("I see!");
        }
    }

    public class Boss
    {
        public void GetTheNotice()
        {
            Console.WriteLine("Well done!");
        }
    }
}
