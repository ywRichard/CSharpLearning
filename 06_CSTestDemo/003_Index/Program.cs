using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07_索引器
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            Console.WriteLine(p[2]);

            Console.WriteLine(p['M']);

            Console.ReadLine();
        }
    }

    public class Person
    { 
        public string[] Names={"jordon","mercy","Richard","Feynman"};//索引器

        public string this[int index]
        {
            get 
            {
                string name = "";
                switch (index)
                {
                    case 0: name = "Jordon"; break;
                    case 1: name = "mercy"; break;
                    case 2: name = "Richard"; break;
                    case 3: name = "Feynman"; break;
                    default:
                        break;
                }
                return name;
            }
        }

        public string this[char c]
        {
            get
            {
                string name = "";
                switch (c)
                {
                    case 'J': name = "Jordon"; break;
                    case 'M': name = "mercy"; break;
                    case 'R': name = "Richard"; break;
                    case 'F': name = "Feynman"; break;
                    default:
                        break;
                }
                return name;
            }
        }
    }
}
