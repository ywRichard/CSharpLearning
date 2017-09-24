using Itcaster.Web.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Itcaster.Web._2017_9_18.aspxCRUD
{
    public partial class Index : System.Web.UI.Page
    {
        public string StrHtml { get; set; }
        public List<UserInfo> UserInfoList { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            var bll = new BLL.UserInfoBLL();
            //方法二
            UserInfoList = new List<UserInfo>(bll.GetEntityList());

            //方法一
            //var userInfoList = bll.GetEntityList();
            //if (userInfoList.Count > 0)
            //{
            //    var sb = new StringBuilder();
            //    foreach (var userInfo in userInfoList)
            //    {
            //        sb.AppendFormat("<tr><td>{0}</td><td>{1}</td><td>{2}</td><td>{3}</td><td>{4}</td><td><a href='ShowDetails.ashx?id={0}'>详细</a></td><td><a href='Delete.ashx?id={0}'>删除</a></td><td><a href='Edit.ashx?id={0}'>编辑</a></td></tr>", userInfo.ID, userInfo.UserName, userInfo.UserPass, userInfo.RegTime.ToShortDateString(), userInfo.Email);
            //    }
            //    StrHtml = sb.ToString();
            //}
        }
    }
}