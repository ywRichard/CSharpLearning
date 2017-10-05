using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Itcaster.Web.BLL;

namespace Itcaster.Web._2017_10_03
{
    /// <summary>
    /// Summary description for _06_List
    /// </summary>
    public class _06_List : IHttpHandler
    {
        UserInfoBLL bll = new UserInfoBLL();
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            int pageIndex;
            if (!int.TryParse(context.Request["pageIndex"], out pageIndex))
            {
                pageIndex = 1;
            }
            int pageSize = 5;
            var pageCount = bll.GetPageCount(pageSize);
            pageIndex = pageIndex < 1 ? 1 : pageIndex;
            pageIndex = pageIndex > pageCount ? pageCount : pageIndex;

            var list = bll.GetPageEntityList(pageIndex, pageSize);
            var pageBar = Common.PageNumericBar.GetNumericBar(pageIndex, pageCount);
            var js = new System.Web.Script.Serialization.JavaScriptSerializer();
            //context.Response.Write(js.Serialize(list));
            context.Response.Write(js.Serialize(new { UserList = list, PageBar = pageBar }));
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}