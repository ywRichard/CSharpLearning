using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _07_MvcOA.WebApp.Models
{
    public class MyExceptionAttribute : HandleErrorAttribute
    {
        //.Net的消息队列
        public static Queue<Exception> ExceptionQueue = new Queue<Exception>();

        public override void OnException(ExceptionContext filterContext)
        {
            base.OnException(filterContext);
            ExceptionQueue.Enqueue(filterContext.Exception); //异常消息 -> 入列
            filterContext.HttpContext.Response.Redirect("/Error.html");
        }
    }
}