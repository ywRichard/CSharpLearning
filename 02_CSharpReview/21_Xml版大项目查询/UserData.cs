using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _21_Xml版大项目查询
{
    class UserData
    {
        string _id;

        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }
        string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        string _password;

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
    }
}
