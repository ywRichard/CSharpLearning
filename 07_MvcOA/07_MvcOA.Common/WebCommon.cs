using Lucene.Net.Analysis;
using Lucene.Net.Analysis.Tokenattributes;
using PanGu;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web;

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

        public static void GoPage()
        {
            HttpContext.Current.Response
                .Redirect("/Login/Index/?returnUrl=" + HttpContext.Current.Request.Url.ToString());
        }
        /// <summary>
        /// 对输入的搜索条件进行分词
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static List<string> GetPanGuWord(string str)
        {
            Analyzer analyzer = new PanGuAnalyzer();

            TokenStream tokenStream = analyzer.TokenStream("", new StringReader(str));

            var list = new List<string>();
            while (tokenStream.IncrementToken())
            {
                var term = tokenStream.GetAttribute<ITermAttribute>();
                list.Add(term.Term);
            }

            return list;
        }

        public static string CreateHighLight(string keywords, string content)
        {
            //创建HTMLFormatter,参数为高亮单词的前后缀
            PanGu.HighLight.SimpleHTMLFormatter simpleHTMLFormatter =
            new PanGu.HighLight.SimpleHTMLFormatter("<font color=\"red\">", "</font>");//同过改变字体颜色，实现高亮显示
            //创建 Highlighter ，输入HTMLFormatter 和 盘古分词对象Semgent
            PanGu.HighLight.Highlighter highlighter = new PanGu.HighLight.Highlighter(simpleHTMLFormatter, new Segment());
            //设置每个摘要段的字符数
            highlighter.FragmentSize = 50;
            //获取最匹配的摘要段
            return highlighter.GetBestFragment(keywords, content);
        }
    }
}
