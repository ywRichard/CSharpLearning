using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Itcaster.Web.Model;
using Itcaster.Web.BLL;
using System.Text;
using System.IO;

namespace Itcaster.Web.App
{
    /// <summary>
    /// Summary description for UserInfoList
    /// </summary>
    public class UserInfoList : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/html";
            var bll = new UserInfoBLL();
            var list = bll.GetEntityList();
            var sb = new StringBuilder();

            if (list.Count > 0)
            {
                foreach (UserInfo userInfo in list)
                {
                    sb.AppendFormat("<tr><td>{0}</td><td>{1}</td><td>{2}</td><td>{3}</td><td>{4}</td><td><a href='ShowDetails.ashx?id={0}'>详细</a></td></tr>", userInfo.ID,userInfo.UserName,userInfo.UserPass,userInfo.RegTime.ToShortDateString(),userInfo.Email);
                }
            }

            var file = context.Request.MapPath("UserInfoList.html");
            var fileContent = File.ReadAllText(file);
            fileContent = fileContent.Replace("$tbody", sb.ToString());
            context.Response.Write(fileContent);
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