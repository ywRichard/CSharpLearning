using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Itcaster.Web.Model;

namespace Itcaster.Web._2017_10_05
{
    public partial class _01_Repeater : System.Web.UI.Page
    {
        private int _pageIndex;
        private int _pageCount;

        public int PageCount { get => _pageCount; set => _pageCount = value; }
        public int PageIndex { get => _pageIndex; set => _pageIndex = value; }

        protected void Page_Load(object sender, EventArgs e)
        {
            var pageSize = 5;
            if (!int.TryParse(Request.QueryString["pageIndex"], out _pageIndex))
            {
                _pageIndex = 1;
            }
            var bll = new BLL.UserInfoBLL();
            var _pageCount = bll.GetPageCount(pageSize);
            _pageIndex = _pageIndex < 1 ? 1 : _pageIndex;
            _pageIndex = _pageIndex > _pageCount ? PageCount : _pageIndex;
            Repeater2.DataSource = new List<UserInfo>(bll.GetPageEntityList(_pageIndex, pageSize));
            Repeater2.DataBind();
        }

        protected void Repeater2_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "btnDeleteUserInfo")
            {
                Response.Write(Convert.ToInt32(e.CommandArgument));
            }
        }
    }
}