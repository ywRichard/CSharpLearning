using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Itcaster.Web._2017_10_03
{
    /// <summary>
    /// Summary description for _06_AddUserInfo
    /// </summary>
    public class _06_AddUserInfo : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            var userInfo = new Model.UserInfo();
            userInfo.UserName = context.Request["txtName"];
            userInfo.UserPass = context.Request["txtPwd"];
            userInfo.Email = context.Request["txtEmail"];
            userInfo.RegTime = DateTime.Now;
            var bll = new BLL.UserInfoBLL();
            var isSuccess = bll.InsertEntityModel(userInfo) ? "ok" : "no";
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