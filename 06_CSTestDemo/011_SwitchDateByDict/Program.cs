using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _011_SwitchDateByDict
{
    /// <summary>
    /// 日期转换案例，Dictionary键值对集合的练习
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //用户输入：贰零一二年十月十日，输出2012年10月10日。

            Console.WriteLine("请输入日期：");

            string date = GetDateByString(Console.ReadLine()).ToString();

            Console.WriteLine(date);
            Console.ReadLine();

        }

        private static StringBuilder GetDateByString(string ipDate)
        {
            string str = "0零 1一 2二 3三 4四 5五 6六 7七 8八 9九";
            string[] strArray = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<char, char> dc = new Dictionary<char, char>();

            for (int i = 0; i < strArray.Length; i++)
            {
                dc.Add(strArray[i][1], strArray[i][0]);
            }

            StringBuilder sbDate = new StringBuilder();
            char[] chrDate = ipDate.ToCharArray();

            for (int i = 0; i < chrDate.Length; i++)
            {
                if (chrDate[i]=='十')
                {
                    if (!dc.ContainsKey(chrDate[i-1])&&!dc.ContainsKey(chrDate[i+1]))
                    {
                        sbDate.Append("10");
                    }
                    else if (!dc.ContainsKey(chrDate[i - 1]) && dc.ContainsKey(chrDate[i + 1]))
                    {
                        sbDate.Append("1");
                    }
                    else if (dc.ContainsKey(chrDate[i - 1]) && !dc.ContainsKey(chrDate[i + 1]))
                    {
                        sbDate.Append("0");
                    }
                }
                else if (dc.ContainsKey(chrDate[i]))
                {
                    sbDate.Append(dc[chrDate[i]]);
                }
                else
                {
                    sbDate.Append(chrDate[i]);
                }
            }
            return sbDate;
        }
    }
}
