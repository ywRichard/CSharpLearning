using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Itcaster.Web._2017_9_26
{
    public partial class CookieDemo_1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //1.将Cookie的数据储存到浏览器的内存中。
            //Response.Cookies["cp1"].Value = DateTime.Now.ToString();

            //2.指定一个过期时间，将数据储存到磁盘
            //Response.Cookies["cp1"].Value = "admin";
            ////Response.Cookies["cp1"].Expires = DateTime.Now.AddDays(3);
            //Response.Cookies["cp1"].Expires = DateTime.Now.AddDays(-1);//删除Cookie数据

            //3.Cookie与具体的浏览器有关，不同的浏览器存储的Cookie的位置不一样。
            //所以说在IE下面创建了Cookie,在其它浏览器是无法获取的。
            Response.Cookies["cp1"].Value = "admin";
            Response.Cookies["cp1"].Path = "/2017_9_26";//限制该路径下的页面才会把cookie发送到后台
            Response.Cookies["cp1"].Expires = DateTime.Now.AddDays(3);
            //Response.Cookies["cp1"].Domain = "localhost";
        }
    }
}