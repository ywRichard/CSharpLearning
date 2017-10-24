using BLL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace UI.Controllers
{
    public class BookInfoController : Controller
    {
        BookInfoBLL bookInfoBLL = new BookInfoBLL();
        BookTypeBLL bookTypeBLL = new BookTypeBLL();

        // GET: BookInfo
        public ActionResult Index()
        {
            //ViewData.Model = bookInfoBLL.GetEntityList(10, 1);

            return View();
        }

        public ActionResult Add()
        {
            var list = new List<SelectListItem>();
            foreach (var item in bookTypeBLL.GetEntityList(100, 1))
            {
                list.Add(new SelectListItem
                {
                    Text = item.TypeTitle,
                    Value = item.TypeId.ToString()
                });
            }
            ViewBag.TypeList = list;

            return View();
        }

        [HttpPost]
        public ActionResult Add(BookInfo bookInfo)
        {
            bookInfoBLL.Add(bookInfo);

            return Redirect(Url.Action("Index"));
        }

        public ActionResult LoadList(int pageSize, int pageIndex)
        {
            var list = bookInfoBLL.GetEntityList(pageSize, pageIndex)
                .Select(u => new
                {
                    ID = u.BookId,
                    Title = u.BookTitle,
                    TypeTitle = u.BookType.TypeTitle
                })
                .ToList();

            var rowsCount = bookInfoBLL.GetCount();
            var pageCount = Convert.ToInt32(Math.Ceiling(rowsCount * 1.0 / pageSize));

            var pager = new StringBuilder();
            if (pageIndex == 1)
            {
                pager.Append("首页 上一页");
            }
            else
            {
                pager.Append("<a href='javascript:GoPage(1)'>首页</a>&nbsp;<a href='javascript:GoPage(" + (pageIndex - 1) + ")'>上一页</a>");
            }

            if (pageIndex == pageCount)
            {
                pager.Append("下一页 末页");
            }
            else
            {
                pager.Append("<a href='javascript:GoPage(" + (pageIndex + 1) + ")'>下一页</a>&nbsp;<a href='javascript:GoPage(" + pageCount + ")'>末页</a>");
            }

            var buffer = new
            {
                List = list,
                Pager=pager.ToString()
            };
            return Json(buffer, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Edit(int id)
        {
            ViewBag.Id = id;
            return View();
        }

        public ActionResult Remove(int id)
        {
            
            bookInfoBLL.Remove(id);
            return Redirect(Url.Action("Index"));
        }
    }
}