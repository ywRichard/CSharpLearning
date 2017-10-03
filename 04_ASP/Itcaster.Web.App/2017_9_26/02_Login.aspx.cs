using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Itcaster.Web._2017_9_26
{
    public partial class Login : System.Web.UI.Page
    {
        public string UserName;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["userName"] != null)
            {
                var name = Request.Cookies["userName"].Value;
                UserName = name;
                Response.Cookies["userName"].Value = name;
                Response.Cookies["userName"].Expires = DateTime.Now.AddDays(3);
            }
            else
            {
                if (IsPostBack)
                {
                    var name = Request.Form["txtName"];
                    Response.Cookies["userName"].Value = name;
                    Response.Cookies["userName"].Expires = DateTime.Now.AddDays(3);
                }
            }
        }
    }
}