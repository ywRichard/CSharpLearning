using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Drawing;

namespace Itcaster.Web
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
                    var dir = $"/ImagePath/{DateTime.Now.Year}/{DateTime.Now.Month}/{DateTime.Now.Day}/";
                    //创建文件夹
                    Directory.CreateDirectory(Path.GetDirectoryName(context.Request.MapPath(dir)));
                    //对需要上传的文件进行重命名
                    fileName = Guid.NewGuid().ToString();
                    var fullDir = dir + fileName + fileExtension;
                    //file.SaveAs(context.Request.MapPath(fullDir));
                    //file.SaveAs(context.Request.MapPath("../ImagePath/" + fileName));
                    using (var image = Image.FromStream(file.InputStream))//根据上传的文件流创建
                    {
                        using (var map = new Bitmap(image.Width, image.Height))
                        {
                            using (var g = Graphics.FromImage(map))
                            {
                                //先将图片画到画布上
                                g.DrawImage(image, new Rectangle(0, 0, image.Width, image.Height));
                                //在右角添加水印
                                g.DrawString("传智播客", new Font("黑体", 14.0f, FontStyle.Bold), Brushes.Red, GetPoint(image.Width, image.Height));
                                map.Save(context.Request.MapPath(fullDir), System.Drawing.Imaging.ImageFormat.Jpeg);
                            }
                        }
                    }
                    context.Response.Write("<html><head></head><body><img src='" + fullDir + "'/></body></html>");
                }
                else
                {
                    context.Response.Write("文件类型错误！");
                }
            }
        }

        private static PointF GetPoint(int width, int height)
        {
            return new PointF(width - Convert.ToInt32(width * 0.2), height - Convert.ToInt32(height * 0.2));
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