using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _02_MVCFilter.Filters
{
    public class MyAuthorization : AuthorizeAttribute
    {
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            //filterContext.HttpContext

            //如果希望跳转到另一个页面，需要使用Result，而不是使用Response.Redirect()，后者不会让服务器停止执行
            //filterContext.Result=new RedirectResult(UrlHelper.GenerateUrl("","Login","UserInfo",""))

            //获取路由数据，当前上下文匹配到路由规则后，得到的一个对象
            //filterContext.RouteData;

            //获取上下文对象
            filterContext.HttpContext.Response.Write("123");
        }
    }
}