using _07_MvcOA.Model;
using Spring.Context;
using Spring.Context.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using _07_MvcOA.IBLL;
using _07_MvcOA.Common;

namespace WebApp
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        [WebMethod(Description = "计算两个数的和")]//曝露API
        public int Add(int a,int b)
        {
            return a + b;
        }
        [WebMethod]
        public string GetUserInfoList()
        {
            //序列化失败的原因是WebService返回值通过Http传递，不能传输类。所以要将返回值序列化。
            IApplicationContext context = ContextRegistry.GetContext();
            var userInfoBll = (IUserInfoBLL)context.GetObject("UserInfoBLL");
            var list = userInfoBll.LoadEntities(u => u.DelFlag == 0).ToList();

            return SerializerHelper.SerializerToString(list);
        }
    }
}
