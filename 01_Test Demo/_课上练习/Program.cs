using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _课上练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //课上练习1：接收用户输入的字符串，将其中的字符以与输入相反的顺序输出。"abc"→"cba"
            #region 课上练习1
            //Console.WriteLine("请输入字符串");
            //string str = Console.ReadLine();

            //char[] newChar = str.ToCharArray();

            //for (int i = 0; i < newChar.Length / 2; i++)
            //{
            //    if (newChar.Length - i != 0)
            //    {
            //        char temp;
            //        temp = newChar[i];
            //        newChar[i] = newChar[newChar.Length - i - 1];
            //        newChar[newChar.Length - i - 1] = temp;
            //    }
            //}

            //string newString = new string(newChar);

            //Console.WriteLine(newString);
            //Console.ReadKey(); 
            #endregion

            //课上练习2：接收用户输入的一句英文，将其中的单词以反序输出。"hello c sharp"→"sharp c hello"
            #region 课上练习2
            //Console.WriteLine("请输入英文字符串");
            //string str = Console.ReadLine();

            //char[] chs = { ' ' };
            //string[] newString = str.Split(chs);

            //for (int i = 0; i < newString.Length / 2; i++)
            //{
            //    if (newString.Length - i != 0)
            //    {
            //        string temp;
            //        temp = newString[i];
            //        newString[i] = newString[newString.Length - 1 - i];
            //        newString[newString.Length - 1 - i] = temp;
            //    }
            //}

            //string strResult = String.Join(" ", newString);

            //Console.WriteLine(strResult);
            //Console.ReadKey(); 
            #endregion

            //课上练习3：从Email中提取出用户名和域名：abc@163.com。
            #region 课上练习3
            //Console.WriteLine("请输入E-Mail");
            //string strEmail = Console.ReadLine();

            //if (true == strEmail.Contains('@'))
            //{
            //    //int index = strEmail.IndexOf('@');
            //    //string name = strEmail.Substring(0, index);
            //    //string domainName = strEmail.Substring(index);

            //    string[] name = strEmail.Split(new char[] { '@' });
            //    Console.WriteLine(name[0]);
            //    Console.WriteLine("@"+name[1]);
            //}
            //else
            //{
            //    Console.WriteLine("输入的E-Mail格式不正确");
            //}
            //Console.ReadKey(); 
            #endregion

            //让用户输入一句话,找出所有e的位置
            #region MyRegion
            //Console.WriteLine("输入字符串");
            //string str = Console.ReadLine();
            //int index =0;

            //if (str.Contains('e'))
            //{
            //    while (true)
            //    {
            //        index = str.IndexOf('e',index+1);
            //        if (-1 == index)
            //        {
            //            break;
            //        }
            //        else
            //        {
            //            Console.WriteLine("e的位置{0}", index);
            //        }
            //    }

            //}
            //else
            //{
            //    Console.WriteLine("输入的字符中没有e");
            //}
            //Console.ReadKey();     
            #endregion

            //让用户输入一句话,判断这句话中有没有邪恶,如果有邪恶就替换成这种形式然后输出,如:老牛很邪恶,输出后变成老牛很**;
            #region MyRegion
            //Console.WriteLine("输入字符串");
            //string str = Console.ReadLine();
            //string newStr = str.Replace("邪恶", "xx");
            //Console.WriteLine(newStr);
            //Console.ReadKey(); 
            #endregion

            //把{“诸葛亮”,”鸟叔”,”卡卡西”,”卡哇伊”}变成诸葛亮|鸟叔|卡卡西|卡哇伊,然后再把|切割掉
            string[] str = {"诸葛亮","鸟叔","卡卡西","卡哇伊"};
            string newStr = "";
            for (int i = 0; i < str.Length; i++)
            {
                newStr += str[i]+"|";
            }
            Console.WriteLine(newStr);

            string[] chs = newStr.Split(new char[] {'|'});
            newStr = "";
            for (int i = 0; i < chs.Length; i++)
            {
                newStr += chs[i];
            }
            Console.WriteLine(newStr);
            Console.ReadKey();
        }
    }
}
