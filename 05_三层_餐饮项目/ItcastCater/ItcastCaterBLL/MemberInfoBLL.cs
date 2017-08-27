using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItcastCater.Model;
using ItcastCater.DAL;

namespace ItcastCater.BLL
{
    public class MemberInfoBLL
    {
        MemberInfoDAL dal = new MemberInfoDAL();

        /// <summary>
        /// 根据id修改会员的删除标识
        /// </summary>
        /// <param name="memberId"></param>
        /// <returns>是否更改成功</returns>
        public bool DeleteMemberInfoByMemberId(int memberId)
        {
            return dal.DeleteMemberInfoByMemberId(memberId) > 0 ? true : false;
        }
       
        /// <summary>
        /// 根据删除标志查询结果
        /// </summary>
        /// <param name="delFlag">0: 未删除;1: 删除</param>
        /// <returns></returns>
        public List<MemberInfo> GetAllMemberInfoByDelFlag(int delFlag)
        {
            return dal.GetAllMemberInfoByDelFlag(delFlag);
        }
    }
}
