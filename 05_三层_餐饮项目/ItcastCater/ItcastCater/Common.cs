using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ItcastCater
{
    public static class Common
    {
        public static string GetStringMD5(string input)
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
    }
}
