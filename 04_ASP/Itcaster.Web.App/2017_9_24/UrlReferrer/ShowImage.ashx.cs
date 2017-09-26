using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Itcaster.Web._2017_9_24.UrlReferrer
{
    /// <summary>
    /// ShowImage 的摘要说明
    /// </summary>
    public class ShowImage : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "image/jpeg";
          //  context.Request.UrlReferrer.Host
            context.Response.WriteFile(context.Request.MapPath("/ImagePath/mm.jpg"));
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