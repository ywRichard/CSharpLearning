using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _00_HomeworkDemo.Areas._01AJAX.Controllers
{
    public class AjaxController : Controller
    {
        // GET: _01AJAX/Ajax
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Add(int a1, int a2)
        {
            return Content((a1 + a2).ToString());
        }

        public ActionResult AddObj(int a1, int a2)
        {
            var obj = new
            {
                Sum = a1 + a2
            };

            return Json(obj, JsonRequestBehavior.AllowGet);
        }
    }
}