using DFS.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace DFS.WebApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        private MyImageServerEntities context = new MyImageServerEntities();

        public ActionResult Fileupload()
        {
            HttpPostedFileBase file = Request.Files["fileUp"];
            if (file != null)
            {
                var fileName = Path.GetFileName(file.FileName);
                var fileExt = Path.GetExtension(fileName);
                if (fileExt == ".jpg")
                {
                    //随机算法，从状态表中筛选出可用的图片服务器集合C，获取集合的总记录数N。然后用随机函数产生一个随机数R1并用R1与N进行取余运算记作I=R1%N，则C[I]即为要保存图片的图片服务器
                   
                    var list = context.ImageServerInfo.Where(a => a.FlgUsable == true).ToList();
                    var count = list.Count;
                    var random = new Random();
                    var i = random.Next() % count;
                    ImageServerInfo imageServiceInfo = list[i];//筛查出服务器
                    WebClient client = new WebClient();
                    var address = "http://" + imageServiceInfo.ServerUrl + "/FileUp.ashx?serverId=" + imageServiceInfo.ServerId + "&ext=" + fileExt;
                    client.UploadData(address, StreamToByte(file.InputStream));
                    return Content("文件上传成功");
                }
                else
                {
                    return Content("文件格式错误");
                }
            }
            else
            {
                return Content("文件为空");
            }
        }

        private byte[] StreamToByte(Stream stream)
        {
            byte[] buffer = new byte[stream.Length];
            stream.Read(buffer, 0, buffer.Length);
            stream.Seek(0, SeekOrigin.Begin);
            return buffer;
        }

        public ActionResult ShowImage()
        {
            var list = context.ImageServerInfo.Where(a => a.FlgUsable == true).ToList();
            ViewData["list"] = list;
            return View();
        }
    }
}