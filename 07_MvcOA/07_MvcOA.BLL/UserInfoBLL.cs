using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _07_MvcOA.Model;
using _07_MvcOA.IBLL;

namespace _07_MvcOA.BLL
{
    public partial class UserInfoBLL
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

        public IQueryable<UserInfo> LoadSearchEntities(UserInfoParam userInfoParam)
        {
            var delFlag = (short)DelFlagEnum.Normal;
            var skipCount = (userInfoParam.PageIndex - 1) * userInfoParam.PageSize;
            var temp = GetCurrentSession.UserInfoDal.LoadEntities(u => u.DelFlag == delFlag);
            if (!string.IsNullOrEmpty(userInfoParam.UserName))
            {
                temp = temp.Where(u => u.UserName.Contains(userInfoParam.UserName));
            }
            if (!string.IsNullOrEmpty(userInfoParam.Remark))
            {
                temp = temp.Where(u => u.Remark.Contains(userInfoParam.Remark));
            }
            userInfoParam.TotalCount = temp.Count();

            return temp.OrderBy(u => u.UserID)
                       .Skip(skipCount)
                       .Take(userInfoParam.PageSize);
        }
    }
}
