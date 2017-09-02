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
        /// 根据Id删除商品信息
        /// </summary>
        /// <param name="categoryId"></param>
        /// <returns></returns>
        public bool DeleteCategoryInfoById(int categoryId)
        {
            return dal.DeleteCategoryInfoById(categoryId) > 0 ? true : false;
        }

        /// <summary>
        /// 保存新增或者修改会员的信息
        /// </summary>
        /// <param name="cti"></param>
        /// <param name="temp"></param>
        /// <returns></returns>
        public bool SaveCategoryInfoBLL(CategoryInfo cti, int temp)
        {
            int r = -1;

            if (temp == 1)//新增
            {
                r = dal.AddCategoryInfo(cti);
            }
            else if (temp == 2)//修改
            {
                r = dal.UpdateCategoryInfo(cti);
            }

            return r > 0;
        }

        /// <summary>
        /// 通过id查询商品信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public CategoryInfo GetCategoryInfoByID(int id)
        {
            return dal.GetCategoryInfoByID(id);
        }

        /// <summary>
        /// 查询所有的商品信息
        /// </summary>
        /// <returns>商品信息的集合</returns>
        public List<CategoryInfo> GetAllCategoryInfoByDelFlag(int delFlag)
        {
            return dal.GetAllCategoryInfoByDelFlag(delFlag);
        }
    }
}
