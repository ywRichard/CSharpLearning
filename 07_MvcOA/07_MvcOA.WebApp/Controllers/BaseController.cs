using _07_MvcOA.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _07_MvcOA.WebApp.Controllers
{
    public class BaseController : Controller
    {
        public UserInfo LoginUser { get; set; }

        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            base.OnActionExecuting(filterContext);

            var flag = false;
            //if (Session["UserInfo"] == null)
            if (Request.Cookies["sessionId"] != null)
            {
                //接受从Cookie中传递过来的Memcache的key
                var sessionId = Request.Cookies["sessionId"].Value;
                //根据key从memcache中获取用户信息
                object obj = Common.MemcachedHelper.Get(sessionId);
                if (obj != null)
                {
                    LoginUser = Common.SerializerHelper.DeserializerToObject<UserInfo>(obj.ToString());
                    flag = true;
                }
            }

            if (!flag)
            {
                 filterContext.HttpContext.Response.Redirect("/Login/Index");
                return;
            }
        }
    }
}