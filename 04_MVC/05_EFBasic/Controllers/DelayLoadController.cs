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
            //延时加载：如果不使用数据，则只是会拼接sql语句，不会将结果集拿到内存中。只有到实际使用数据的时候才会去数据库查询。
            //1、只有使用数据的时候才会查询
            //2、每次使用都会查询数据库，不管是否查询过。
            //IQueryable<T> 支持延时加载；IEnumerable<T>不支持....
            DbContext context = new MyContext();

            //延时查询，会拼接完整的SQL语句，包括分页查询。让数据库去执行全部操作再返回所需的值。
            IQueryable<UserInfo> list = context.Set<UserInfo>()
                .OrderByDescending(u => u.ID)//默认会将lamda表达式封装成Expression对象，而调用IQueryable<T>的方法
                .Skip(2)
                .Take(3);
            ViewBag.list = list;

            //只拼接了查询UserInfo的SQL语句，将数据读入内存后再进行分页查询。假的延时查询
            IEnumerable<UserInfo> list1 = context.Set<UserInfo>()
                .AsEnumerable()
                .OrderByDescending(u => u.ID)
                .Skip(2)
                .Take(3);
            ViewBag.list1 = list1;

            //禁用延时加载，语句执行后立即查询，而不是等到用数据的时候。
            //查询结果是集合，结尾调用.ToList()
            //查询结果是单值，结尾调用FirstOrDefault()

            //导航属性也是延时加载，导航属性禁用延时加载使用Include()
            IQueryable<NewsInfo> list2 = context.Set<NewsInfo>();
            //ViewBag.list2 = list2;
            ViewBag.list2 = list2.Include(n => n.NewsType).ToList();
            
            return View();
        }
    }
}