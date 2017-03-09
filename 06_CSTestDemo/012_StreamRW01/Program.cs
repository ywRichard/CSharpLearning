using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace _012_FileByStreamRW01
{
    /// <summary>
    /// StreamReader & StreamWriter 练习
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            #region read File
            //string path = "1.txt";
            //string txtStr = "";

            //using (StreamReader sr=new StreamReader(path,Encoding.Default))
            //{
            //    while (!(txtStr == null))
            //    {
            //        txtStr = sr.ReadLine();
            //        Console.WriteLine(txtStr);
            //    }
            //}
            #endregion

            string path = "1.txt";

            using (StreamWriter sw = new StreamWriter(path, true, Encoding.Default))
            {
                sw.Write("单反穷三代，DATA毁一生");
            }

            Console.WriteLine("写入成功");

            Console.ReadLine();
        }
    }
}
