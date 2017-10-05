using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Itcaster.Web._2017_10_03
{
    /// <summary>
    /// Summary description for _06_DeleteUserInfo
    /// </summary>
    public class _06_DeleteUserInfo : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            var id = int.Parse(context.Request["id"]);
            var bll = new BLL.UserInfoBLL();
            var isSuccess = bll.DeleteEntityModel(id) ? "yes" : "no";
            context.Response.Write(isSuccess);
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