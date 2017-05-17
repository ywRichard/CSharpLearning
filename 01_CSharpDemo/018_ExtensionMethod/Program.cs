using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _018_ExtensionMethod
{
    /// <summary>
    /// 类的扩展方法，可以在不改变类结构的情况下，新增方法。
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            #region DemoLinq
            //int[] ins = { 10, 2, 23, 4, 5, 18, 12 };
            //var result = ins.OrderBy(c => c);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.ToString());
            //}        
            #endregion

            #region StringExtension
            //string str = "This is jikexueyuan C# jikexueyuan";
            //int t = str.WordCount();
            //Console.WriteLine(t);
            #endregion

            #region EnumExtension
            Grades[] grades = { Grades.A, Grades.C, Grades.D };

            EnumExtension.PassValue = Grades.B;
            for (int i = 0; i < grades.Length; i++)
            {
                Console.WriteLine("{0} {1} passed", grades[i].ToString(), grades[i].Passed() ? "is" : "is not");
            }
            #endregion

            Console.ReadLine();
        }
    }

    public static class StringExtension
    {
        public static int WordCount(this string str)//关键词this, 指定了WordCount为string的扩展方法（指定为那个类的扩展方法）
        {
            return str.Split(new char[] { ' ', '.', '!', '?' }, StringSplitOptions.None).Length;
        }
    }

    public enum Grades {A,B,C,D};    

    public static class EnumExtension
    {
        public static Grades PassValue = Grades.D;

        public static bool Passed(this Grades grade)
        {
            return grade >= PassValue;
        }
    }
}
