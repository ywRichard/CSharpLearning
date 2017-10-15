using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _01_MVCBasic.Controllers
{
    public class _04AjaxController : Controller
    {
        // GET: _04Ajax
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CalcAdd(int calc1, int calc2)
        {
            //返回纯文本
            return Content((calc1 + calc2).ToString());
        }
        
        public ActionResult CalcAdd1(int calc1,int calc2)
        {
            var sum = calc1 + calc2;
            var temp = new
            {
                Sum = sum
            };
            //返回object
            return Json(temp, JsonRequestBehavior.AllowGet);
        }
    }
}