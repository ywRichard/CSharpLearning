 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Dynamic;
using _07_MvcOA.IDAL;
using System.Reflection;

namespace _07_MvcOA.DALFactory
{
    public partial class AbstractFactory
    {
		
	    public static IUserInfoDal CreateUserInfoDal()
        {
            string classFulleName = NameSpace+ ".UserInfoDAL";
            return CreateInstance(classFulleName) as IUserInfoDal;
        }
	}
}