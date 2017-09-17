using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itcaster.Web.Model
{
    public class UserInfo
    {
        private int _id;
        private string _userName;
        private string _userPass;
        private DateTime _regTime;
        private string _email;

        public int ID { get => _id; set => _id = value; }
        public string UserName { get => _userName; set => _userName = value; }
        public string UserPass { get => _userPass; set => _userPass = value; }
        public DateTime RegTime { get => _regTime; set => _regTime = value; }
        public string Email { get => _email; set => _email = value; }
    }
}
