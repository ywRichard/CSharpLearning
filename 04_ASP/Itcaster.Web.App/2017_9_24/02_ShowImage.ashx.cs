using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Itcaster.Web._2017_9_24
{
    /// <summary>
    /// Summary description for _02_ShowImage
    /// </summary>
    public class _02_ShowImage : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "image/jepg";
            //if (context.Request.UrlReferrer.Host)//判断上一次请求链接的主机地址是不是我的主机地址，如果是则显示本地图片-->防盗链
            //{

            //}
            context.Response.WriteFile(context.Request.MapPath("/ImagePath/3-1.jpg"));
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