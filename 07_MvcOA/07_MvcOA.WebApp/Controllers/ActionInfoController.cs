using _07_MvcOA.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _07_MvcOA.WebApp.Controllers
{
    public class ActionInfoController : BaseController
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

        public ActionResult DeleteActionInfo()
        {
            var actionId = int.Parse(Request["actionId"]);

            var actionInfo = ActionInfoBll.LoadEntities(a => a.ID == actionId).FirstOrDefault();
            if (ActionInfoBll.DeleteEntity(actionInfo))
            {
                return Content("ok");
            }
            else
            {
                return Content("no");
            }
        }

        public ActionResult DeleteActionInfoList()
        {
            var strId = Request["strId"];
            var strIds = strId.Split(',');
            var listId = new List<int>();
            foreach (var id in strIds)
            {
                listId.Add(int.Parse(id));
            }
            if (ActionInfoBll.DeleteEntities(listId))
                return Content("ok");
            else
                return Content("no");
        }

        public ActionResult EditInfo(ActionInfo actionInfo)
        {
            actionInfo.ModifiedOn = DateTime.Now;
            var result = ActionInfoBll.EditEntity(actionInfo) ? "ok" : "no";
            return Content(result);
        }

        public ActionResult ShowEditInfo()
        {
            var id = int.Parse(Request["id"]);
            var actionInfo = ActionInfoBll.LoadEntities(a => a.ID == id).FirstOrDefault();
            ViewData.Model = actionInfo;

            return View();
        }
    }
}