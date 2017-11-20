 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_MvcOA.IDAL
{
	public partial interface IDBSession
    {
	
		IUserInfoDal UserInfoDal{get;set;}
	}	
}