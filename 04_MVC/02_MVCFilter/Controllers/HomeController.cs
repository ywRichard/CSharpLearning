using _02_MVCFilter.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _02_MVCFilter.Controllers
{
    //[MyAuthorization]//当前控制器下的所有行为，都被应用了这个过滤器
    public class HomeController : Controller
    {
        // GET: Home
        //实现过滤的两种，方法(特性)1、自定义过滤类继承自（Authorization）,再用特性的方式。添加全局过滤也调用了自定义的特性类
        //[MyAuthorization]//当前行为在执行前，会执行身份验证过滤器
        public ActionResult Index()
        {
            //throw new Exception("抛个异常");
            return View();
        }

        public ActionResult Show()
        {
            return View();
        }

        //方法(重写)2、直接重写Controller的方法，这样会应用于所有的行为
        protected override void OnAuthorization(AuthorizationContext filterContext)
        {

        }
    }
}