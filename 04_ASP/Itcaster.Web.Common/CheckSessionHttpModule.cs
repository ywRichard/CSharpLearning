using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Itcaster.Web.Common
{
    class CheckSessionHttpModule : IHttpModule
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Init(HttpApplication context)
        {
            context.AcquireRequestState += Context_AcquireRequestState;
        }

        private void Context_AcquireRequestState(object sender, EventArgs e)
        {
            var application = (HttpApplication)sender;
            var context = application.Context;
            var filePath = context.Request.Url.ToString();//响应报文头第一行就是页面路径
            if (filePath.Contains("Admin"))
            {
                if (context.Session["userInfo"] == null)
                {
                    context.Response.Redirect("/2017_10_06/05_Login.aspx");
                }
            }
        }
    }
}
