using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Itcaster.Web._2017_10_06
{
    public partial class _02_CustomCacheDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var bll = new BLL.UserInfoBLL();
            var list = new List<Model.UserInfo>();
            if (Cache["userInfoList"] == null)
            {
                list = bll.GetEntityList();
                //Cache["userInfoList"] = list;//方法一：载入缓存首选方式
                Cache.Insert("userInfoList", list, null, DateTime.Now.AddSeconds(5), TimeSpan.Zero);
                //Cache.Remove("userInfoList");//和方法一搭配使用
                Response.Write("从数据库中查询");
            }
            else
            {
                list = (List<Model.UserInfo>)Cache["userInfoList"];
                Response.Write("从缓存中查询");
            }
        }
    }
}