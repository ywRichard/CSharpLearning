using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Itcaster.Web._2017_10_03
{
    /// <summary>
    /// Summary description for _06_Detail
    /// </summary>
    public class _06_Detail : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            var id = int.Parse(context.Request["id"]);
            var bll = new BLL.UserInfoBLL();
            var userInfo = bll.GetEntityModel(id);
            var js = new System.Web.Script.Serialization.JavaScriptSerializer();
            context.Response.Write(js.Serialize(userInfo));
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