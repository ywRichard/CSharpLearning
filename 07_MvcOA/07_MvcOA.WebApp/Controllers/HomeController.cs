using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _07_MvcOA.WebApp.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            if (LoginUser!=null)
            {
                ViewData["UserName"] = LoginUser.UserName;
            }
            return View();
        }

        public ActionResult HomePage()
        {
            if (LoginUser != null)
            {
                ViewData["UserName"] = LoginUser.UserName;
            }
            return View();
        }
    }
}