using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItcastCater.DAL;
using ItcastCater.Model;

namespace ItcastCater.BLL
{
    public class CategoryInfoBLL
    {
        CategoryInfoDAL dal = new CategoryInfoDAL();
        /// <summary>
        /// 查询所有的商品信息
        /// </summary>
        /// <returns>商品信息的集合</returns>
        public List<CategoryInfo> GetAllCategoryInfo(int delFlag)
        {
            return dal.GetAllCategoryInfo(delFlag);
        }
    }
}
