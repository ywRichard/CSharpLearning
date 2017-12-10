using _07_MvcOA.Model;
using _07_MvcOA.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebForm.WeatherReference;

namespace WebForm
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ServiceReference1.WebService1SoapClient client = new ServiceReference1.WebService1SoapClient();
            //var result = client.Add(1,6);
            //Response.Write(result.ToString());

            var str = client.GetUserInfoList();
            List<UserInfo> list = SerializerHelper.DeserializerToObject<List<UserInfo>>(str);
            foreach (var userInfo in list)
            {
                Response.Write(userInfo.UserName);
                Response.Write("</br>");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            var client = new WeatherWebServiceSoapClient();
            var strs = client.getSupportCity("");
            foreach (var str in strs)
            {
                Response.Write(str);
                Response.Write("</br>");
            }
        }
    }
}