using _05_EFBasic.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _05_EFBasic.Controllers
{
    public class CRUDController : Controller
    {
        DbContext context = new MyContext();
        // GET: CRUD
        public ActionResult Index()
        {
            var list = context.Set<UserInfo>().Select(u => u);
            return View(list);
        }

        public ActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Insert(UserInfo userInfo)
        {
            context.Set<UserInfo>().Add(userInfo);
            //将内存中发生变化的数据映射到数据库中
            var result = context.SaveChanges();
            if (result>0)
            {
                return Redirect(Url.Action("Index","CRUD"));
            }
            else
            {
                return Redirect(Url.Action("Add"));
            }
        }

        public ActionResult Edit(int id)
        {
            ViewData.Model = context.Set<UserInfo>()
                .Where(u => u.ID == id).FirstOrDefault();
            return View();
        }

        [HttpPost]
        public ActionResult Edit(UserInfo userInfo)
        {
            context.Set<UserInfo>().AddOrUpdate(userInfo);
            var result = context.SaveChanges();

            if (result>0)
            {
                return Redirect(Url.Action("Index"));
            }
            else
            {
                return Redirect(Url.Action("Edit", new { id = userInfo.ID }));
            }
        }

        public ActionResult Delete(int id)
        {
            var userInfo = context.Set<UserInfo>()
                .Where(u => u.ID == id)
                .FirstOrDefault();
            context.Set<UserInfo>().Remove(userInfo);
            context.SaveChanges();

            return Redirect(Url.Action("Index"));
        }
    }
}