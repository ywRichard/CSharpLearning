using _07_MvcOA.IDAL;
using _07_MvcOA.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_MvcOA.IBLL
{
    public partial interface IUserInfoBLL
    {
        bool DeleteEntities(List<int> list);
        IQueryable<UserInfo> LoadSearchEntities(UserInfoParam userInfoParam);
        bool SetUserOrderInfo(int userId, List<int> roleIdList);
        bool SetUserActionInfo(int userId, int actionId, bool isPass);
        bool DeleteUserActionInfo(int userId, int actionId);
    }
}
