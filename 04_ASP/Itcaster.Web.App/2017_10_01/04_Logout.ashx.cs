using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Itcaster.Web._2017_10_01
{
    /// <summary>
    /// Summary description for _04_Logout
    /// </summary>
    public class _04_Logout : IHttpHandler, System.Web.SessionState.IRequiresSessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            if (context.Session["userInfo"] != null)
            {
                context.Session["userInfo"] = null;
                context.Response.Cookies["cp1"].Expires = DateTime.Now.AddDays(-1);
                context.Response.Cookies["cp2"].Expires = DateTime.Now.AddDays(-1);
                context.Response.Redirect("01_Login.aspx");
            }
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