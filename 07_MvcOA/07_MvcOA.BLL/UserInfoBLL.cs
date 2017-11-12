using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _07_MvcOA.Model;
using _07_MvcOA.IBLL;

namespace _07_MvcOA.BLL
{
    public class UserInfoBLL : BaseBLL<UserInfo>, IUserInfoBLL
    {
        /// <summary>
        /// 批量删除
        /// </summary>
        /// <param name="list">ID集合</param>
        /// <returns></returns>
        public bool DeleteEntities(List<int> list)
        {

            GetCurrentSession.UserInfoDal
                .LoadEntities(c => list.Contains(c.UserID))
                .ToList()
                .ForEach(k => GetCurrentSession.UserInfoDal.DeleteEntity(k));

            return GetCurrentSession.SaveChanges();
        }

        public override void SetCurrentDal()
        {
            CurrentDal = GetCurrentSession.UserInfoDal;
        }
    }
}
