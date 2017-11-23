using _07_MvcOA.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _07_MvcOA.WebApp.Controllers
{
    public class ActionInfoController : Controller
    {
        IBLL.IActionInfoBLL ActionInfoBll { get; set; }
        // GET: ActionInfo
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetActionInfo()
        {
            var pageIndex = Request["page"] != null ? int.Parse(Request["page"]) : 1;
            var pageSize = Request["rows"] != null ? int.Parse(Request["rows"]) : 5;
            var name = Request["name"];
            var remark = Request["remark"];

            var totalCount = 0;
            var delFlag = (short)DelFlagEnum.Normal;
            var actionInfoList = ActionInfoBll.LoadPageEntities(pageIndex, pageSize, out totalCount, a => a.DelFlag == delFlag, a => a.ID, true);
            var temp = actionInfoList.Select(a => new
            {
                ID = a.ID,
                ActionInfoName = a.ActionInfoName,
                Sort = a.Sort,
                Remark = a.Remark,
                Url = a.Url,
                HttpMethod = a.HttpMethod,
                ActionTypeEnum = a.ActionTypeEnum,
                SubTime = a.SubTime
            });

            return Json(new { rows = temp, total = totalCount }, JsonRequestBehavior.AllowGet);
        }
    }
}