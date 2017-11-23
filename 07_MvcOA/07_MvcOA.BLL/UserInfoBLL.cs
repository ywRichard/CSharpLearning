using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _07_MvcOA.Model;
using _07_MvcOA.IBLL;

namespace _07_MvcOA.BLL
{
    public partial class UserInfoBLL : BaseBLL<UserInfo>, IUserInfoBLL
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
        /// <summary>
        /// 条件搜索
        /// </summary>
        /// <param name="userInfoParam"></param>
        /// <returns></returns>
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
        /// <summary>
        /// 为用户分配角色
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="roleIdList"></param>
        /// <returns></returns>
        public bool SetUserOrderInfo(int userId, List<int> roleIdList)
        {
            var result = false;
            //获取要分配的用户信息
            var userInfo = GetCurrentSession.UserInfoDal.LoadEntities(u => u.UserID == userId).FirstOrDefault();
            if (userInfo!=null)
            {
                //我的实现:
                //直接向中间表插入userid和roleIdList，完成角色的分配。但是这样就是直接操作数据库，和EF还有导航属性无关。

                //EF的实现：直接利用导航属性来操作中间表。
                //删除用户已有的角色
                userInfo.RoleInfo.Clear();
                foreach (var roleId in roleIdList)
                {
                    var roleInfo = GetCurrentSession.RoleInfoDal.LoadEntities(r => r.ID == roleId).FirstOrDefault();
                    userInfo.RoleInfo.Add(roleInfo);//给用户分配角色
                }

                //调用SaveChanges()之前，所有的操作都在内存中完成，不会操作数据库。
                result = GetCurrentSession.SaveChanges();
            }
            return result;
        }
    }
}
