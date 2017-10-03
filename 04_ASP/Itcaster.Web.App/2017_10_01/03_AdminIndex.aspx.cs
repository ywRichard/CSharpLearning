using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Itcaster.Web._2017_10_01
{
    public partial class _03_AdminIndex : Common.CheckSessionState
    {
        protected Model.UserInfo UserInfo { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            UserInfo = (Model.UserInfo)Session["userInfo"];
        }
    }
}