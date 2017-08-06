using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _021_delegateBasic
{
    class Program
    {
        #region internal delegate
        public delegate int MyDel(int num1, int num2);

        public static int Show(MyDel mdl, int n1, int n2)
        {
            return mdl(n1, n2);
        }

        public static int Add(int n1, int n2)
        {
            return n1 + n2;
        }
        #endregion

        static void Main(string[] args)
        {
            #region internal method delegate
            //int sum = Show(Add, 2, 3);
            //Console.WriteLine(sum);
            //Console.ReadLine();
            #endregion

            #region Student class
            //Student stu = new Student();
            //stu.DoSth(Show);
            //Console.ReadLine();
            #endregion

            #region ChangeString class
            //string[] names = { "qwe", "asd", "zxc", "fgh" };

            //ChangeString cs = new ChangeString();
            //cs.ChangeStr(names, AddDrama);

            //for (int i = 0; i < names.Length; i++)
            //{
            //    Console.WriteLine(names[i]);
            //}
            //Console.ReadLine();
            #endregion

            #region 多播委托
            //MultipleDel md = M1;
            //md += M2;
            //md += M3;
            //md += M4;
            //md -= M2;
            ////Delegate.Combine();
            //md();//多播委托，可进行简单迭代

            //Console.ReadLine();
            #endregion

            #region 通过多播委托实现回调函数
            //Employee em = new Employee();
            //Robot r = new Robot();
            //Leader ld = new Leader();
            //Boss bs = new Boss();

            //r.NoticeOther += ld.GetTheNotice;
            //r.NoticeOther += bs.GetTheNotice;

            //em.DoSth("my laundry");

            //r.NoticeOther();

            //Console.ReadLine();
            #endregion

        }

        /// <summary>
        /// For Student
        /// </summary>
        public static void Show()
        {
            Console.WriteLine("哈哈，终于明白委托是干嘛的了");
        }

        #region For ChangeString
        public static string ToUpper(string str)
        {
            return str = str.ToUpper();
        }

        public static string AddDrama(string str)
        {
            return str = "+++" + str + "---";
        }
        #endregion

        #region 多播委托
        public delegate void MultipleDel();
        public static void M1()
        {
            Console.WriteLine("1");
        }

        public static void M2()
        {
            Console.WriteLine("2");
        }

        public static void M3()
        {
            Console.WriteLine("3");
        }

        public static void M4()
        {
            Console.WriteLine("4");
        }
        #endregion

        #region 回调函数
        public delegate void NoticeList();
        public class Employee
        {
            public void DoSth(string work)
            {
                Console.WriteLine("I'm doing {0}", work);
            }
        }

        public class Robot
        {
            public NoticeList NoticeOther;

            public void DoneSth()
            {
                Console.WriteLine("He has finished his work!");
                if (NoticeOther != null)
                {
                    NoticeOther();
                }
            }
        }

        public class Leader
        {
            public void GetTheNotice()
            {
                Console.WriteLine("I see!");
            }
        }

        public class Boss
        {
            public void GetTheNotice()
            {
                Console.WriteLine("Well done!");
            }
        }
        #endregion
    }
}
