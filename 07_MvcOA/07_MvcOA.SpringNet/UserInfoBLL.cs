using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_MvcOA.SpringNet
{
    public class UserInfoBLL : IUserInfoBLL
    {
        public string UserName { get; set; }
        public Person Person { get; set; }

        public string ShowMsg()
        {
            return $"Hello World:{UserName},Age:{Person.Age}";
        }
    }
}
