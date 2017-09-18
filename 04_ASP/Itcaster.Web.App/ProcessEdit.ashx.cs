using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Itcaster.Web
{
    /// <summary>
    /// Summary description for ProcessEdit
    /// </summary>
    public class ProcessEdit : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            var id = Convert.ToInt32(context.Request.Form["hidID"]);
            var bll = new BLL.UserInfoBLL();
            var userInfo = bll.GetEntityModel(id);
            if (userInfo!=null)
            {
                userInfo.UserName = context.Request.Form["txtName"];
                userInfo.UserPass = context.Request.Form["txtPwd"];
                userInfo.Email = context.Request.Form["txtEmail"];
                if (bll.UpdateEntityModel(userInfo))
                {
                    context.Response.Redirect("UserInfoList.ashx");
                }
                else
                {
                    context.Response.Write("修改失败");
                }
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