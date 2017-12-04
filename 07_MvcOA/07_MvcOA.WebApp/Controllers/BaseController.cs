using _07_MvcOA.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Spring.Context;
using Spring.Context.Support;
using _07_MvcOA.IBLL;

namespace _07_MvcOA.WebApp.Controllers
{
    public class BaseController : Controller
    {
        public UserInfo LoginUser { get; set; }

        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            base.OnActionExecuting(filterContext);

            var isExt = false;
            //if (Session["UserInfo"] == null)
            if (Request.Cookies["sessionId"] != null)
            {
                //接受从Cookie中传递过来的Memcache的key
                var sessionId = Request.Cookies["sessionId"].Value;
                //根据key从memcache中获取用户信息
                object obj = Common.MemcachedHelper.Get(sessionId);
                if (obj != null)
                {
                    LoginUser = Common.SerializerHelper.DeserializerToObject<UserInfo>(obj.ToString());
                    isExt = true;

                    //隐藏的超级管理员
                    if (LoginUser.UserName == "admin123")
                    {
                        return;
                    }

                    //完成权限过滤
                    var actionUrl = Request.Url.AbsolutePath.ToLower();//请求地址，Url绝对路径: /UserInfo/Login
                    var actionHttpMethod = Request.HttpMethod;//请求方式

                    //用Spring.Net创建对象的另外一种方式，也是读取配置文件中的程序集和命名空间。
                    //在BaseController中，不能添加属性的方式去创建，为什么？
                    IApplicationContext context = ContextRegistry.GetContext();
                    var UserInfoBll = (IUserInfoBLL)context.GetObject("UserInfoBLL");
                    var ActionInfoBll = (IActionInfoBLL)context.GetObject("ActionInfoBLL");
                    var actionInfo = ActionInfoBll
                        .LoadEntities(a => a.Url == actionUrl && a.HttpMethod == actionHttpMethod)
                        .FirstOrDefault();
                    if (actionInfo == null)
                    {
                        Response.Redirect("/Error.Html");
                        return;
                    }

                    //先从 "用户->权限" 进行判断
                    var loginUserInfo = UserInfoBll.LoadEntities(u => u.UserID == LoginUser.UserID).FirstOrDefault();
                    var r_UserInfo_ActionInfo = (from a in loginUserInfo.R_UserInfo_ActionInfo
                                                 where a.ActionInfoID == actionInfo.ID
                                                 select a).FirstOrDefault();
                    if (r_UserInfo_ActionInfo != null)
                    {
                        if (r_UserInfo_ActionInfo.IsPass == true)
                        {
                            return;
                        }
                        else
                        {
                            Response.Redirect("/Error.Html");
                            return;
                        }
                    }
                    //按照 "用户->角色->权限" 进行过滤
                    var loginUserRoleInfo = loginUserInfo.RoleInfo;
                    var loginUserActionCount = (from r in loginUserRoleInfo
                                                from a in r.ActionInfo
                                                where a.ID == actionInfo.ID
                                                select a).Count();
                    if (loginUserActionCount < 1)
                    {
                        Response.Redirect("/Error.Html");
                        return;
                    }
                }
            }

            if (!isExt)
            {
                filterContext.HttpContext.Response.Redirect("/Login/Index");
                return;
            }
        }
    }
}