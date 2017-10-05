using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Itcaster.Web._2017_10_03
{
    /// <summary>
    /// Summary description for _05_GetJson
    /// </summary>
    public class _05_GetJson : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            //context.Response.Write("{\"name\":\"zhangshan\",\"Age\":\"22\"}");
            context.Response.Write("{\"Name\":\"zhangsan\",\"Age\":\"22\"}");
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