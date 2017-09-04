using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItcastCater.DAL;
using ItcastCater.Model;

namespace ItcastCater.BLL
{
    public class MemberTypeBLL
    {
        MemberTypeDAL dal = new MemberTypeDAL();

        /// <summary>
        /// 通过会员级别查询级别名称
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public string GetMemberTypeByType(int type)
        {
            return DBNull.Value != dal.GetMemberTypeByType(type) ? dal.GetMemberTypeByType(type).ToString() : "";
        }

        /// <summary>
        /// 查询所有的会员等级
        /// </summary>
        /// <param name="delFlag"></param>
        /// <returns>会员等级的集合</returns>
        public List<MemberType> GetAllMemberTypeByDelFlag(int delFlag)
        {
            return dal.GetAllMemberTypeByDelFlag(delFlag);
        }
    }
}
