using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _07_MvcOA.Common
{
    public class WebCommon
    {
        /// <summary>
        /// 对字符串进行MD5加密
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string GetMd5String(string str)
        {
            var md5 = MD5.Create();
            var buffers = Encoding.UTF8.GetBytes(str);
            var md5Buffers = md5.ComputeHash(buffers);
            var sb = new StringBuilder();
            foreach (var b in md5Buffers)
            {
                sb.Append(b.ToString("x2"));
            }
            md5.Clear();
            return sb.ToString();
        }
    }
}
