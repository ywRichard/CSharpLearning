 

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
		
	    public static IActionInfoDal CreateActionInfoDal()
        {
            string classFulleName = NameSpace+ ".ActionInfoDal";
            return CreateInstance(classFulleName) as IActionInfoDal;
        }
		
	    public static IDepartmentDal CreateDepartmentDal()
        {
            string classFulleName = NameSpace+ ".DepartmentDal";
            return CreateInstance(classFulleName) as IDepartmentDal;
        }
		
	    public static IR_UserInfo_ActionInfoDal CreateR_UserInfo_ActionInfoDal()
        {
            string classFulleName = NameSpace+ ".R_UserInfo_ActionInfoDal";
            return CreateInstance(classFulleName) as IR_UserInfo_ActionInfoDal;
        }
		
	    public static IRoleInfoDal CreateRoleInfoDal()
        {
            string classFulleName = NameSpace+ ".RoleInfoDal";
            return CreateInstance(classFulleName) as IRoleInfoDal;
        }
		
	    public static IUserInfoDal CreateUserInfoDal()
        {
            string classFulleName = NameSpace+ ".UserInfoDal";
            return CreateInstance(classFulleName) as IUserInfoDal;
        }
	}
}