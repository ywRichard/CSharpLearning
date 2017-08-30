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

        //新增
        public int AddMemberInfo(MemberInfo mem)
        {
            var sql = "insert into MemmberInfo(MemName,MemMobilePhone,MemType,MemNum,MemGender,MemDiscount,MemMoney,DelFlag,SubTime,MemIntegral,MemEndServerTime,MemBirthdaty) values(@MemName,@MemMobilePhone,@MemType,@MemNum,@MemGender,@MemDiscount,@MemMoney,@DelFlag,@SubTime,@MemIntegral,@MemEndServerTime,@MemBirthdaty)";

            return AddAndUpdateMemberInfo(1, sql, mem);
        }
        //修改
        public int UpdateMemberInfo(MemberInfo mem)
        {
            var sql = "update MemmberInfo set MemName=@MemName,MemMobilePhone=@MemMobilePhone,MemType=@MemType,MemNum=@MemNum,MemGender=@MemGender,MemDiscount=@MemDiscount,MemMoney=@MemMoney,MemIntegral=@MemIntegral,MemEndServerTime=@MemEndServerTime,MemBirthdaty=@MemBirthdaty where MemmberId=@MemmberId";

            return AddAndUpdateMemberInfo(2, sql, mem);
        }

        private int AddAndUpdateMemberInfo(int temp, string sql, MemberInfo mem)
        {
            #region 初始化参数
            SQLiteParameter[] param =
                        {
                new SQLiteParameter("@MemName", mem.MemName),
                new SQLiteParameter("@MemMobilePhone", mem.MemMobilePhone),
                new SQLiteParameter("@MemType", mem.MemType),
                new SQLiteParameter("@MemNum", mem.MemNum),
                new SQLiteParameter("@MemGender", mem.MemGender),
                new SQLiteParameter("@MemDiscount", mem.MemDiscount),
                new SQLiteParameter("@MemMoney", mem.MemMoney),
                new SQLiteParameter("@MemIntegral", mem.MemIntegral),
                new SQLiteParameter("@MemEndServerTime", mem.MemEndServerTime),
                new SQLiteParameter("@MemBirthdaty", mem.MemBirthday),
            };
            #endregion

            var list = new List<SQLiteParameter>();
            list.AddRange(param);

            if (temp == 1)
            {
                list.Add(new SQLiteParameter("@DelFlag", mem.DelFlag));
                list.Add(new SQLiteParameter("@SubTime", mem.SubTime));
            }
            else if (temp == 2)
            {
                list.Add(new SQLiteParameter("@MemmberId", mem.MemberId));
            }

            return SqliteHelper.ExecuteNonQuery(sql, list.ToArray());
        }


        /// <summary>
        /// 根据id查对象
        /// </summary>
        /// <param name="id">会员的id</param>
        /// <returns>会员的对象</returns>
        public MemberInfo GetMemberInfoByMemberId(int id)
        {
            var sql = "select * from MemmberInfo where DelFlag=0 and MemmberId=" + id;

            var dt = SqliteHelper.ExecuteTable(sql);
            MemberInfo mem = null;
            if (dt.Rows.Count > 0)
            {
                mem = RowToMemberInfo(dt.Rows[0]);
            }

            return mem;
        }

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
