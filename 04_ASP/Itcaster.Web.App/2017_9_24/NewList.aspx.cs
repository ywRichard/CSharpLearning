using Itcaster.Web.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Itcaster.Web._2017_9_24
{
    public partial class NewList : System.Web.UI.Page
    {
        private int _pageIndex;
        private int _pageCount;
        private int _pageSize;
        public List<UserInfo> UserInfoList { get; set; }
        public int PageIndex { get => _pageIndex; set => _pageIndex = value; }
        public int PageCount { get => _pageCount; set => _pageCount = value; }

        protected void Page_Load(object sender, EventArgs e)
        {
            _pageSize = 5;
            int index;
            if (!int.TryParse(Request.QueryString["pageIndex"], out index))
            {
                index = 1;
            }
            PageIndex = index;
            var bll = new BLL.UserInfoBLL();
            _pageCount = bll.GetPageCount(_pageSize);
            UserInfoList = new List<UserInfo>(bll.GetPageEntityList(index, _pageSize));
        }
    }
}