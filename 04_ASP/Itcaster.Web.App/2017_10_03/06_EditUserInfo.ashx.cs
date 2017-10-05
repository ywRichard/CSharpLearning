using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Itcaster.Web._2017_10_03
{
    /// <summary>
    /// Summary description for _06_EditUserInfo
    /// </summary>
    public class _06_EditUserInfo : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            var userInfo = new Model.UserInfo();
            userInfo.ID = int.Parse(context.Request["txtEditId"]);
            userInfo.UserName = context.Request["txtEditName"];
            userInfo.UserPass = context.Request["txtEditPwd"];
            userInfo.Email = context.Request["txtEditEmail"];
            userInfo.RegTime = Convert.ToDateTime(context.Request["txtEditRegTime"]);
            var bll = new BLL.UserInfoBLL();
            var isSuccess = bll.UpdateEntityModel(userInfo) ? "yes" : "no";
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