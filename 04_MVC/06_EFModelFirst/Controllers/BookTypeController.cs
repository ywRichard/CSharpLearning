using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using _06_EFModelFirst.Models;
namespace _06_EFModelFirst.Controllers
{
    public class BookTypeController : Controller
    {
        private DbContext context = new MyModelContainer();
        // GET: BookType
        public ActionResult Index()
        {
            ViewData.Model = context.Set<BookType>();
            return View();
        }

        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(BookType bookType)
        {
            //集合方法
            //context.Set<BookType>().Add(bookType);

            //状态方法
            context.Set<BookType>().Attach(bookType);
            context.Entry(bookType).State = EntityState.Added;

            if (context.SaveChanges() > 0)
            {
                return Redirect(Url.Action("Index"));
            }
            else
            {
                return View();
            }

        }
    }
}