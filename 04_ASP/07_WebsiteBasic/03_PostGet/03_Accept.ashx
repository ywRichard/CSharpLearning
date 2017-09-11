<%@ WebHandler Language="C#" Class="_03_Accept" %>

using System;
using System.Web;

public class _03_Accept : IHttpHandler
{

    public void ProcessRequest(HttpContext context)
    {
        context.Response.ContentType = "text/plain";
        //如果表单是以Post方式递交过来的，接受时必须用Request.Form来接收。
        //表单元素必须有name属性，而Form指定的键的名称就是name属性的值
        //var userName = context.Request.Form["txtName"];
        //var userPwd = context.Request.Form["txtPwd"];

        //如果表单是以Get方式递交，接受时必须用Request.QueryString接受。
        var userName = context.Request.QueryString["txtName"];
        var userPwd = context.Request.QueryString["txtPwd"];

        context.Response.Write("用户名是:" + userName + "密码是:" + userPwd);
    }

    public bool IsReusable
    {
        get
        {
            return false;
        }
    }

}