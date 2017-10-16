using _02_MVCFilter.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _02_MVCFilter.Controllers
{
    public class HelloController : Controller
    {
        // GET: Hello
        [MyAction]
        [MyResult]
        public ActionResult Index()
        {
            Response.Write("执行中");
            return View();
        }
    }
}