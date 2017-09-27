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
            //1.
            Response.Cookies["cp1"].Value = DateTime.Now.ToString();
        }
    }
}