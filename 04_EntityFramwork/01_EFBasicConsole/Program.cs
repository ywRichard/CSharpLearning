using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_DatabaseFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = "No information";
            DbContext context = new T1Context();

            #region 集合版CRUD -> 适用于增加，删除
            //Insert
            //context.Set<UserInfo>().Add(new UserInfo
            //{
            //    UserName = "Ef1",
            //    UserPass = "123",
            //    RegTime = DateTime.Now,
            //    Email = "asdf@163.com"
            //});

            //result = context.SaveChanges() > 0 ? "Insert OK" : "Insert NG";

            //Read
            //var userInfo = context.Set<UserInfo>().Find(22);//查找主键
            var userName = context.Set<UserInfo>().Take(50).Include("UserName");//预先装载userName，Include()会让EF通知DB将"...表中的..."发送给我。
            context.Set<UserInfo>().Take(50).Include("UserName").Load();//显示装入，Load()让EF将数据载入到context中？
            //if (userInfo != null)
            //{
            //    result = userInfo.UserName;
            //}

            //Delete
            //var userInfo = context.Set<UserInfo>().Find(22);
            //context.UserInfoes.Remove(userInfo);
            //result = context.SaveChanges() > 0 ? "Delete Ok" : "Delete NG";
            #endregion

            #region 状态版CRUD -> 适用于修改。集合版的CRUD也是状态跟踪实现的，在DbContext中有ObjectStateManager管理状态的跟踪
            //Insert
            //var userInfo = new UserInfo
            //{
            //    UserName = "Status",
            //    UserPass = "abcd"
            //};
            //context.Entry(userInfo).State = EntityState.Added;
            //result = context.SaveChanges() > 0 ? "Ok" : "Status Add fail";

            //Update
            //var userInfo = new UserInfo {
            //    ID=23,//更改或者删除要先得到ID（主键）
            //    UserName= "Status12314",
            //    UserPass="sadfghghg"
            //};
            //context.Entry(userInfo).State = EntityState.Modified;
            //result = context.SaveChanges() > 0 ? "Ok" : "Status Modified fail";

            //修改单列
            var userInfo = new UserInfo() {
                ID=21
            };
            ((T1Context)context).UserInfoes.Attach(userInfo);
            context.Entry(userInfo).Property("UserName").CurrentValue = "EF_Modified";
            context.Entry(userInfo).Property("UserName").IsModified = true;
            result = context.SaveChanges() > 0 ? "Ok" : "Status Delete fail";

            //Deleted
            //var userInfo = new UserInfo
            //{
            //    ID = 23,//更改或者删除要先得到ID（主键）
            //};
            //context.Entry(userInfo).State = EntityState.Deleted;
            //result = context.SaveChanges() > 0 ? "Ok" : "Status Delete fail";
            #endregion

            Console.WriteLine(result);
        }
    }
}
