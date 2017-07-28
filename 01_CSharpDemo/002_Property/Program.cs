using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Property
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person(-1);

            Console.WriteLine(p.Age);
            Console.WriteLine(p.Info);
        }
    }

    class Person
    {
        private int _age;
        public int Age
        {
            get
            {
                if (_age < 0)
                {
                    return 0;
                }
                else
                {
                    return _age;
                }
            }
            set
            {
                if (value<0)
                {
                    this.Info = "输入不合法";
                }
                else
                {
                    _age=value;
                }
            }
        }

        public Person(int age)
        {
            Age = age;
        }

        public string Info { set; get; }
    }
}
