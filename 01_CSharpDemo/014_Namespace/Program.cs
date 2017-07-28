using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _类的练习复习;

namespace _014_Namespace
{
    class Program
    {
        static void Main(string[] args)
        {
            Ticket Tic = new Ticket(110);
            Tic.ShowPrice();
            Console.ReadKey();
        }
    }
}
