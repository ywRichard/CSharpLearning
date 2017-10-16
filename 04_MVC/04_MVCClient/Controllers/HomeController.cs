using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _04_Models;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Formatting;
using Newtonsoft.Json; 

namespace _04_MVCClient.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            //客户端对象的创建与初始化
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            //执行get操作
            HttpResponseMessage response = client.GetAsync("http://localhost:56872/api/userinfo").Result;//url地址
            var list = response.Content.ReadAsAsync<List<UserInfo>>().Result;
            ViewData.Model = list;

            return View();
        }
    }
}