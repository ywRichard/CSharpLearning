using _04_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _04_WebAPI.Controllers
{
    public class UserInfoController : ApiController
    {
        // GET: api/UserInfo
        //使用Method=Get的方式请求url=api/userinfo，则这个方法会被调用执行；没有显式的调用方法，在请求资源的时候去隐式的调用方法
        public IEnumerable<UserInfo> Get()
        {
            var list = new List<UserInfo>();

            list.Add(new UserInfo { Id = 1, Name = "张三" });
            list.Add(new UserInfo { Id = 2, Name = "李四" });
            list.Add(new UserInfo { Id = 3, Name = "王五" });

            return list;
        }

        // GET: api/UserInfo/5
        public UserInfo Get(int id)
        {
            var userInfo = new UserInfo();

            return userInfo;
        }

        // POST: api/UserInfo
        //增加
        //[HttpPost]//添加该特性，可以修改方法的名称
        public void Post([FromBody]string value)//FromBody，value来自请求体可写可不写
        {
        }

        // PUT: api/UserInfo/5
        //修改
        //[HttpPut]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/UserInfo/5
        //删除
        //[HttpDelete]
        public void Delete(int id)
        {
        }
    }
}
