using _07_MvcOA.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _07_MvcOA.IBLL;

namespace _07_MvcOA.BLL
{
    public partial class ActionInfoBLL : BaseBLL<ActionInfo>, IActionInfoBLL
    {
        /// <summary>
        /// 删除权限
        /// </summary>
        /// <param name="listId"></param>
        /// <returns></returns>
        public bool DeleteEntities(List<int> listId)
        {
            GetCurrentSession.ActionInfoDal.LoadEntities(a => listId.Contains(a.ID)).ToList()
               .ForEach(a => GetCurrentSession.ActionInfoDal.DeleteEntity(a));

            return GetCurrentSession.SaveChanges();
        }
        /// <summary>
        /// 为权限分配角色
        /// </summary>
        /// <param name="actionId"></param>
        /// <param name="roleIdList"></param>
        /// <returns></returns>
        public bool SetActionRoleInfo(int actionId, List<int> roleIdList)
        {
            var actionInfo = this.GetCurrentSession.ActionInfoDal
                .LoadEntities(a => a.ID == actionId)
                .FirstOrDefault();

            if (actionInfo != null)
            {
                actionInfo.RoleInfo.Clear();
                foreach (var roleId in roleIdList)
                {
                    var roleInfo = this.GetCurrentSession.RoleInfoDal
                        .LoadEntities(r => r.ID == roleId)
                        .FirstOrDefault();
                    actionInfo.RoleInfo.Add(roleInfo);
                }
                return GetCurrentSession.SaveChanges();
            }
            else
            {
                return false;
            }
        }
    }
}
