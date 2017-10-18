using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _05_EFBasic.Controllers
{
    public class CURDController : Controller
    {
        // GET: CURD
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Insert()
        {
            var context = new T1Context();
            context.UserInfoes.Add(new UserInfo
            {
                UserName = "ef",
                UserPass = "123",
                RegTime = DateTime.Now,
                Email = "aa@163.com"
            });
            var result = context.SaveChanges() > 0 ? "Ok" : "NG";

            return Content(result);
        }
    }
}