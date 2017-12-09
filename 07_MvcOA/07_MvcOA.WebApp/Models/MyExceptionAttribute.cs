
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ServiceStack.Redis;

namespace _07_MvcOA.WebApp.Models
{
    public class MyExceptionAttribute : HandleErrorAttribute
    {
        //.Net的消息队列
        #region 方法一
        public static Queue<Exception> ExceptionQueue = new Queue<Exception>();
        #endregion

        public static IRedisClientsManager clientManager = new PooledRedisClientManager("127.0.0.1:6379");
        public static IRedisClient redisClient = clientManager.GetClient();

        public override void OnException(ExceptionContext filterContext)
        {
            base.OnException(filterContext);
            #region 方法一
            ExceptionQueue.Enqueue(filterContext.Exception); //异常消息 -> 入列
            #endregion
            redisClient.EnqueueItemOnList("errorMsg", filterContext.Exception.ToString());
            filterContext.HttpContext.Response.Redirect("/Error.html");
        }
    }
}