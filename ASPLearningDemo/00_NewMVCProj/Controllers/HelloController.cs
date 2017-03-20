using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _00_NewMVCProj.Controllers
{
    public class HelloController : Controller
    {
        //
        // GET: /Hello/
        public ActionResult Index()
        {
            return View();
        }
        //public string Index()
        //{
        //    return "Hello Controller";
        //}

        /// <summary>
        /// 无参函数
        /// </summary>
        /// <returns></returns>
        //public string Welcome()
        //{
        //    return "Welcome!";
        //}

        public string Welcome(string name = "China")
        {
            return "Welcome" + Server.HtmlEncode(name);
            //return "Welcome" + HttpUtility.HtmlEncode(name);
        }
	}
}