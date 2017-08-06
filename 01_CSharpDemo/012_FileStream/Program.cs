using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace _012_FileStream
{
    /// <summary>
    /// 文件流读写的操作步骤
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            #region FileStream_Read
            ////使用FileStream来读取文件
            //FileStream fsRead = new FileStream(@"C:\Users\Richard\Desktop\Older.txt", FileMode.OpenOrCreate, FileAccess.Read);
            ////读取字节
            //byte[] buffer = new byte[1024 * 1024 * 5];
            //int r = fsRead.Read(buffer, 0, buffer.Length);
            ////字节转换成字符串
            //string str = Encoding.UTF8.GetString(buffer, 0, r);
            ////关闭文件流
            //fsRead.Close();
            ////释放资源
            //fsRead.Dispose(); 
            #endregion

            //FileStream fsWrite = new FileStream(@"C:\Users\Richard\Desktop\Older.txt", FileMode.OpenOrCreate, FileAccess.Write);
            //string str = "红缎带军团";
            //byte[] buffer = Encoding.UTF8.GetBytes(str);
            //fsWrite.Write(buffer, 0, buffer.Length);

            //fsWrite.Close();
            //fsWrite.Dispose();

            #region FileStream Write using
            //using (FileStream fsWrite = new FileStream(@"C:\Users\Richard\Desktop\Older.txt", FileMode.OpenOrCreate, FileAccess.Write))
            //{
            //    string str ="我又要把你覆盖掉了，哈哈哈！";
            //    byte[] buffer=Encoding.UTF8.GetBytes(str);
            //    fsWrite.Write(buffer,0,buffer.Length);
            //} 
            #endregion

            //using (FileStream fsWrite = new FileStream(@"C:\Users\Richard\Desktop\Older.txt", FileMode.OpenOrCreate, FileAccess.Write))
            //{
            //    string str = "我有来覆盖你了呵呵呵呵额尔qqqqqqqqqq";
            //    byte[] buffer = Encoding.UTF8.GetBytes(str);
            //    fsWrite.Write(buffer, 0, buffer.Length);
            //}
            //Console.WriteLine("OK");
            //Console.ReadKey();
        }
    }
}
