using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Itcaster.Web._2017_10_01
{
    public partial class _08_AjaxDemo_Get : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //不管是get还是post请求，服务器都会走请求响应模型的流程。然后把值以及HTML都作为结果返回
            Response.Write(Request.QueryString["name"]);
            Response.End();//终止生成html
        }
    }
}