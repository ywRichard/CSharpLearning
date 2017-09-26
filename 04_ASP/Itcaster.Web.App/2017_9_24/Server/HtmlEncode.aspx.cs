using System;

namespace Itcaster.Web._2017_9_24.Server
{
    public partial class HtmlEncode : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                Response.Write(Server.HtmlEncode(Request.Form["txtContent"]));
            }
        }
    }
}