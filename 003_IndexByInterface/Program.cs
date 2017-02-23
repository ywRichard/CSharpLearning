using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _003_IndexByInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strName = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };

            IndexName names = new IndexName(strName);
            for (int i = 0; i < 10; i++)
            {
                //names[i] = i.ToString();
                Console.WriteLine(names[i]);
            }

            Console.ReadLine();
        }
    }

    public interface Iindexer
    {
        string this[int index]
        {
            get;
            private set;
        }
    }

    public class IndexName : Iindexer
    {
        private string[] _names = new string[10];

        public IndexName(string[] nameList)
        {
            for (int i = 0; i < nameList.Length; i++)
            {
                _names[i] = nameList[i];
            }
        }

        public string this[int index]
        {
            get
            {
                string tmp;
                if (index >= 0 && index <= 10)
                {
                    tmp = _names[index];
                }
                else
                {
                    tmp = "";
                }

                return tmp;
            }
            private set
            {
                if (index >= 0 && index <= 10)
                {
                    _names[index] = value;
                }
            }
        }
    }
}
