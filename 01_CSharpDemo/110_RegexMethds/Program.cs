using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _110_RegexMethds
{
    /// <summary>
    /// replace: $&--表示匹配上的字符串
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //RegexMatch();
            //RegexReplace();
            //RegexSplit();
            //RegexMatchs();
            Groups();
            Console.ReadLine();
        }

        private static void RegexMatchs()
        {
            throw new NotImplementedException();
        }

        private static void RegexIsMatch()
        {

        }

        /// <summary>
        /// 用static方法，Match
        /// </summary>
        private static void RegexMatch()
        {
            string input = "This is jikexueyuan jikexueyuan!";
            string pattern = @"\b(\w+)\W(\1)\b";
            Match match = Regex.Match(input, pattern);//得到当前的匹配项

            while (match.Success)
            {
                Console.WriteLine("Duplication {0} found", match.Groups[1].Value);
                match = match.NextMatch();//从原来的match再执行一次匹配，得到下一个匹配项。
            }
        }

        /// <summary>
        /// 替换匹配字符串
        /// </summary>
        private static void RegexReplace()
        {
            string pattern = @"\b\d+\.\d{2}\b";
            string replacement = "$$$&";//$&--表示匹配上的字符串
            string input = "Total cost: 103.64";
            Console.WriteLine(Regex.Replace(input,pattern,replacement));
        }

        /// <summary>
        /// 分割匹配字符串，
        /// </summary>
        private static void RegexSplit()
        {
            string input = "1. Egg 2. Bread 3. Mike 4. Coffee";
            string pattern = @"\b\d{1,2}\.\s";
            foreach (string item in Regex.Split(input,pattern))
            {
                if (!String.IsNullOrEmpty(item))
                {
                    Console.WriteLine(item);
                }
            }
        }

        /// <summary>
        /// 实例化Regex，再Match
        /// </summary>
        private static void RegexMatches()
        {
            MatchCollection matchs;

            Regex r = new Regex("abc");
            matchs = r.Matches("123abc4abcd");
            foreach (Match item in matchs)
            {
                Console.WriteLine("{0} found at position {1}",item.Value,item.Index);
                Console.WriteLine("{0}",item.Result("$&, hello jikexueyuan"));
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private static void Groups()
        {
            string input = "Born: July 28, 1989";
            string pattern = @"\b(\w+)\s(\d{1,2}),\s(\d{4})\b";

            Match match = Regex.Match(input, pattern);
            if (match.Success)
            {
                for (int i = 0; i < match.Groups.Count; i++)
                {
                    Console.WriteLine("Group{0}: {1}",i,match.Groups[i].Value);
                }
            }
        }
    }
}
