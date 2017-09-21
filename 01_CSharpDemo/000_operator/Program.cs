using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _15运算符的学习
{

    class Program
    {
        static void Main(string[] args)
        {
            /// <summary>
            /// 运算符：输出数据的类型由运算成员的类型决定。
            /// 难点自加自减
            /// </summary>
            #region ++ & --
            //Console.WriteLine("请输入一个数字");
            //string strNumber = Console.ReadLine();
            //double number = Convert.ToDouble(strNumber);
            //number = number * 2;
            //Console.WriteLine(number);
            //Console.ReadKey();

            //int a = 5;
            //int b = a++ + ++a * 2 + --a + a++;
            ////      5+7*2+6+6=31
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            #endregion

            #region << & >>
            //int i = 3;
            //int lg = 5;

            //Console.WriteLine("0x{0:x}", i << 2);//0x4
            //Console.WriteLine("0x{0:d}", Convert.ToString((i << 2),2));

            //Console.WriteLine("0x{0:x}", Convert.ToString((i << 31),2));
            //Console.WriteLine("0x{0:x}", Convert.ToString((lg << 2), 2));
            #endregion

            #region operator overloading
            //AddClass1 ac1 = new AddClass1 { val = 2 };
            //AddClass1 ac2 = new AddClass1 { val = 3 };
            //AddClass1 ac3 = new AddClass1();

            //ac3 = ac1 + ac2;
            //Console.WriteLine(ac3.val);
            #endregion

            #region overloading mixed type
            //AddClass1 para1 = new AddClass1 { val = 5 };
            //AddClass2 para2 = new AddClass2 { val = 8 };
            //AddClass3 result = para1 + para2;

            //Console.WriteLine(result.val);
            #endregion

            #region 加法变减法
            //AddClass1 para4 = new AddClass1 { val = 6 };
            //AddClass3 para5 = new AddClass3 { val = 2 };

            //AddClass2 result2 = para4 + para5;
            //Console.WriteLine(result2.val);
            #endregion

            #region ?

            var p = new Person();
            if (p.Name == "name")
            {
                p = null;
            }

            string str = p?.Name;
            if (str == "Name")
            {
                
            }
            Console.WriteLine(str);


            #endregion

        }
    }

    #region overloading
    /// <summary>
    /// 运算符overloading
    /// </summary>
    public class AddClass1
    {
        public int val;

        public static AddClass1 operator +(AddClass1 opr1, AddClass1 opr2)
        {
            AddClass1 returnVal = new AddClass1();
            returnVal.val = opr1.val + opr2.val;

            return returnVal;
        }

        /// <summary>
        /// 混合类型顺序要一直
        /// </summary>
        public static AddClass3 operator +(AddClass1 opr1, AddClass2 opr2)
        {
            AddClass3 returnVal = new AddClass3();
            returnVal.val = opr1.val + opr2.val;

            return returnVal;
        }

        public static AddClass2 operator +(AddClass1 opr1, AddClass3 opr2)
        {
            AddClass2 result = new AddClass2();
            result.val = opr1.val - opr2.val;

            return result;
        }
    }

    public class AddClass2
    {
        public int val;
    }

    public class AddClass3
    {
        public int val;
    }
    #endregion

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person()
        {
            Name = "name";
        }
    }
}
