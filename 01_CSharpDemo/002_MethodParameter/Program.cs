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

            #region 可选参数 & 命名参数
            string sentence = "twas brillig, and the slithy toves did gyre" + "and simple in the wabe:";
            List<string> words;

            words = WordProcessor.GetWords(sentence);
            Console.WriteLine("Original sentence:");
            foreach (var word in words)
            {
                Console.WriteLine(word);
                Console.WriteLine(' ');
            }
            Console.WriteLine('\n');

            //命名参数的指定方式
            words = WordProcessor.GetWords(
                sentence,
                reverseWords: true,
                capitalizeWords: true);
            Console.WriteLine("Capitalized sentence with reversed words:");

            foreach (var word in words)
            {
                Console.Write(word);
                Console.Write(' ');
            }

            Console.ReadKey();
            #endregion

        }
    }

    #region 可选参数
    class CapitalizationPara
    {
        public void GetValue(string message, bool option = false)
        {
            if (option)
            {
                Console.WriteLine(message.ToUpper());
            }
            else
            {
                Console.WriteLine("option=false");
            }
        }
    }
    #endregion
}
