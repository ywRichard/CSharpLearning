using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using _05_EFBasic.Models;

namespace _05_EFBasic.Controllers
{
    public class DelayLoadController : Controller
    {
        // GET: DelayLoad
        public ActionResult Index()
        {
            //延时加载：如果不使用数据，则只是会拼接sql语句，不会将结果集拿到内存中。
            //IQueryable<T> 支持延时加载；IEnumerable<UserInfo>不支持....
            DbContext context = new T1Context();
            IQueryable<UserInfo> list = context.Set<UserInfo>()
                .OrderByDescending(u => u.ID)//默认会将lamda表达式封装成Expression对象，而调用IQueryable<T>的方法
                .Skip(2)
                .Take(3);

            IEnumerable<UserInfo> list1 = context.Set<UserInfo>()
                .AsEnumerable()
                .OrderByDescending(u => u.ID)
                .Skip(2)
                .Take(3);

            ViewBag.list1 = list1;
            return View();
        }
    }
}