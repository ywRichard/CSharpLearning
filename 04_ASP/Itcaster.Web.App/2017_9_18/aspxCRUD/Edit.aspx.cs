using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Itcaster.Web._2017_9_18.aspxCRUD
{
    public partial class Edit : System.Web.UI.Page
    {
        public Model.UserInfo UserDetail { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(Request.QueryString["id"]);
            if (!IsPostBack)
            {
                var bll = new BLL.UserInfoBLL();
                var userInfo = bll.GetEntityModel(id);
                if (userInfo != null)
                {
                    UserDetail = userInfo;
                }
            }
            else
            {
                UserDetail = new Model.UserInfo
                {
                    ID = id,
                    UserName = Request.Form["txtName"],
                    UserPass = Request.Form["txtPwd"],
                    RegTime = Convert.ToDateTime(Request.Form["txtRegTime"]),
                    Email = Request.Form["txtEmail"]
                };
                var bll = new BLL.UserInfoBLL();
                if (bll.UpdateEntityModel(UserDetail))
                {
                    Response.Redirect("index.aspx");
                }
            }
        }
    }
}