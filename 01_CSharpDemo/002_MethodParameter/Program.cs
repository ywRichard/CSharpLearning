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
            
        }

        /// <summary>
        /// 比较字符串的长度
        /// </summary>
        /// <param name="index">最长的字符串的长度</param>
        /// <param name="str">字符串数组</param>
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
            return "我是你儿子"+base.Who();//base指向父类实例
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
}
