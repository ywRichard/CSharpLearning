using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_EFBasicConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = "No information";
            var context = new T1Context();
            #region Insert
            //context.UserInfoes.Add(new UserInfo
            //{
            //    UserName = "Ef1",
            //    UserPass = "123",
            //    RegTime = DateTime.Now,
            //    Email = "asdf@163.com"
            //});

            //result = context.SaveChanges() > 0 ? "Insert OK" : "Insert NG";
            #endregion

            #region Read
            //var userInfo = context.UserInfoes.Find(22);
            //if (userInfo != null)
            //{
            //    result = userInfo.UserName;
            //}
            #endregion

            #region Delete
            //var userInfo = context.UserInfoes.Find(22);
            //context.UserInfoes.Remove(userInfo);
            //result = context.SaveChanges() > 0 ? "Delete Ok" : "Delete NG";
            #endregion

            #region Update

            #endregion

            Console.WriteLine(result);
        }
    }
}
