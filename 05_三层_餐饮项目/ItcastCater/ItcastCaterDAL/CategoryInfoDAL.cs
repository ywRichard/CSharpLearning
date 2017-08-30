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
    public class CategoryInfoDAL
    {
        /// <summary>
        /// 查询所有的商品信息
        /// </summary>
        /// <returns>商品信息的集合</returns>
        public List<CategoryInfo> GetAllCategoryInfo(int delFlag)
        {
            var sql = "select CatId,CatName,CatNum,Remark from CategoryInfo where DelFlag=" + delFlag;

            var list = new List<CategoryInfo>();
            var dt = SqliteHelper.ExecuteTable(sql);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    list.Add(RowToCategoryInfo(dr));
                }
            }

            return list;
        }

        private CategoryInfo RowToCategoryInfo(DataRow dr)
        {
            var ci = new CategoryInfo
            {
                CatId = Convert.ToInt32(dr["CatId"]),
                CatName = dr["CatName"].ToString(),
                CatNum = dr["CatNum"].ToString(),
                Remark = dr["Remark"].ToString()
            };

            return ci;
        }
    }
}
