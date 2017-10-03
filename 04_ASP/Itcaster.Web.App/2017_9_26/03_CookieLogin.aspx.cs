using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Itcaster.Web.Common;

namespace Itcaster.Web._2017_9_26
{
    public partial class CookieLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                CheckUserInfo();
            }
            else
            {
                CheckCookieInfo();
            }
        }

        /// <summary>
        /// 对Cookie中储存的信息进行校验
        /// </summary>
        private void CheckCookieInfo()
        {
            if (Request.Cookies["cp1"] != null && Request.Cookies["cp2"] != null)
            {
                var userName = Request.Cookies["cp1"].Value;
                var userPwd = Request.Cookies["cp2"].Value;
                //判断Cookie中储存的用户名是否正确
                if (userName == "yao")
                {
                    if (userPwd == WebCommon.GetMd5String(WebCommon.GetMd5String("123")))
                    {
                        Session["name"] = userPwd;//给Session赋值(自己加的)
                        Response.Redirect("04_Test.aspx");
                    }
                }
                Response.Cookies["cp1"].Expires = DateTime.Now.AddDays(-1);
                Response.Cookies["cp2"].Expires = DateTime.Now.AddDays(-1);
            }
        }

        /// <summary>
        /// 判断用户名密码是否正确，用户登录
        /// </summary>
        private void CheckUserInfo()
        {
            var userName = Request.Form["txtName"];
            var userPwd = Request.Form["txtPwd"];
            if (userName == "yao" && userPwd == "123")
            {
                Session["name"] = userName;//给Session赋值（自己加的）
                if (!string.IsNullOrEmpty(Request.Form["checkMe"]))
                {
                    var cookie1 = new HttpCookie("cp1", userName);
                    var cookie2 = new HttpCookie("cp2", WebCommon.GetMd5String(WebCommon.GetMd5String(userPwd)));
                    cookie1.Expires = DateTime.Now.AddDays(3);
                    cookie1.Expires = DateTime.Now.AddDays(3);
                    Response.Cookies.Add(cookie1);
                    Response.Cookies.Add(cookie2);
                }
                Response.Redirect("04_Test.aspx");
            }
        }
    }
}