using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Itcaster.Web.BLL;
using Itcaster.Web.Model;

namespace Itcaster.Web
{
    /// <summary>
    /// Summary description for Edit
    /// </summary>
    public class Edit : IHttpHandler
    {
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/html";
            var id = Convert.ToInt32(context.Request.QueryString["id"]);
            var bll = new UserInfoBLL();
            var userInfo = bll.GetEntityModel(id);
            if (userInfo != null)
            {
                var file = context.Request.MapPath("Edit.html");
                var fileContent = System.IO.File.ReadAllText(file);
                fileContent = fileContent.Replace("$txtName", userInfo.UserName).Replace("$txtPwd", userInfo.UserPass).Replace("$txtRegTime", userInfo.RegTime.ToShortDateString()).Replace("$txtEmail", userInfo.Email).Replace("$hidID", userInfo.ID.ToString());

                context.Response.Write(fileContent);
            }
            else
            {
                context.Response.Write("参数异常");
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