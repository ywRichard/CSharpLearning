using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Itcaster.Web._2017_9_18.aspxCRUD
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
                context.Response.Redirect("index.aspx");
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