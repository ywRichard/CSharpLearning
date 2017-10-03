using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itcaster.Web.Common
{
    public class CheckSessionState : System.Web.UI.Page
    {
        protected void Page_Init(object sender, EventArgs e)
        {
            if (Session["userInfo"] == null)
            {
                Response.Redirect("01_Login.aspx");
            }
        }
    }
}
