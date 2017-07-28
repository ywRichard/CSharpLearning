using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace _005_Path
{
    /// <summary>
    /// Path对路径的基本方法
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\S2I\Desktop\Victor's S2I\06_Convert Objects\Primitive Objects\Image\VJD_Image.vxml";

            string fileName = Path.GetFileNameWithoutExtension(path);
            string dir = Path.GetDirectoryName(path);
            string newPath = Path.Combine(dir, fileName,"111.jpg");

            Console.WriteLine(newPath);
            Console.ReadLine();
        }
    }
}
