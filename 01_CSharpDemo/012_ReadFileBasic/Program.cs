using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace _012_ReadFileBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            #region FileStream
            //byte[] byData = new byte[200];
            //char[] charData = new char[200];

            //try
            //{
            //    //"../"向上一层目录
            //    FileStream aFile = new FileStream("../../Program.cs", FileMode.Open);
            //    aFile.Seek(113, SeekOrigin.Begin);
            //    aFile.Read(byData, 0, 200);
            //}
            //catch (IOException e)
            //{
            //    Console.WriteLine("An IO exception has been thrown!");
            //    Console.WriteLine(e.ToString());
            //    Console.ReadKey();
            //}

            //Decoder d = Encoding.UTF8.GetDecoder();
            //d.GetChars(byData, 0, byData.Length, charData, 0);

            //Console.WriteLine(charData);
            //Console.ReadKey();
            #endregion

            #region StreamReader，读取文件的不同方法
            try
            {
                //using -> 当代码执行完后，自动释放内存。
                //Close()->释放资源，让垃圾回收释放内存
                //Dispose() -> 手动释放内存
                //using (FileStream fs = new FileStream("Log.txt", FileMode.Open))
                //{
                //    string line;
                //    StreamReader sr = new StreamReader(fs);

                //    /*************读取字符串的不同方法*************/
                //    //ReadLine读取字符串
                //    //line = sr.ReadLine();
                //    //while (line != null)
                //    //{
                //    //    Console.WriteLine(line);
                //    //    line = sr.ReadLine();
                //    //}

                //    ////Read -> 返回ASCII整数值
                //    //int nChar;
                //    //nChar = sr.Read();
                //    //while (nChar != -1)
                //    //{
                //    //    Console.Write(Convert.ToChar(nChar));
                //    //    nChar = sr.Read();
                //    //}

                //    //ReadToEnd适用小文件 -> 将数据全部读入内存
                //    //Console.WriteLine(sr.ReadToEnd());            
                //}

                //处理大文件 -> 静态方法 ReadLines()
                foreach (var line in File.ReadLines("Log.txt"))
                {
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An io exception has been thrown!");
                Console.WriteLine(e.ToString());
                return;
            }
            #endregion
        }
    }
}
