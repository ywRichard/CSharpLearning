 

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
	
	public partial class BookBLL :BaseBLL<Book>,IBookBLL
    {
        public override void SetCurrentDal()
        {
            CurrentDal = GetCurrentSession.BookDal;
        }
    }   
	
	public partial class DepartmentBLL :BaseBLL<Department>,IDepartmentBLL
    {
        public override void SetCurrentDal()
        {
            CurrentDal = GetCurrentSession.DepartmentDal;
        }
    }   
	
	public partial class KeywordsRankBLL :BaseBLL<KeywordsRank>,IKeywordsRankBLL
    {
        public override void SetCurrentDal()
        {
            CurrentDal = GetCurrentSession.KeywordsRankDal;
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
	
	public partial class SearchDetailsBLL :BaseBLL<SearchDetails>,ISearchDetailsBLL
    {
        public override void SetCurrentDal()
        {
            CurrentDal = GetCurrentSession.SearchDetailsDal;
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