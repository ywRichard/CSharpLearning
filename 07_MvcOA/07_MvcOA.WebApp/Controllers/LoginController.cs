using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _07_MvcOA.Common;
using _07_MvcOA.IBLL;

namespace _07_MvcOA.WebApp.Controllers
{
    public class LoginController : Controller
    {
        private IUserInfoBLL userInfoBll { get; set; }
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// 生成验证码
        /// </summary>
        /// <returns></returns>
        public ActionResult ShowValidateCode()
        {
            var validateCode = new ValidateCode();
            var code = validateCode.CreateValidateCode(4);
            Session["ValidateCode"] = code;
            var buffer = validateCode.CreateValidateGraphic(code);
            return File(buffer, "image/jpeg");
        }

        /// <summary>
        /// 登陆验证
        /// </summary>
        /// <returns></returns>
        public ActionResult CheckLogin()
        {
            //1、判断验证码是否正确
            var validateCode = Session["ValidateCode"]?.ToString();
            if (string.IsNullOrEmpty(validateCode))
                return Content("no:验证码错误!!");

            Session["ValidateCode"] = null;
            var txtCode = Request["vCode"];
            if (!validateCode.Equals(txtCode, StringComparison.InvariantCultureIgnoreCase))
                return Content("no:验证码错误!!");

            //2、判断用户输入的用户名和密码
            var userName = Request["LoginCode"];
            var userPwd = Request["LoginPwd"];
            var userInfo = userInfoBll.LoadEntities(u => u.UserName == userName && u.UserPwd == userPwd)
                .FirstOrDefault();
            if (userInfo != null)
            {
                Session["UserInfo"] = userInfo;
                return Content("ok:登陆成功");
            }
            else
            {
                return Content("no:用户名或者密码错误");
            }
        }
    }
}