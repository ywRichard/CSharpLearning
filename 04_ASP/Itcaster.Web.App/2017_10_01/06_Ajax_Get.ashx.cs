using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Itcaster.Web._2017_10_01
{
    /// <summary>
    /// Summary description for _06_Ajax_Get
    /// </summary>
    public class _06_Ajax_Get : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            //context.Response.Write(DateTime.Now.ToString());

            var method = context.Request.HttpMethod;//判断请求方式
            var name = "";
            var pwd = "";
            if (method == "GET")//1、手动判断请求方式
            {
                name = context.Request.QueryString["name"];
                pwd = context.Request.QueryString["pwd"];
            }
            else if (method == "POST")
            {
                name = context.Request.Form["name"];
                pwd = context.Request.Form["pwd"];
            }

            ////2、服务器判断请求方式
            //var name = context.Request["name"];
            //var pwd = context.Request["pwd"];
            context.Response.Write(name + ":" + pwd);
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}