using _07_EFCodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _07_EFCodeFirst.Controllers
{
    public class ArticleTypeController : Controller
    {
        DbContext context = new MyContext();
        // GET: BookType1
        public ActionResult Index()
        {
            //当操作的表存在时，则不进行创建如果不存在，则创建
            var result = context.Database.CreateIfNotExists() ? "Create Ok" : "Create NG";

            result += "---" + (context.SaveChanges() > 0 ? "Save Ok" : "Save NG");

            ViewBag.result = result;
            return View();
        }
    }
}