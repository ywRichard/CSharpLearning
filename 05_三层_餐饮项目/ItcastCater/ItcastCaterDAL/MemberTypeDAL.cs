using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using ItcastCater.Model;

namespace ItcastCater.DAL
{
    public class MemberTypeDAL
    {
        /// <summary>
        /// 查询所有的会员等级
        /// </summary>
        /// <param name="delFlag"></param>
        /// <returns>会员等级的集合</returns>
        public List<MemberType> GetAllMemberTypeByDelFlag(int delFlag)
        {
            var sql = "select MemType, MemTpName from MemmberType where DelFlag=" + delFlag;
            var dt = SqliteHelper.ExecuteTable(sql);
            var list = new List<MemberType>();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    list.Add(RowToMemberType(dr));
                }
            }

            return list;
        }

        private MemberType RowToMemberType(DataRow dr)
        {
            var mt = new MemberType();
            mt.MemType =Convert.ToInt32(dr["MemType"]);
            mt.MemTpName = dr["MemTpName"].ToString();

            return mt;
        }
    }
}
