using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;
using Itcaster.Web.Model;

namespace Itcaster.Web._2017_10_03
{
    /// <summary>
    /// Summary description for _04_CheckUserState
    /// </summary>
    public class _04_CheckUserState : IHttpHandler, IRequiresSessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            var action = context.Request["action"];

            if (action=="check")
            {
                if (context.Session["userInfo"] != null)
                {
                    context.Response.Write("ok:" + ((UserInfo)context.Session["userInfo"]).UserName);
                }
                else
                {
                    context.Response.Write("no");
                }
            }
            else if(action=="login")
            {
                var name = context.Request.Form["name"];
                var pwd = context.Request["pwd"];
                var bll = new BLL.UserInfoBLL();
                var userInfo = new UserInfo();
                var msg = string.Empty;
                if (bll.CheckUserInfo(name,pwd,out msg,out userInfo))
                {
                    context.Session["userInfo"] = userInfo;
                    context.Response.Write("yes:" + userInfo.UserName);
                }
                else
                {
                    context.Response.Write("no:" + msg);
                }
            }
            else if (action=="logout")
            {

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