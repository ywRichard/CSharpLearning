using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _01_MVCBasic.Controllers
{
    public class HomeController : Controller
    {
        //在MVC中，访问时，实际访问的是某个类的某个方法
        //在asp.net中，访问时实际访问的是某个类
        // GET: Home
        public ActionResult Index()
        {
            //默认不指定显示页面时，会采用与action同名的页面进行显示
            //还可以指定自定义显示页面
            return View("Show");
        }
    }
}