using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _07_MvcOA.BLL;
using _07_MvcOA.IBLL;

namespace _07_MvcOA.WebApp.Controllers
{
    public class UserInfoController : Controller
    {
        // GET: UserInfo
        IUserInfoBLL userInfoBll=new UserInfoBLL();
        public ActionResult Index()
        {
            return View();
        }
    }
}