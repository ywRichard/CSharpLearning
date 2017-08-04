using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_MethodParameter
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 可选参数
            //CaptilizationPara cp = new CaptilizationPara();
            //cp.GetValue("hello", true);
            #endregion



        }

        #region ref, out & params       
        /* 
         * ref和out：
         * 1、传递的是变量在栈上的值。
         * 2、实现方法的多个返回值。
         */
        /// <summary>
        /// out -> 使方法可以返回多个不同类型的值
        /// 参数要求在方法内部必须为其赋值
        /// </summary>
        public static bool MyTryParse(string input, out int number)
        {
            try
            {
                number = Convert.ToInt32(input);
                return true;
            }
            catch
            {
                number = 0;
                return false;
            }
        }

        /// <summary>
        /// ref -> 能够将一个变量带入一个方法中进行改变 ，改变完成后在将变量返回到方法中。
        /// 要求：在方法外必须被赋值，在方法内可以不用赋值。
        /// </summary>
        public static void Exchange(ref int n1, ref int n2)
        {
            int temp = 0;
            temp = n1;
            n1 = n2;
            n2 = temp;
        }

        /// <summary>
        /// params -> 将实参列表中跟可变参数数组类型一致的元素都当做数组的元素去处理。
        /// 只允许有一个params参数,且必须在形参列表的最后一个。
        /// </summary>
        public static int ArraySum(params int[] number)
        {
            int sum = 0;
            for (int i = 0; i < number.Length; i++)
            {
                sum += number[i];
            }
            return sum;
        }

        /// <summary>
        /// out & params参数
        /// </summary>
        public static void JudgeLength(out int index, params string[] str)
        {
            //int index = -1;
            index = 0;
            int max = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (max < str[i].Length)
                {
                    index = i;
                }
            }
        }
        #endregion
    }

    #region 重写virtual
    internal class Animal
    {
        protected virtual void Eat()
        {

        }
    }

    class Horse : Animal
    {
        protected override sealed void Eat()//子类不能重写该方法
        {
            Console.WriteLine("吃草");
        }
    }

    class BattleHorse : Horse
    {
        //override Eat();不能重写
    }
    #endregion

    #region 隐藏类成员 -> 父类成员被隐藏后，无法使用里氏转换通过父类调用子类的成员。
    class Parent
    {
        public string Who()
        {
            return "我是你爹";
        }
    }

    class Son : Parent
    {
        //new可以显示的声明隐藏父类成员，如果不用会有警告
        new public string Who()
        {
            return "我是你儿子" + base.Who();//base指向父类实例
        }
    }
    #endregion

    #region 虚拟类成员 -> 里氏转换，父类可以调用子类的成员实现。
    //class Parent
    //{
    //    protected virtual string Who()
    //    {
    //        return "我是你爹";
    //    }
    //}

    //class Son : Parent
    //{
    //    //new可以显示的声明隐藏父类成员，如果不用会有警告
    //    protected override string Who()
    //    {
    //        return "我是你儿子";
    //    }

    //    public string You()
    //    {
    //        return Who();
    //    }
    //}
    #endregion

    #region 可选参数
    class CaptilizationPara
    {
        public void GetValue(string message, bool option = false)
        {
            if (option)
            {
                Console.WriteLine(message);
            }
            else
            {
                Console.WriteLine("option=false");
            }
        }
    }
    #endregion
}
