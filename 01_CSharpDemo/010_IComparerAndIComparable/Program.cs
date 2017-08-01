using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _010_IComparerAndIComparable
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 实现IComparable
            string firstString = "First String";
            string secondString = "Second String";

            Console.WriteLine("Comparing '{0}' and '{1}', result: {2}", firstString, secondString,
                Comparer.Default.Compare(firstString, secondString));

            int firstNum = 10;
            int secondNum = 12;
            Console.WriteLine("Comparing '{0}' and '{1}', result: {2}", firstNum, secondNum,
                Comparer.Default.Compare(firstNum, secondNum));
            #endregion

            #region 实现IComparer
            ArrayList list = new ArrayList();
            list.Add(new Person("Jim", 30));
            list.Add(new Person("Bob", 25));
            list.Add(new Person("Bert", 27));
            list.Add(new Person("Ernie", 22));

            Console.WriteLine("Unsorted people:");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine("{0} {1}",
                    (list[i] as Person).Name, (list[i] as Person).Age);
            }
            Console.WriteLine();

            Console.WriteLine("Sorted with default comparer by Age:");
            //Sort为什么会调用CompareTo?
            list.Sort();
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine("{0} {1}",
                    (list[i] as Person).Name, (list[i] as Person).Age);
            }
            Console.WriteLine();

            Console.WriteLine("Sorted with non-Default comparer (by name):");
            list.Sort(ComparePersonByName.Default);
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine("{0} {1}",
                    (list[i] as Person).Name, (list[i] as Person).Age);
            }
            Console.WriteLine();
            #endregion

            //比较字符串-根据系统的语言设置处理不同语言的字符串
            //Comparer com = new Comparer(System.Globalization.CultureInfo.CurrentCulture);
        }
    }

    /// <summary>
    /// 实现IComparable
    /// </summary>
    class Person : IComparable
    {
        public int Age { get; set; }
        public string Name { get; set; }

        public Person(string name, int age)
        {
            Age = age;
            Name = name;
        }

        public int CompareTo(object obj)
        {
            return Age.CompareTo(((Person)obj).Age);
        }
    }

    /// <summary>
    /// 实现IComparer
    /// </summary>
    class ComparePersonByName : IComparer
    {
        public static IComparer Default = new ComparePersonByName();

        public int Compare(object x, object y)
        {
            if (x is Person && y is Person)
            {
                return Comparer.Default.Compare(
                    ((Person)x).Name, ((Person)y).Name);
            }
            else
            {
                throw new ArgumentException("One or both objects to compare are not Person objects.");
            }
        }
    }
}
