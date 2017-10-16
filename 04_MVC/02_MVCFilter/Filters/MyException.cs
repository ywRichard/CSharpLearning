using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _02_MVCFilter.Filters
{
    public class MyException : HandleErrorAttribute
    {
        public override void OnException(ExceptionContext filterContext)
        {
            //父类实现不能删除，否则捕获不到异常
            base.OnException(filterContext);

            //记录日志

            //页面跳转
            filterContext.Result = new RedirectResult("/Errors/400.html");
        }
    }
}