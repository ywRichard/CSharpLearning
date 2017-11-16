using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;
using _07_MvcOA.WebApp.Models;

namespace _07_MvcOA.WebApp
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            //filters.Add(new HandleErrorAttribute());
            //注册自定义全局异常处理程序
            filters.Add(new MyExceptionAttribute());
        }
    }
}
