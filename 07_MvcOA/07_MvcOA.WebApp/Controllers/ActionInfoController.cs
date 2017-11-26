using _07_MvcOA.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;

namespace _07_MvcOA.WebApp.Controllers
{
    public class ActionInfoController : BaseController
    {
        private IBLL.IActionInfoBLL ActionInfoBll { get; set; }
        private IBLL.IRoleInfoBLL RoleInfoBll { get; set; }
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

        // 获取上传的图片
        public ActionResult FileUpload()
        {
            HttpPostedFileBase file = Request.Files["fileIconUp"];
            if (file != null)
            {
                var fileName = Path.GetFileName(file.FileName);
                var fileExt = Path.GetExtension(fileName);
                if (fileExt == ".jpg")
                {
                    var dir = $"/MenuIcon/{DateTime.Now.Year}/{DateTime.Now.Month}/{DateTime.Now.Day}/";
                    Directory.CreateDirectory(Path.GetDirectoryName(Request.MapPath(dir)));
                    var newFileName = Guid.NewGuid().ToString();
                    var fullDir = dir + newFileName + fileExt;
                    file.SaveAs(Request.MapPath(fullDir));

                    return Content("ok:" + fullDir);
                }
                else
                {
                    return Content("no:文件类型错误!");
                }
            }
            else
            {
                return Content("no:请选择上传的图片文件");
            }

        }
        // 完成权限的添加
        public ActionResult AddActionInfo(ActionInfo actionInfo)
        {
            actionInfo.DelFlag = 0;
            actionInfo.ModifiedOn = DateTime.Now; ;
            actionInfo.SubTime = DateTime.Now;
            actionInfo.Url = actionInfo.Url.ToLower();
            var paths = Request.Path.Split('/');
            actionInfo.ControllerName = paths[1];
            actionInfo.ActionMethodName = paths[2];
            actionInfo.IconWidth = 100;
            actionInfo.IconHeight = 100;
            ActionInfoBll.AddEntity(actionInfo);
            return Content("ok");
        }
        //为权限配置角色信息
        public ActionResult SetActionRole()
        {
            var actionId = int.Parse(Request["actionId"]);
            var actionInfo = ActionInfoBll.LoadEntities(a => a.ID == actionId).FirstOrDefault();
            ViewBag.ActionInfo = actionInfo;

            var delFlag = (short)DelFlagEnum.Normal;
            var allRoleList = RoleInfoBll.LoadEntities(a => a.DelFlag == delFlag).ToList();
            var extRoleIdList = (from r in actionInfo.RoleInfo
                                 select r.ID).ToList();
            ViewBag.RoleList = allRoleList;
            ViewBag.RoleIdList = extRoleIdList;

            return View();

        }
        //完成对权限的角色分配
        public ActionResult SetActionRoleInfo()
        {
            var actionId = int.Parse(Request["actionId"]);
            var list = new List<int>();
            var allKeys = Request.Form.AllKeys;//获取所有表单中name的属性值
            foreach (var key in allKeys)
            {
                if (key.StartsWith("cba_"))
                {
                    var str = key.Replace("cba_", "");
                    list.Add(int.Parse(str));
                }
            }
            var result = ActionInfoBll.SetActionRoleInfo(actionId, list)?"ok":"no";

            return Content(result);
        }
    }
}