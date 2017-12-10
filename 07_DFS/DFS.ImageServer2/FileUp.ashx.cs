using DFS.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace DFS.ImageServer2
{
    /// <summary>
    /// Summary description for FileUp
    /// </summary>
    public class FileUp : IHttpHandler
    {
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            var ext = context.Request["ext"];
            var serverId = int.Parse(context.Request["serverId"]);
            var dir = "/images/" + DateTime.Now.Year + "/" + DateTime.Now.Month + "/" + DateTime.Now.Day + "/";
            Directory.CreateDirectory(Path.GetDirectoryName(context.Request.MapPath(dir)));
            var newFileName = Guid.NewGuid().ToString();
            var fullDir = dir + newFileName + ext;
            using (FileStream stream = File.OpenWrite(context.Request.MapPath(fullDir)))
            {
                //将文件流写到指定的文件夹下
                context.Request.InputStream.CopyTo(stream);
                var myDbContext = new MyImageServerEntities();
                ImageInfo imageInfo = new ImageInfo();
                imageInfo.ImageName = fullDir;
                imageInfo.ImageServerId = serverId;
                myDbContext.ImageInfo.Add(imageInfo);
                myDbContext.SaveChanges();
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