using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charper6_Iterator
{
    /// <summary>
    /// 迭代器实现文件读取
    /// </summary>
    class LineReader
    {
        public static IEnumerable<string> ReadLines(string fileName)
        {
            using (TextReader reader = File.OpenText(fileName))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    yield return line;
                }
            }
        }

        #region 更加通用的文件迭代块

        //static IEnumerable<string> ReadLines(Func<TextReader> provider)
        //{
        //    using (TextReader reader = provider())
        //    {
        //        string line;
        //        while ((line = reader.ReadLine()) != null)
        //        {
        //            yield return line;
        //        }
        //    }
        //}

        //static IEnumerable<string> ReadLines(string fileName)
        //{
        //    return ReadLines(fileName, Encoding.UTF8);
        //}

        //static IEnumerable<string> ReadLines(string fileName, Encoding encoding)
        //{
        //    //return ReadLines(() => File.OpenText(fileName, Encoding.UTF8));
        //    return null;
        //}

        #endregion
    }
}
