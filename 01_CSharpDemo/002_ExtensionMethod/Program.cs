using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionLib;

namespace _002_ExtensionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            #region ExtensionLib的例子
            //Console.WriteLine("Enter a string to convert:");
            //var sourceString = Console.ReadLine();

            //Console.WriteLine("String with title casing: {0}",
            //    sourceString.GetWords(capitalizeWords: true).AsSentence());
            //Console.WriteLine("String backwards: {0}",
            //    sourceString.GetWords(reverseOrder: true,
            //                        reverseWords: true).AsSentence());
            //Console.WriteLine("String length backwards: {0}",
            //    sourceString.Length.ToStringReversed());

            //Console.ReadKey();
            #endregion

            #region ExtensionDemo
            var money = 10;
            var result1 = money.FakeResult();
            Console.WriteLine(result1);

            var result2 = money.FakeResult(true);
            Console.WriteLine(result2);
            Console.WriteLine((2).FakeResult(doIt: true));

            var salary = 100;
            Console.WriteLine(salary.PayCheck(true));
            #endregion
        }
    }

    public static class ExtensionDemo
    {
        public static int FakeResult(this int source, bool doIt = false)
        {
            if (doIt)
            {
                return source * 2;
            }

            return source - 1;
        }

        public static string PayCheck(this int source,bool right=false)
        {
            if (right)
                return string.Format("This is you salary. Total: {0}", source);
            else
                return "You can't get your money any more.";
        }
    }
}
