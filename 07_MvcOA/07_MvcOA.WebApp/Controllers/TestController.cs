using _07_MvcOA.WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _07_MvcOA.WebApp.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult TestAddQueue()
        {
            Model.Book model = new Model.Book();
            model.AuthorDescription = "adsfad";
            model.Author = "老赵";
            model.CategoryId = 1;
            model.Clicks = 1;
            model.ContentDescription = "Asp.Net MVC高级编程";
            model.EditorComment = "adfasdf";
            model.ISBN = "984598234";
            model.PublishDate = DateTime.Now;
            model.PublisherId = 72;
            model.TOC = "aaaaaaa";
            model.UnitPrice = 22.3m;
            model.WordsCount = 1234;

            //先将数据储存到数据库中
            //然后再向队列中添加
            SearchIndexManager.GetInstance().AddQueue("2323", model.Title, model.ContentDescription);

            return Content("ok");
        }
    }
}