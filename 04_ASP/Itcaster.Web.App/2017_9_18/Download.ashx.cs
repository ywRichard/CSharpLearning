using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Itcaster.Web._2017_9_18
{
    /// <summary>
    /// Summary description for Download
    /// </summary>
    public class Download : IHttpHandler
    {
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            var encodeFileName = HttpUtility.UrlEncode("111.txt");//解决中文名乱码问题
            //设置响应报文头，告诉浏览器是一个附件需要下载
            context.Response.AddHeader("Content-Disposition", string.Format("attachment;filename=\"{0}\"", encodeFileName));
            context.Response.WriteFile(encodeFileName);//从本地磁盘读取文件，下载           
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}