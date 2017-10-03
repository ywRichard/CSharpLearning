using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Itcaster.Web._2017_9_26
{
    public partial class CookieDemo_2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["cp1"] != null)
            {
                var value = Request.Cookies["cp1"].Value;
                Response.Write(value);
            }
        }
    }
}