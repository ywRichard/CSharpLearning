<%@ WebHandler Language="C#" Class="_04_SelfAdd" %>

using System;
using System.Web;
using System.IO;

public class _04_SelfAdd : IHttpHandler {

    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/html";
        var filePath = context.Request.MapPath("04_SelfAdd.html");
        var fileContent = File.ReadAllText(filePath);
        var count = Convert.ToInt32(context.Request.Form["txtCount"]);
        count++;
        var strHtml = fileContent.Replace("$value",count.ToString());

        strHtml = strHtml.Replace("$divValue", count.ToString());
            strHtml = strHtml.Replace("$hidValue", count.ToString());
        context.Response.Write(strHtml);
    }

    public bool IsReusable {
        get {
            return false;
        }
    }

}