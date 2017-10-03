using Itcaster.Web.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Itcaster.Web._2017_10_01
{
    public partial class Login : System.Web.UI.Page
    {
        //BLL.UserInfoBLL bll = new BLL.UserInfoBLL();

        public string ErrorMsg { get; set; }
        private BLL.UserInfoBLL bll = new BLL.UserInfoBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            //客户端与服务端都要校验
            //1.判断验证码是否正确
            if (IsPostBack)
            {
                if (CheckValidateCode())
                {
                    UserLogin();
                }
                else
                {
                    ErrorMsg = "验证码错误！！";
                }
            }
            else//表示get请求
            {
                //CheckCookieInfo();//校验Cookie信息
                CheckCookieInfo();
            }
        }

        private void CheckCookieInfo()
        {
            //判断Cookie中是否有值
            if (Request.Cookies["cp1"] != null && Request.Cookies["cp2"] != null)
            {
                var userName = Request.Cookies["cp1"].Value;
                var userPwd = Request.Cookies["cp2"].Value;
                //判断Cookie中储存的用户名是否正确
                var userInfo = bll.GetEntityModel(userName);
                if (userInfo != null)
                {
                    //判断密码是否正确
                    if (userPwd == Common.WebCommon.GetMd5String(Common.WebCommon.GetMd5String(userInfo.UserPass)))
                    {
                        Session["userInfo"] = userInfo;
                        Response.Redirect("03_AdminIndex.aspx");
                    }
                }
                Response.Cookies["cp1"].Expires = DateTime.Now.AddDays(-1);
                Response.Cookies["cp2"].Expires = DateTime.Now.AddDays(-1);
            }
        }

        private void UserLogin()
        {
            var userName = Request.Form["txtClientID"];
            var userPwd = Request.Form["txtPassword"];
            var msg = string.Empty;
            var userInfo = new UserInfo();

            var b = bll.CheckUserInfo(userName, userPwd, out msg, out userInfo);
            if (b)
            {
                Session["userInfo"] = userInfo;
                if (!string.IsNullOrEmpty(Request.Form["CheckMe"]))
                {
                    HttpCookie cookie1 = new HttpCookie("cp1", userName);
                    HttpCookie cookie2 = new HttpCookie("cp2", Common.WebCommon.GetMd5String(Common.WebCommon.GetMd5String(userPwd)));

                    cookie1.Expires = DateTime.Now.AddDays(3);
                    cookie2.Expires = DateTime.Now.AddDays(3);

                    Response.Cookies.Add(cookie1);
                    Response.Cookies.Add(cookie2);
                }
                Response.Redirect("03_AdminIndex.aspx");
            }
            else
            {
                ErrorMsg = msg;
            }
        }

        private bool CheckValidateCode()
        {
            var isSuccess = false;

            if (Session["code"] != null)
            {
                var sysCode = Session["code"].ToString();
                var userCode = Request.Form["txtCode"];
                if (sysCode.Equals(userCode, StringComparison.CurrentCultureIgnoreCase))
                {
                    isSuccess = true;
                    //设置成功之后删除Session -> 节省了资源的开销，同时防止暴力破解。
                    Session["code"] = null;
                    //Session.Remove("code");//删除Session
                }
            }

            return isSuccess;
        }

        //protected void CheckCookieInfo()
        //{
        //    //判断Cookie中是否有值
        //    if (Request.Cookies["cp1"] != null && Request.Cookies["cp2"] != null)
        //    {
        //        string userName = Request.Cookies["cp1"].Value;
        //        string userPwd = Request.Cookies["cp2"].Value;
        //        //判断Cookie中存储的用户名是否正确
        //        UserInfo userInfo=bll.GetEntityModel(userName);
        //        if (userInfo != null)
        //        {
        //            //判断密码是否正确.
        //            if (userPwd == Common.WebCommon.GetMd5String(Common.WebCommon.GetMd5String(userInfo.UserPass)))
        //            {
        //                Session["userInfo"] = userInfo;
        //                Response.Redirect("AdminIndex.aspx");
        //            }
        //        }
        //        Response.Cookies["cp1"].Expires = DateTime.Now.AddDays(-1);
        //        Response.Cookies["cp2"].Expires = DateTime.Now.AddDays(-1);
        //    }
        //}
        //protected void UserLoginIn()
        //{
        //    string userName = Request.Form["txtClientID"];
        //    string userPwd = Request.Form["txtPassword"];
        //    string msg = string.Empty;
        //    UserInfo userInfo=null;
        //   bool b= bll.CheckUserInfo(userName, userPwd,out msg,out userInfo);
        //   if (b)
        //   {
        //       Session["userInfo"] = userInfo;
        //       //判断用户是否选择了记住我
        //       if (!string.IsNullOrEmpty(Request.Form["CheckMe"]))
        //       {
        //           HttpCookie cookie1 = new HttpCookie("cp1",userName);
        //           HttpCookie cookie2 = new HttpCookie("cp2", Common.WebCommon.GetMd5String(Common.WebCommon.GetMd5String(userPwd)));
        //           cookie1.Expires = DateTime.Now.AddDays(3);
        //           cookie2.Expires = DateTime.Now.AddDays(3);
        //           Response.Cookies.Add(cookie1);
        //           Response.Cookies.Add(cookie2);
        //       }
        //       Response.Redirect("AdminIndex.aspx");
        //   }
        //   else
        //   {
        //       ErrorMsg = msg;
        //   }
        //}


    }

}