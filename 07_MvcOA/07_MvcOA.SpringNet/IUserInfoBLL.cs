using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_MvcOA.SpringNet
{
    public interface IUserInfoBLL
    {
        string UserName { get; set; }
        Person Person { get; set; }
        string ShowMsg();
    }
}
