using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _07_MvcOA.WebApp.Controllers
{
    public class ConcurrenceTestController : Controller
    {
        // GET: ConcurrenceTest
        public ActionResult Index()
        {
            var a = 2;
            var b = 0;
            var result = a / b;
            return Content(result.ToString());
        }
    }
}