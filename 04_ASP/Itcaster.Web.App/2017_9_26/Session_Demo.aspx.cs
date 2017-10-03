using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CZBK.TestProject.WebApp._2014_11_11
{
    public partial class Session_Demo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
              
                Session["name"]=Request.Form["txtName"];
                Response.Redirect("Test.aspx");
            }
        }
    }
}