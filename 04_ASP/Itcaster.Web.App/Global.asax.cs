using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace Itcaster.Web
{
    public class Global : System.Web.HttpApplication
    {
        /// <summary>
        /// 网站应用程序的入口--->Main();
        /// 在网站第一次启动的执行，并且只执行一次。
        /// </summary>
        protected void Application_Start(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 开启回话时执行该方法
        /// </summary>
        protected void Session_Start(object sender, EventArgs e)
        {
            //在线人数统计
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 捕获异常，写日志
        /// </summary>
        protected void Application_Error(object sender, EventArgs e)
        {
            var ex = HttpContext.Current.Server.GetLastError();
            ex.ToString();
        }

        /// <summary>
        /// 过期时间
        /// 例如20分钟不刷新，视为过期，回话结束
        /// </summary>
        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}