using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Itcaster.Web._2017_10_03
{
    /// <summary>
    /// Summary description for _02_GetDate
    /// </summary>
    public class _02_GetDate : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.Write(DateTime.Now.ToShortTimeString());
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