using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItcastCater.Model;
using ItcastCater.DAL;

namespace ItcastCater.BLL
{
    public class UserInfoBLL
    {
        UserInfoDAL dal = new UserInfoDAL();

        /// <summary>
        /// 在数据库中查询账号
        /// </summary>
        /// <param name="loginName">账号</param>
        /// <returns>返回的UserInfo的对象</returns>
        public bool IsLoginByName(string loginName, string pwd, out string msg)
        {
            var flag = false;
            var user = dal.IsLoginByName(loginName);
            if (user != null)
            {
                if (pwd==user.Pwd)
                {
                    flag = true;
                    msg = "登陆成功";
                }
                else
                {
                    msg = "登陆失败";
                }
            }
            else
            {
                msg = "账号不存在";          
            }

            return flag;
        }
    }
}
