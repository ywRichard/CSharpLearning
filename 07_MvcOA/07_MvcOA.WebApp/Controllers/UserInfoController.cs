using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _07_MvcOA.BLL;
using _07_MvcOA.IBLL;
using _07_MvcOA.Model;

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
        /// <summary>
        /// 获取用户信息
        /// </summary>
        /// <returns></returns>
        public ActionResult GetUserInfo()
        {
            var pageIndex = Request["page"] != null ? int.Parse(Request["page"]) : 1;
            var pageSize = Request["rows"] != null ? int.Parse(Request["rows"]) : 5;
            int totalCount;
            short delFlag = (short)DelFlagEnum.Normal;
            var userInfoList = userInfoBll.LoadPageEntities(pageIndex, pageSize, out totalCount,
                c => c.DelFlag == delFlag,
                c => c.UserID, true);
            var temp = userInfoList.Select(u => new
            {
                ID = u.UserID,
                UserName = u.UserName,
                UserPass = u.UserPwd,
                Remark = u.Remark,
                RegTime = u.SubTime,
            });

            return Json(new {
                rows = temp, total = totalCount },
                JsonRequestBehavior.AllowGet
                );
        }
        /// <summary>
        /// 删除用户信息
        /// </summary>
        /// <returns></returns>
        public ActionResult DeleteUserInfo()
        {
            string strId = Request["strId"];
            var strIds = strId.Split(',');
            var list = new List<int>();
            foreach (var id in strIds)
            {
                list.Add(int.Parse(id));
            }

            if (userInfoBll.DeleteEntities(list))
            {
                return Content("ok");
            }
            else
            {
                return Content("no");
            }
        }

        public ActionResult AddUserInfo(UserInfo userInfo)
        {
            userInfo.DelFlag = 0;
            userInfo.SubTime = DateTime.Now;
            userInfo.ModifiedOn = DateTime.Now;
            userInfoBll.AddEntity(userInfo);
            
            return Json("ok");
        }

        public ActionResult GetUserInfoModel()
        {
            int id = int.Parse(Request["id"]);
            var userInfo = userInfoBll.LoadEntities(c => c.UserID == id).FirstOrDefault();

            if (userInfo!=null)
                return Json(new { serverData=userInfo,msg="ok"},JsonRequestBehavior.AllowGet);
            else
                return Json(new { msg = "no" }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult EditUserInfo(UserInfo userInfo)
        {
            userInfo.ModifiedOn = DateTime.Now;
            if(userInfoBll.EditEntity(userInfo))
            {
                return Content("ok");
            }
            else
            {
                return Content("no");
            }
        }
    }
}