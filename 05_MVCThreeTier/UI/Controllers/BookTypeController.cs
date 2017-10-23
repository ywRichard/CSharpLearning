using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model;
using BLL;

namespace UI.Controllers
{
    public class BookTypeController : Controller
    {
        BookTypeBLL bll = new BookTypeBLL();
        // GET: BookType
        public ActionResult Index()
        {
            ViewData.Model = bll.GetEntityList(10, 1);
            return View();
        }

        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(BookType bookType)
        {
            bll.Add(bookType);
            return Redirect(Url.Action("Index"));
        }
    }
}