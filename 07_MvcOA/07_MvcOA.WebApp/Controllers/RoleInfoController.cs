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

        //public ActionResult DeleteRoleInfo()
        //{
        //    return Content();
        //}

        //public ActionResult AddRoleInfo()
        //{
        //    return Json();
        //}

        //public ActionResult EditRoleInfo()
        //{
        //    return Content();
        //}
    }
}