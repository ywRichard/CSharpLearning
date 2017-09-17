using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Itcaster.Web.BLL;
using Itcaster.Web.Model;

namespace Itcaster.Web.App
{
    /// <summary>
    /// Summary description for ShowDetails
    /// </summary>
    public class ShowDetails : IHttpHandler
    {
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/html";
            var bll = new UserInfoBLL();
            var userInfo = bll.GetEntityModel(Convert.ToInt32(context.Request.QueryString["id"]));
            if (userInfo != null)
            {
                var file = context.Request.MapPath("ShowDetails.html");
                var fileContent = System.IO.File.ReadAllText(file);
                fileContent = fileContent.Replace("$name", userInfo.UserName);
                fileContent = fileContent.Replace("$pwd", userInfo.UserPass);
                context.Response.Write(fileContent);
            }
            else
            {
                context.Response.Write("参数错误");
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