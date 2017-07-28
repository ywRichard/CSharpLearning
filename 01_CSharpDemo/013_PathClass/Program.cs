using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace _013_PathClass
{
    /// <summary>
    /// Path类型：操作文件路径
        #region 常用方法
        //Path.GetFileName：获得文件名
        //Path.GetFileNameWithoutExtension：获得无扩展名的文件名
        //Path.GetExtension：扩展名
        //Path.GetDirectoryName：文件夹名称
        //Path.GetFullPath：全路径
        //Path.GetPathRoot：跟路径
    #endregion
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            #region Path类的用法
            //string path = @"C:\Users\Richard\Desktop\Older.txt";            
            ////获得文件名
            //Console.WriteLine(Path.GetFileName(path));
            ////不包含扩展名的文件名
            //Console.WriteLine(Path.GetFileNameWithoutExtension(path));
            ////获得文件的扩展名。
            //Console.WriteLine(Path.GetExtension(path));
            ////获得文件所在的文件夹的名称
            //Console.WriteLine(Path.GetDirectoryName(path));
            ////获得文件所在的全路径
            //Console.WriteLine(Path.GetFullPath(path));
            ////获取根目录
            //Console.WriteLine(Path.GetPathRoot(path));

            //Console.ReadKey(); 
            #endregion

            #region 文件类的用法
            ////创建一个文件
            ////File.Create(@"C:\Users\Richard\Desktop\Older.txt");       
            ////写入文本
            //string path = @"C:\Users\Richard\Desktop\Older.txt";

            ////File.AppendAllLines(path, IEnumerable<path> "哈哈哈", Encoding.UTF8);
            ////File.AppendAllText(path, "哈哈");
            ////复制文件
            ////File.Copy(path, @"C:\Users\Richard\Desktop\Older1.txt");
            ////删除文件
            ////File.Delete(@"C:\Users\Richard\Desktop\Older1.txt");
            ////剪切文件
            ////File.Move(path, @"C:\Users\Richard\Desktop\备份\Older.txt"); 
            #endregion
        }
    }
}
