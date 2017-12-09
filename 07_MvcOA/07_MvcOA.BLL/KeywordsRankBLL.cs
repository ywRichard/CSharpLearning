using _07_MvcOA.IBLL;
using _07_MvcOA.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_MvcOA.BLL
{
    public partial class KeywordsRankBLL : BaseBLL<KeywordsRank>, IKeywordsRankBLL
    {
        /// <summary>
        /// 删除汇总表中的数据
        /// </summary>
        /// <returns></returns>
        public bool DeleteAllKeywords()
        {
            var sql = "truncate table KeywordsRank";
            return this.GetCurrentSession.ExecuteSql(sql) > 0;
        }
        /// <summary>
        /// 向汇总表中插入数据
        /// </summary>
        /// <returns></returns>
        public bool InsertKeywords()
        {
            var sql = "insert into KeywordsRank(Id,Keywords,SearchCount) select newid(),Keywords,Count(*) from SearchDetails where DateDiff(day,SearchDateTime,getdate())<=7 group by Keywords";
            return this.GetCurrentSession.ExecuteSql(sql) > 0;
        }
        /// <summary>
        /// 返回热词
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public List<string> GetSearchWord(string str)
        {
            var sql = "select top 10 keywords from keywordsRank where Keywords like @msg orderby";
            return this.GetCurrentSession.ExecuteSelectQuery<string>(sql, new System.Data.SqlClient.SqlParameter("@msg", str + "%"));
        }
    }
}
