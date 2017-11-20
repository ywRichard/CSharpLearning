 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _07_MvcOA.Model;
using _07_MvcOA.IBLL;

namespace _07_MvcOA.BLL
{
	
	public partial class UserInfoBLL :BaseBLL<UserInfo>,IUserInfoBLL
    {
        public override void SetCurrentDal()
        {
            CurrentDal = GetCurrentSession.UserInfoDal;
        }
    }   
	
}