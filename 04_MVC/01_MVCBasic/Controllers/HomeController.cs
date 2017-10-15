using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _01_MVCBasic.Models;

namespace _01_MVCBasic.Controllers
{
    public class HomeController : Controller
    {
        //在MVC中，访问时，实际访问的是某个类的某个方法
        //在asp.net中，访问时实际访问的是某个类
        // GET: Home
        public ActionResult Index()
        {
            //默认不指定显示页面时，会采用与action同名的页面进行显示
            //还可以指定自定义显示页面
            return View("Show");
        }

        public ActionResult HtmlTest()
        {
            //页面传值的两种形式，实现相同
            ViewBag.QQ = 345;
            ViewData["Tencent"] = "Tencent";

            //创建一个下拉列表项
            var list = new List<SelectListItem>();//SelectListItem -> HtmlHelper选定，不能更改。
            list.Add(new SelectListItem() { Selected = false, Text = "item1", Value = "123" });
            list.Add(new SelectListItem() { Selected = true, Text = "item2", Value = "456" });
            list.Add(new SelectListItem() { Selected = false, Text = "item3", Value = "789" });
            list.Add(new SelectListItem() { Selected = false, Text = "item4", Value = "QWE" });
            ViewBag.ddlList = list;

            ViewData.Model = new Person("model", 101);
            return View();
        }
    }
}