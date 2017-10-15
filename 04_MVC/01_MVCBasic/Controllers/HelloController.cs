using _01_MVCBasic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _01_MVCBasic.Controllers
{
    public class HelloController : Controller
    {
        // GET: Hello
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ContentTest()
        {
            return Content("Hello Content Test");
        }

        public ActionResult RedirectTest()
        {
            //return Redirect("/home/Index");
            return Redirect(Url.Action("Index", "Home"));
        }

        public ActionResult JsonTest()
        {
            var p = new Person("zhangsan", 20);
            return Json(p, JsonRequestBehavior.AllowGet);
        }

        //方式一：Request["键"]的方式接受参数
        [HttpGet]
        public ActionResult Add()
        {
            int id = int.Parse(Request["id"]);
            ViewBag.Id = id * 2;
            return View();
        }
        //方式二：自动装配
        //如果要实现行为的重载，要满足两个条件：1、参数不同；2、请求类型不同
        [HttpPost]
        public ActionResult Add(int id)//形参的名称必须和元素的name属性相同，在调用这个方法之前.Net会根据形参名称去Request中找传过来的值并转换成形参类型
        {
            ViewBag.Id2 = id;
            return View();
        }

        public ActionResult AddPerson()
        {
            return View();
        }

        [HttpPost]
        //方法三：自动装配二
        //实现自定义类型的重载
        public ActionResult AddPerson(Person p)
        {
            ViewData.Model = p;
            return View("AddPerson1");
        }

        //方法四：路由规则传值
        //将路由规则中id的值自动装配给形参。
        //{controller}/{action}/{id}，{id}的名称可改，形参名称和{id}的名称必须相同
        public ActionResult Edit(int id)
        {
            ViewBag.Id1 = Request["id"];
            ViewBag.Id = id;
            return View();
        }
    }
}