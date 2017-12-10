using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using IBLL;

namespace BLL
{
    public class UserInfoBLL : IUserInfoBLL
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
    }
}
