<%@ WebHandler Language="C#" Class="_07_DeleteDetail" %>

using System;
using System.Web;

public class _07_DeleteDetail : IHttpHandler {
    
    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/plain";
        context.Response.Write("Hello World");
    }
 
    public bool IsReusable {
        get {
            return false;
        }
    }

}