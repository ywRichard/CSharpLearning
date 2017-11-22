using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _07_MvcOA.IBLL;
using _07_MvcOA.Model;

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
            var pageIndex = Request["page"] != null ? int.Parse(Request["page"]) : 1;
            var pageSize = Request["rows"] != null ? int.Parse(Request["rows"]) : 5;
            var name = Request["name"];
            var remark = Request["remark"];
            //构建搜索条件
            var totalCount = 0;
            var delFlag = (short)DelFlagEnum.Normal;
            var roleInfoList = RoleInfoBll.LoadPageEntities(pageIndex, pageSize, out totalCount, r => r.DelFlag == delFlag, r => r.ID, true);
            var temp = from r in roleInfoList
                       select new
                       {
                           ID = r.ID,
                           RoleName = r.RoleName,
                           Sort = r.Sort,
                           SubTime = r.SubTime,
                           Remark = r.Remark
                       };

            return Json(new { rows = temp, total = totalCount }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult DeleteRoleInfo()
        {
            var strId = Request["strId"];
            var strIds = strId.Split(',');
            var list = new List<int>();
            foreach (var id in strIds)
            {
                list.Add(int.Parse(id));
            }
            var result = RoleInfoBll.DeleteEntities(list) ? "ok" : "no";

            return Content(result);
        }

        public ActionResult AddRoleInfo(RoleInfo roleInfo)
        {
            roleInfo.SubTime = DateTime.Now;
            roleInfo.ModifiedOn = DateTime.Now;
            roleInfo.DelFlag = 0;
            RoleInfoBll.AddEntity(roleInfo);
            return Content("ok");
        }

        public ActionResult EditRoleInfo(RoleInfo roleInfo)
        {
            roleInfo.ModifiedOn = DateTime.Now;
            var result = RoleInfoBll.EditEntity(roleInfo) ? "ok" : "no";
            return Content(result);
        }

        public ActionResult GetRoleInfoModel()
        {
            var id = int.Parse(Request["id"]);
            var roleInfo = RoleInfoBll.LoadEntities(r => r.ID == id).FirstOrDefault();
            if (roleInfo != null)
            {
                return Json(new { serverData = roleInfo, msg = "ok" }, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new { msg = "no" }, JsonRequestBehavior.AllowGet);
            }
        }

        public ActionResult ShowEditInfo()
        {
            var id = int.Parse(Request["id"]);
            var roleInfo = RoleInfoBll.LoadEntities(r => r.ID == id).FirstOrDefault();
            ViewData.Model=roleInfo;

            return View();
        }
    }
}