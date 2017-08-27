using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using ItcastCater.Model;
using System.Data;

namespace ItcastCater.DAL
{
    public class MemberInfoDAL
    {
        /// <summary>
        /// 根据id修改会员的删除标识
        /// </summary>
        /// <param name="memberId"></param>
        /// <returns>收影响的行数</returns>
        public int DeleteMemberInfoByMemberId(int memberId)
        {
            var sql = "update MemmberInfo set DelFlag=1 where MemmberId=" + memberId;
            return SqliteHelper.ExecuteNonQuery(sql);
        }

        /// <summary>
        /// 根据删除标志查询结果
        /// </summary>
        /// <param name="delFlag">0: 未删除;1: 删除</param>
        /// <returns></returns>
        public List<MemberInfo> GetAllMemberInfoByDelFlag(int delFlag)
        {
            string sql = "select MemmberId,Memname,MemMobilePhone,MemAddress,MemType,MemNum,MemGender,MemDiscount,MemMoney,SubTime,MemIntegral,MemEndServerTime,MemBirthdaty from MemmberInfo where DelFlag=@DelFlag";

            var dt = SqliteHelper.ExecuteTable(sql, new SQLiteParameter("@DelFlag", delFlag));
            List<MemberInfo> list = new List<MemberInfo>();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    list.Add(RowToMemberInfo(dr));
                }
            }

            return list;

        }

        ////关系转对象
        private MemberInfo RowToMemberInfo(DataRow dr)
        {
            MemberInfo mem = new MemberInfo();

            mem.MemAddress = dr["MemAddress"].ToString();
            mem.MemBirthday = Convert.ToDateTime(dr["MemBirthdaty"]);
            mem.MemDiscount = Convert.ToDecimal(dr["MemDiscount"]);
            mem.MemEndServerTime = Convert.ToDateTime(dr["MemEndServerTime"]);
            mem.MemGender = dr["MemGender"].ToString();
            mem.MemIntegral = Convert.ToInt32(dr["MemIntegral"]);
            mem.MemberId = Convert.ToInt32(dr["MemmberId"]);
            mem.MemMobilePhone = dr["MemMobilePhone"].ToString();
            mem.MemMoney = Convert.ToDecimal(dr["MemMoney"]);
            mem.MemName = dr["MemName"].ToString();
            mem.MemNum = dr["MemNum"].ToString();
            mem.MemPhone = mem.MemMobilePhone;
            mem.MemType = Convert.ToInt32(dr["MemType"]);
            mem.SubTime = Convert.ToDateTime(dr["SubTime"]);

            return mem;
        }
    }
}
