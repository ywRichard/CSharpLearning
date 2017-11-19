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
        private IUserInfoBLL UserInfoBll { get; set; }
        // GET: Login
        public ActionResult Index()
        {
            CheckCookieInfo();
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
            var userInfo = UserInfoBll.LoadEntities(u => u.UserName == userName && u.UserPwd == userPwd)
                .FirstOrDefault();
            if (userInfo != null)
            {
                //共享session数据，只能应用于部署单台服务器。
                //Session["UserInfo"] = userInfo;

                //使用Memcache代替Session解决数据在不同web服务器之间共享的问题
                var sessionId = Guid.NewGuid().ToString();
                //memcached储存对象需要序列化
                //Common.MemcachedHelper.Set(sessionId, userInfo, DateTime.Now.AddMinutes(20));
                Common.MemcachedHelper.Set(
                    sessionId,
                    Common.SerializerHelper.SerializerToString(userInfo),
                    DateTime.Now.AddMinutes(20)
                    );
                //将Memcache的key以cookie的形式返回到浏览器端的内存中，当用户再次请求其他的页面，请求报文中会以Cookie将该值再次发送服务端。
                Response.Cookies["sessionId"].Value = sessionId;

                //记住我
                if (!string.IsNullOrEmpty(Request["checkMe"]))
                {
                    HttpCookie cookie1 = new HttpCookie("cp1", userInfo.UserName);
                    HttpCookie cookie2 = new HttpCookie("cp2",
                        WebCommon.GetMd5String(WebCommon.GetMd5String(userInfo.UserPwd)));
                    cookie1.Expires = DateTime.Now.AddDays(3);
                    cookie2.Expires = DateTime.Now.AddDays(3);
                    Response.Cookies.Add(cookie1);
                    Response.Cookies.Add(cookie2);
                }

                return Content("ok:登陆成功");
            }
            else
            {
                return Content("no:用户名或者密码错误");
            }
        }
        /// <summary>
        /// 判断Cookie信息
        /// </summary>
        private void CheckCookieInfo()
        {
            if (Request.Cookies["cp1"] != null && Request.Cookies["cp2"] != null)
            {
                var userName = Request.Cookies["cp1"].Value;
                var userPwd = Request.Cookies["cp2"].Value;
                //判断cookie中储存的用户密码和用户名是否正确
                var userInfo = UserInfoBll.LoadEntities(u => u.UserName == userName)
                    .FirstOrDefault();
                if (userInfo != null)
                {
                    //注意：用户密码一定要加密以后保存到数据库
                    if (WebCommon.GetMd5String(WebCommon.GetMd5String(userInfo.UserPwd)) == userPwd)
                    {
                        var sessionId = Guid.NewGuid().ToString();
                        MemcachedHelper.Set(sessionId,
                            SerializerHelper.SerializerToString(userInfo),
                            DateTime.Now.AddMinutes(20));
                        Response.Cookies["sessionId"].Value = sessionId;

                        Response.Redirect("/Home/Index");
                    }
                }
            }

            //删除Cookies
            Response.Cookies["cp1"].Expires = DateTime.Now.AddDays(-1);
            Response.Cookies["cp2"].Expires = DateTime.Now.AddDays(-1);
        }
    }
}