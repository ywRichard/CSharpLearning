using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace _01_MVCBasic
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //自定义路由规则的要求：小范围(子频道)写在前，大范围(主频道)写在后
            //服务器自上而下的匹配路由规则
            //2014-1-1-1
            routes.MapRoute(
                name: "NewsShow",
                url: "{year}-{month}-{day}-{id}",
                defaults: new
                {
                    controller = "New",
                    action = "Show"
                },
                constraints: new
                {
                    year = "^\\d{4}$",
                    month = "^\\d{1,2}$",
                    day = "^\\d{1,2}$"
                }
                );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "HtmlTest", id = UrlParameter.Optional }
            );
        }
    }
}
