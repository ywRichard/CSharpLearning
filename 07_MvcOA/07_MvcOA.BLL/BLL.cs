 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _07_MvcOA.Model;
using _07_MvcOA.IBLL;

namespace _07_MvcOA.BLL
{
	
	public partial class ActionInfoBLL :BaseBLL<ActionInfo>,IActionInfoBLL
    {
        public override void SetCurrentDal()
        {
            CurrentDal = GetCurrentSession.ActionInfoDal;
        }
    }   
	
	public partial class DepartmentBLL :BaseBLL<Department>,IDepartmentBLL
    {
        public override void SetCurrentDal()
        {
            CurrentDal = GetCurrentSession.DepartmentDal;
        }
    }   
	
	public partial class R_UserInfo_ActionInfoBLL :BaseBLL<R_UserInfo_ActionInfo>,IR_UserInfo_ActionInfoBLL
    {
        public override void SetCurrentDal()
        {
            CurrentDal = GetCurrentSession.R_UserInfo_ActionInfoDal;
        }
    }   
	
	public partial class RoleInfoBLL :BaseBLL<RoleInfo>,IRoleInfoBLL
    {
        public override void SetCurrentDal()
        {
            CurrentDal = GetCurrentSession.RoleInfoDal;
        }
    }   
	
	public partial class UserInfoBLL :BaseBLL<UserInfo>,IUserInfoBLL
    {
        public override void SetCurrentDal()
        {
            CurrentDal = GetCurrentSession.UserInfoDal;
        }
    }   
	
}