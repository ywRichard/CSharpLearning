using _07_MvcOA.IBLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _07_MvcOA.Model;

namespace _07_MvcOA.WebApp.Controllers
{
    public class HomeController : BaseController
    {
        IUserInfoBLL UserInfoBll { get; set; }
        public ActionResult Index()
        {
            if (LoginUser != null)
            {
                ViewData["UserName"] = LoginUser.UserName;
            }
            return View();
        }

        public ActionResult HomePage()
        {
            if (LoginUser != null)
            {
                ViewData["UserName"] = LoginUser.UserName;
            }
            return View();
        }
        /// <summary>
        ///  
        /// </summary>
        /// <returns></returns>
        public ActionResult GetMenus()
        {
            //1:根据用户-角色-权限，将登陆用户具有的菜单权限查询出来放在一个集合中
            var loginUserInfo = UserInfoBll.LoadEntities(u => u.UserID == LoginUser.UserID).FirstOrDefault();
            var loginUserRoleInfo = loginUserInfo.RoleInfo;//获取登录用户的角色信息
            var actionTypeEnum = (short)MenuActionTypeEnum.Menu;//菜单权限
            //查询出角色对应的菜单权限
            var loginUserActionInfos = (from r in loginUserRoleInfo
                                        from a in r.ActionInfo
                                        where a.ActionTypeEnum == actionTypeEnum
                                        select a).ToList();
            //2:根据用户-权限，获取菜单权限
            var r_userInfo_actionInfo = (from r in loginUserInfo.R_UserInfo_ActionInfo
                                         select r.ActionInfo).ToList();//根据登陆用户查询“R_UserInfo_ActionInfo”中间表，然后在导航属性查询权限表
            //判断是否是菜单权限
            var loginUserMenuAction = (from r in r_userInfo_actionInfo
                                       where r.ActionTypeEnum == actionTypeEnum
                                       select r).ToList();
            //将储存登陆用户权限的两个集合合并
            loginUserActionInfos.AddRange(loginUserMenuAction);
            //查询登陆用户禁止的权限ID
            var loginForbActionInfo = (from r in loginUserInfo.R_UserInfo_ActionInfo
                                       where r.IsPass == false
                                       select r.ActionInfoID).ToList();
            //将禁止的权限从集合中过滤掉+去重复
            var loginUserAllowActionList = loginUserActionInfos
                .Where(a => !loginForbActionInfo.Contains(a.ID))
                .Distinct(new ActionComparer()).ToList();
            var returnAtionList = from a in loginUserAllowActionList
                                  select new
                                  {
                                      icon = a.MenuIcon,
                                      title = a.ActionInfoName,
                                      url = a.Url
                                  };
            return Json(returnAtionList, JsonRequestBehavior.AllowGet);
        }
    }
}