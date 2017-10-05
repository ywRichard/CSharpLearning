using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Itcaster.Web.BLL;

namespace Itcaster.Web._2017_10_03
{
    /// <summary>
    /// Summary description for _03_CheckUserName
    /// </summary>
    public class _03_CheckUserName : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            var name = context.Request.Form["name"];
            var bll = new UserInfoBLL();
            var userInfo = bll.GetEntityModel(name);
            if (userInfo != null)
            {
                context.Response.Write("用户名已经占用！！");
            }
            else
            {
                context.Response.Write("用户名可用！！");
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