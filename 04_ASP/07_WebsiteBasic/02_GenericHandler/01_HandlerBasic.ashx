<%@ WebHandler Language="C#" Class="_01_HandlerBasic" %>

using System;
using System.Web;
using System.Text;

public class _01_HandlerBasic : IHttpHandler
{

    public void ProcessRequest(HttpContext context)
    {
        context.Response.ContentType = "text/html";
        var sb = new StringBuilder();
            sb.Append("<html><head><title>用户列表</title></head>");
            sb.Append("<body>");
            sb.Append("<table><tr><td>用户名</td><td>张三</td></tr><tr><td>密码</td><td>1111</td></tr></table></body></html>");
            context.Response.Write(sb.ToString());
    }

    public bool IsReusable
    {
        get
        {
            return false;
        }
    }

}