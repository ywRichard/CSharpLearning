using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Itcaster.Web
{
    /// <summary>
    /// Summary description for Delete
    /// </summary>
    public class Delete : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            var id = Convert.ToInt32(context.Request.QueryString["id"]);
            var bll = new BLL.UserInfoBLL();
            if (bll.DeleteEntityModel(id))
            {
                context.Response.Redirect("UserInfoList.ashx");
            }
            else
            {
                context.Response.Write("删除失败");
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