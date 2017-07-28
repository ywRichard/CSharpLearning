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

    class Horse:Animal
    {
        protected override sealed void Eat()//子类不能重写该方法
        {
            Console.WriteLine("吃草");
        }
    }

    class BattleHorse: Horse
    {
        //override Eat();不能重写
    }
    #endregion



}
