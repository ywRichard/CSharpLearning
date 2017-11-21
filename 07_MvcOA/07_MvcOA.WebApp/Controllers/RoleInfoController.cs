using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _07_MvcOA.IBLL;

namespace _07_MvcOA.WebApp.Controllers
{
    public class RoleInfoController : Controller
    {
        // GET: RoleInfo
        IRoleInfoBLL RoleInfoBll { get; set; }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetRoleInfo()
        {
            return View();
        }

        public ActionResult DeleteRoleInfo()
        {
            return Content();
        }

        public ActionResult AddRoleInfo()
        {
            return Json();
        }

        public ActionResult EditRoleInfo()
        {
            return Content();
        }
    }
}