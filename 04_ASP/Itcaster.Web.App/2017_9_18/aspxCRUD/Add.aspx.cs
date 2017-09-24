using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Itcaster.Web._2017_9_18.aspxCRUD
{
    public partial class Add : System.Web.UI.Page
    {
        public string ErrMsg { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)//响应Post请求，Get请求为false
            {
                var userInfo = new Model.UserInfo();
                userInfo.UserName = Request.Form["txtName"];
                userInfo.UserPass = Request.Form["txtPwd"];
                userInfo.RegTime = DateTime.Now;
                userInfo.Email = Request.Form["txtEmail"];

                var bll = new BLL.UserInfoBLL();
                if (bll.InsertEntityModel(userInfo))
                {
                    Response.Redirect("Index.aspx");
                }
                else
                {
                    ErrMsg = "添加失败";
                }

            }
        }
    }
}