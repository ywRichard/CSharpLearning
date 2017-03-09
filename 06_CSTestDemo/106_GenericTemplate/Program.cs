using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _106_GenericTemplate
{
    class Program
    {
        static void Main(string[] args)
        {
            #region One time
            //MyGenericArray<int> ga = new MyGenericArray<int>(5);
            //for (int i = 0; i < 5; i++)
            //{
            //    ga.SetItem(i, i * 3);
            //}

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(ga.GetItem(i));
            //}

            //Console.ReadLine();
            #endregion

            MyGenericArray<int> ga = new MyGenericArray<int>(5);

            for (int i = 0; i < 5; i++)
            {
                ga.SetItem(i, i * 8);
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(ga.GetItem(i));
            }

            MyGenericArray<char> ac = new MyGenericArray<char>(5);
            for (int i = 0; i < 5; i++)
            {
                ac.SetItem(i, (char)(i + 97));
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(ac.GetItem(i));
            }

            Console.ReadLine();
        }
    }

    /// <summary>
    /// One Time
    /// </summary>
    /// <typeparam name="T"></typeparam>
    //public class MyGenericArray<T>
    //{
    //    private T[] array;

    //    public MyGenericArray(int size)
    //    {
    //        array = new T[size + 1];
    //    }

    //    public T GetItem(int index)
    //    {
    //        return array[index];
    //    }

    //    public void SetItem(int index, T value)
    //    {
    //        array[index] = value;
    //    }
    //}

    /// <summary>
    /// Generic Programme
    /// </summary>
    /// <typeparam name="T">Data Type</typeparam>
    public class MyGenericArray<T>
    {
        private T[] array;

        public MyGenericArray(int size)
        {
            array = new T[size];
        }

        public T GetItem(int index)
        {
            return array[index];
        }

        public void SetItem(int index, T value)
        {
            array[index] = value;
        }
    }

    /// <summary>
    /// Multiple Generic Programme
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="K"></typeparam>
    public class MultiGeneric<T, K> where T:struct//T can't be the type of reference, e.g. string
    {

    }

    /// <summary>
    /// The subclass's type is limited by int
    /// </summary>
    public class SubGenerate : MyGenericArray<int>
    {

    }

    /// <summary>
    /// The subclass is still a generic template
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class SubGenerate<T> : MyGenericArray<T> where T: class
    {

    }

}
