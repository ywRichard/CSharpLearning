using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Itcaster.Web._2017_9_24.ViewState
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BLL.UserInfoService UserInfoService = new BLL.UserInfoService();
                this.GridView1.DataSource = UserInfoService.GetEntityList();
                this.GridView1.DataBind();
            }
        }
    }
}