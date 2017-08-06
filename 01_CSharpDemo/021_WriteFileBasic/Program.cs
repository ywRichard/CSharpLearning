using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _013_WriteFileBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            #region FileStream
            //byte[] byData;
            //char[] charData;

            //try
            //{
            //    FileStream aFile = new FileStream("Temp.txt", FileMode.Create);
            //    charData = "My pink half of the drainpipe.".ToCharArray();
            //    byData = new byte[charData.Length];
            //    Encoder e = Encoding.UTF8.GetEncoder();
            //    e.GetBytes(charData, 0, charData.Length, byData, 0, true);

            //    aFile.Seek(0, SeekOrigin.Begin);
            //    aFile.Write(byData, 0, byData.Length);
            //}
            //catch (IOException e)
            //{
            //    Console.WriteLine("An IO Exception has been thrown!");
            //    Console.WriteLine(e.ToString());
            //    Console.ReadKey();
            //    return;
            //}
            #endregion

            #region StreamWriter
            try
            {
                FileStream fs = new FileStream("Log.txt", FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);

                sw.WriteLine("What's up man.");
                sw.WriteLine("It's now {0} and things are looking good", DateTime.Now.ToLongDateString());
                sw.Write("More than that.");
                sw.Write("it's {0} that c# is fun.", true);
                sw.Close();
            }
            catch (IOException e)
            {
                Console.WriteLine("An IO Exception has been thrown.");
                Console.WriteLine(e.ToString());
                Console.ReadLine();
                return;
            }
            #endregion
        }
    }
}
