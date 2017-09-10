<%@ WebHandler Language="C#" Class="UserListInfo" %>

using System;
using System.Web;
using System.IO;

public class UserListInfo : IHttpHandler
{

    public void ProcessRequest(HttpContext context)
    {
        context.Response.ContentType = "text/html";
        var filePath = context.Request.MapPath("UserList.html");//获取该文件物理路径
        var strHtml = File.ReadAllText(filePath);
        strHtml = strHtml.Replace("$userName", "张三").Replace("$pwd", "123");
        context.Response.Write(strHtml);
    }

    public bool IsReusable
    {
        get
        {
            return false;
        }
    }

}