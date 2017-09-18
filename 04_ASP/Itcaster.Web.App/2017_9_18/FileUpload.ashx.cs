using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

namespace Itcaster.Web._2017_9_18
{
    /// <summary>
    /// Summary description for FileUpload
    /// </summary>
    public class FileUpload : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/html";
            var file = context.Request.Files["fileUp"];
            if (file == null)
            {
                context.Response.Write("请选择文件！！");
            }
            else
            {
                var fileName = Path.GetFileName(file.FileName);
                var fileExtension = Path.GetExtension(fileName);
                if (fileExtension == ".jpg" || fileExtension == ".gif")
                {
                    file.SaveAs(context.Request.MapPath("../ImagePath/" + fileName));
                    context.Response.Write("<html><head></head><body><img src='/ImagePath/" + fileName + "'/></body></html>");
                }
                else
                {
                    context.Response.Write("文件类型错误！");
                }
            }
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