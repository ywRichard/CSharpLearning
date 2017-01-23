using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _类的练习复习
{
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
