using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.IO;

namespace _114_EncryptByMD5
{
    /// <summary>
    /// MD5加密：一种加密方式。
    /// 在数据库中保存密码时，需要用加密方法加密，而不是直接保存明文密码。
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //将123用MD5的加密方式
            Console.WriteLine(GetStringMD5("admin"));
            Console.WriteLine(GetFileMD5("ForMD5.txt"));
            Console.ReadKey();
        }

        //输入一个字符串，得到一个字符串
        static string GetStringMD5(string input)
        {
            string result = "";
            byte[] buffer = Encoding.Default.GetBytes(input);
            //MD5 md5 = MD5.Create();
            //md5.ComputeHash();
            MD5 md5 = MD5.Create();
            byte[] md5Buffer = md5.ComputeHash(buffer);

            for (int i = 0; i < md5Buffer.Length; i++)
            {
                result += md5Buffer[i].ToString("x2");
            }

            return result;
        }

        static string GetFileMD5(string path)
        {
            var result = "";
            using (var file = new FileStream(path, FileMode.Open))
            {
                var md5 = new MD5CryptoServiceProvider();
                var bytes = md5.ComputeHash(file);
                for (int i = 0; i < bytes.Length; i++)
                {
                    result += bytes[i].ToString("x2");//输出十六进制
                }
            }

            return result;
        }
    }
}
