using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Itcaster.Web._2017_9_24
{
    /// <summary>
    /// Summary description for _02_UrlReferrer1
    /// </summary>
    public class _02_UrlReferrer1 : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/html";
            context.Response.Write(context.Request.UrlReferrer.ToString());
            context.Response.Write("<hr/>");
            context.Response.Write(context.Request.Url.ToString());
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