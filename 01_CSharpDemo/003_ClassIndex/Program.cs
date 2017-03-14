using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _003_ClassIndex
{
    class Program
    {
        static void Main(string[] args)
        {
            #region //Once
            //IndexNames names = new IndexNames();

            //for (int i = 0; i < 10; i++)
            //{
            //    names[i] = string.Format("Steven{0}", i);
            //}

            //for (int i = 0; i < 12; i++)
            //{
            //    Console.WriteLine(names[i]);
            //}
            //Console.ReadLine();
            #endregion

            IndexNames names = new IndexNames();

            for (int i = 0; i < 10; i++)
            {
                names[i] = string.Format("Jobs{0}", i);
                Console.WriteLine(names[i]);
            }

            Console.WriteLine(names["Jobs1"]);
            Console.WriteLine(names["Jobs5"]);
            Console.WriteLine(names["Jobs11"]);

            Console.ReadLine();
        }
    }

    /// <summary>
    /// Once
    /// </summary>
    //class IndexNames
    //{
    //    private string[] nameList = new string[10];

    //    public IndexNames()
    //    {
    //        for (int i = 0; i < nameList.Length; i++)
    //        {
    //            nameList[i] = "N/A";
    //        }
    //    }

    //    public string this[int index]
    //    {
    //        get
    //        {
    //            string tmp;

    //            if (index>=0&&index<=nameList.Length-1)
    //            {
    //                tmp = nameList[index];
    //            }
    //            else
    //            {
    //                tmp = "....";
    //            }

    //            return tmp;
    //        }
    //        set
    //        {
    //            if (index>=0&&index<=nameList.Length-1)
    //            {
    //                nameList[index] = value;
    //            }
    //        }
    //    }
    //}

    class IndexNames
    {
        private string[] nameList = new string[10];

        public IndexNames()
        {
            for (int i = 0; i < nameList.Length; i++)
            {
                nameList[i] = "N/A";
            }
        }

        public string this[int index]//
        {
            get
            {
                string tmp;
                if (index >= 0 && index <= 10)
                {
                    tmp = nameList[index];
                }
                else
                {
                    tmp = "...";
                }

                return tmp;
            }

            //private set
            set
            {
                if (index >= 0 && index <= 10)
                {
                    nameList[index] = value;
                }
            }
        }      
        //overload indexer
        public int this[string name]
        {
            get 
            {
                int index = 0;
                while (index<nameList.Length)
                {
                    if (nameList[index] == name)
                    {
                        return index;
                    }

                    index++;
                }

                return -1;
            }
        }
    }
}
