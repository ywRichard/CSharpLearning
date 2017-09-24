using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Itcaster.Web.Model;

namespace Itcaster.Web._2017_9_18.aspxCRUD
{
    public partial class Details : System.Web.UI.Page
    {
        public UserInfo UserDetail { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(Request.QueryString["id"]);
            var bll = new BLL.UserInfoBLL();
            UserDetail = bll.GetEntityModel(id);
        }
    }
}