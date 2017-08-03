using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _020_CustomizeException
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = -1;

            try
            {
                Sample s = new Sample(n1);
                Console.WriteLine(s.Message);
            }
            catch (MyException e)
            {
                Console.WriteLine("Opps, a Exception");
                Console.WriteLine(e.Message);
            }
        }
    }

    public class MyException : Exception
    {
        public MyException(Sample s)
            : base("From Exception Message")
        {
            Console.WriteLine(s.Message);
        }
    }

    public class Sample
    {
        public string Message { get; set; }

        int _number;
        public int Number
        {
            get
            {
                return _number;
            }

            set
            {
                value = _number;
            }
        }

        public Sample(int n)
        {
            if (n>0&&n<10)
            {
                _number = 10;
                Message = "The number is right";
            }
            else
            {
                Message = string.Format("The {0} is out of the scope", n);
                throw new MyException(this);
            }
        }
    }
}
