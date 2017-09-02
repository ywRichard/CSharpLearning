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
        /// 根据Id删除商品信息
        /// </summary>
        /// <param name="catId"></param>
        /// <returns></returns>
        public int DeleteCategoryInfoById(int catId)
        {
            var sql = "update CategoryInfo set DelFlag=1 where CatId=" + catId;

            return SqliteHelper.ExecuteNonQuery(sql);
        }

        /// <summary>
        /// 新增
        /// </summary>
        public int AddCategoryInfo(CategoryInfo cti)
        {
            var sql = "insert into CategoryInfo(CatName, CatNum, Remark, DelFlag, SubTime) values(@CatName,@CatNum,@Remark,@DelFlag,@SubTime)";

            return AddAndUpateCategoryInfo(1, sql, cti);
        }

        /// <summary>
        /// 修改
        /// </summary>
        public int UpdateCategoryInfo(CategoryInfo cti)
        {
            var sql = "update CategoryInfo set CatName=@CatName,CatNum=@CatNum,Remark=@Remark where CatId=@CatId";

            return AddAndUpateCategoryInfo(2, sql, cti);
        }

        private int AddAndUpateCategoryInfo(int p, string sql, CategoryInfo cti)
        {
            List<SQLiteParameter> list = new List<SQLiteParameter>
            {
                new SQLiteParameter("@CatName",cti.CatName),
                new SQLiteParameter("@CatNum",cti.CatNum),
                new SQLiteParameter("@Remark",cti.Remark),
            };
            if (p == 1)
            {
                list.Add(new SQLiteParameter("@DelFlag", cti.DelFlag));
                list.Add(new SQLiteParameter("@Subtime", cti.Subtime));
            }
            else if (p == 2)
            {
                list.Add(new SQLiteParameter("@CatId", cti.CatId));
            }

            return SqliteHelper.ExecuteNonQuery(sql, list.ToArray());
        }

        /// <summary>
        /// 通过id查询商品信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public CategoryInfo GetCategoryInfoByID(int id)
        {
            var sql = "select CatId,CatName,CatNum,Remark from CategoryInfo where CatId=@CatId";

            var ci = new CategoryInfo();
            var dt = SqliteHelper.ExecuteTable(sql, new SQLiteParameter("@CatId", id));
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    ci = RowToCategoryInfo(dr);
                }
            }

            return ci;
        }

        /// <summary>
        /// 查询所有的商品信息
        /// </summary>
        /// <returns>商品信息的集合</returns>
        public List<CategoryInfo> GetAllCategoryInfoByDelFlag(int delFlag)
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
