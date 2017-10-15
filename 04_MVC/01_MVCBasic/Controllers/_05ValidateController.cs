using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _01_MVCBasic.Controllers
{
    /// <summary>
    /// 校验，添加三个脚本
    /// 1.jquery
    /// 2.jquery.validate
    /// 3.jquery.validate.unobtrusive
    /// </summary>
    public class _05ValidateController : Controller
    {
        // GET: _05Validate
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Add()
        {

            return View();
        }
    }
}