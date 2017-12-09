using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using log4net;
using log4net.Core;
using Spring.Web.Mvc;
using _07_MvcOA.WebApp.Models;

namespace _07_MvcOA.WebApp
{
    public class MvcApplication : SpringMvcApplication//System.Web.HttpApplication
    {
        /// <summary>
        /// 在第一次启动WebApp时会调用这个方法，注册各种配置和规则。
        /// 相当于程序的入口
        /// </summary>
        protected void Application_Start()
        {
            //程序一运行，就开启线程扫描队列将数据取出来写到Lucene.Net中
            SearchIndexManager.GetInstance().StartThread();

            //读取log4Net的配置信息
            log4net.Config.XmlConfigurator.Configure();

            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            //在WebApi开始运行的时候，在线程池中加载一个线程操作队列
            var fileLogPath = Server.MapPath("/Log/");
            //新开一个线程去轮询消息队列，如果有异常消息，则取出执行。
            //用CLR维护的线程池里的线程性能更好
            //WaitCallback
            ThreadPool.QueueUserWorkItem((a) =>
            {
                //必须死循环，否则执行后线程释放
                while (true)
                {
                    //if (MyExceptionAttribute.ExceptionQueue.Count > 0)
                    //{
                    //    //异常消息->出列，FIFO；
                    //    var ex = MyExceptionAttribute.ExceptionQueue.Dequeue();
                    //    //自定义 Log
                    //    //var fileName = DateTime.Now.ToString("yyyy-M-d") + ".txt";
                    //    //File.AppendAllText(fileLogPath + fileName, ex.ToString(), Encoding.Default);

                    //    //log4net
                    //    var logger = LogManager.GetLogger("errorMsg");
                    //    logger.Error(ex.ToString());
                    //}
                    if (MyExceptionAttribute.redisClient.GetListCount("errorMsg") > 0)
                    {
                        var ex = MyExceptionAttribute.redisClient.DequeueItemFromList("errorMsg");
                        var logger = LogManager.GetLogger("errorMsg");
                        logger.Error(ex);
                    }
                    else
                    {
                        //线程休息，节约CPU开销
                        Thread.Sleep(3000);
                    }
                }
            }, fileLogPath);
        }
    }
}
