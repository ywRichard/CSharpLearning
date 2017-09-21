using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace Itcaster.Web._2017_9_18
{
    /// <summary>
    /// Summary description for ImageCreater
    /// </summary>
    public class ImageCreater : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            using (var map = new Bitmap(300, 400))
            {
                using (var g = Graphics.FromImage(map))
                {
                    g.Clear(Color.Chocolate);
                    g.DrawString("图片水印", new Font("黑体", 14.0f, FontStyle.Bold), Brushes.Red, new PointF(80, 90));
                    var fileName = Guid.NewGuid().ToString();
                    map.Save(context.Request.MapPath("/ImagePath/"+fileName+".jpg"), System.Drawing.Imaging.ImageFormat.Jpeg);//保存图片
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