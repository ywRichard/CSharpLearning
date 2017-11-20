 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _07_MvcOA.DAL;
using _07_MvcOA.IDAL;
using _07_MvcOA.Model;
using System.Data.Entity;

namespace _07_MvcOA.DALFactory
{
	public partial class DBSession : IDBSession
    {
	
		private IUserInfoDal _UserInfoDal;
        public IUserInfoDal UserInfoDal
        {
            get
            {
                if(_UserInfoDal == null)
                {
                    _UserInfoDal = AbstractFactory.CreateUserInfoDal();
                }
                return _UserInfoDal;
            }
            set { _UserInfoDal = value; }
        }
	}	
}