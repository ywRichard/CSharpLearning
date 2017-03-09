using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _000_EscapeCharacter
{
    /// <summary>
    /// 转义符概念：指的是一个'\'+特殊的字符，组成的 一个具有特殊意义的字符
    /// </summary>
    #region 转义符知识点
    //1、输出英文半角双引号“”。要用\“\”
    //2、\r\n：windows中的换行，不认识\n只认识\r\n。Mac OSX 换行\n
    //3、\\：表示一个\
    //4、\n：换行
    //5、\t：表示tab键
    //6、\b：表示Space，退格键
    //7、@作用：1、取消字符串中的转义作用string  path =  @"C:\USER\Desktop\1111/txt";
    //            2、将字符串按照原格式输出
    #endregion
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("你是\n大爷");
            //Console.ReadKey();
            //Console.WriteLine("输出英文\\n\"\"半角");
            //Console.ReadKey();
            //Console.WriteLine(@"Hello World");
            //Console.ReadKey();
            //String path = @"C:\Users\Richard\Desktop\重要文件";
            //Console.WriteLine(path);
            //Console.ReadKey();
        }
    }
}
