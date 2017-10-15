using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _01_MVCBasic.Controllers
{
    public class NewController : Controller
    {
        // GET: New
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Show(int id,int year)
        {
            ViewBag.Id = id;
            return View();
        }
    }
}