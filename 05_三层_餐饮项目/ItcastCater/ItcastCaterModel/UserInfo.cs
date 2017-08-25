using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItcastCater.Model
{
    public class UserInfo
    {
        private int _userId;
        private string _userName;
        private string _loginUserName;
        private string _pwd;
        private DateTime _lastLoginTime;
        private string _lastLoginIP;
        private int _delFlag;
        private DateTime _subTime;

        public int UserId { get => _userId; set => _userId = value; }
        public string UserName { get => _userName; set => _userName = value; }
        public string LoginUserName { get => _loginUserName; set => _loginUserName = value; }
        public string Pwd { get => _pwd; set => _pwd = value; }
        public DateTime LastLoginTime { get => _lastLoginTime; set => _lastLoginTime = value; }
        public string LastLoginIP { get => _lastLoginIP; set => _lastLoginIP = value; }
        public int DelFlag { get => _delFlag; set => _delFlag = value; }
        public DateTime SubTime { get => _subTime; set => _subTime = value; }


    }
}
