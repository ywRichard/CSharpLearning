using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Drawing;
using Itcaster.Web.Common;

namespace Itcaster.Web
{
    /// <summary>
    /// Summary description for ImageThumb
    /// </summary>
    public class ImageThumb : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            //var image = Image.FromFile(context.Request.MapPath("/ImagePath/3-1.jpg"));
            //using (var map = new Bitmap(Convert.ToInt32(image.Width / 4), Convert.ToInt32(image.Height / 4)))
            //{
            //    using (var g = Graphics.FromImage(map))
            //    {
            //        g.DrawImage(image, new Rectangle(0, 0, Convert.ToInt32(image.Width / 4), Convert.ToInt32(image.Height / 4)));
            //        map.Save(context.Request.MapPath("/ImagePath/3-1_Thum.jpg"), System.Drawing.Imaging.ImageFormat.Jpeg);
            //    }
            //}
            //调用算法
            var filePath = context.Request.MapPath("/ImagePath/3-1.jpg");
            var thumPath = context.Request.MapPath($"/ImagePath/{Guid.NewGuid().ToString()}.jpg");
            ImageClass.MakeThumbnail(context.Request.MapPath("/ImagePath/3-1.jpg"), thumPath, 40, 40, "W");
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