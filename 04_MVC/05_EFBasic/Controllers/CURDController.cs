using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _05_EFBasic.Controllers
{
    public class CURDController : Controller
    {
        // GET: CURD
        public ActionResult Index()
        {

            //var myContext = new MyContext();
            //var userInfo = myContext.UserInfo;//获得DbSet<UserInfo>

            //建议：声明父类型的变量，指向子类型的对象
            //面向多态的开始 -> 面向抽象的编程，yong
            //DbContext dbContext = new MyContext();
            //var userInfo = dbContext.Set<UserInfo>();//获得DbSet<UserInfo>

            //查询语法
            //var list = from abc in userInfo
            //           select abc;
            //方法语法
            //var list = userInfo.Select(u => u);

            DbContext context = new MyContext();
            //基本查询
            //IQueryable<UserInfo> list = from userInfo in context.Set<UserInfo>()
            //select userInfo;
            //单条件查询
            //var list = from userInfo in context.Set<UserInfo>()
            //           where userInfo.ID > 10
            //           select userInfo;
            //多条件查询
            var list = from userInfo in context.Set<UserInfo>()
                       where userInfo.ID > 10 && userInfo.UserName.Length > 5
                       select userInfo;

            return View(list);
        }

        public ActionResult Insert()
        {
            var context = new T1Context();
            context.UserInfoes.Add(new UserInfo
            {
                UserName = "ef",
                UserPass = "123",
                RegTime = DateTime.Now,
                Email = "aa@163.com"
            });
            var result = context.SaveChanges() > 0 ? "Ok" : "NG";

            return Content(result);
        }
    }
}