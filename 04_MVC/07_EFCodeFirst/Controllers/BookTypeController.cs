using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using _07_EFCodeFirst.Models;

namespace _07_EFCodeFirst.Controllers
{
    public class BookTypeController : Controller
    {
        DbContext context = new MyContext();
        // GET: BookType
        public ActionResult Index()
        {
            //如果存在则不创建数据库，
            //var result = context.Database.CreateIfNotExists() ? "Create OK" : "Create NG";
            //result += " --- " + (context.SaveChanges() > 0 ? "Save OK" : "Save NG");
            //ViewBag.result = result;

            var bookTypes = context.Set<BookType1>();
            ViewData.Model = bookTypes;

            return View();
        }

        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(BookType1 bookType)
        {
            context.Set<BookType1>().Add(bookType);
            context.SaveChanges();

            return Redirect(Url.Action("Index", "BookType"));
        }
    }
}