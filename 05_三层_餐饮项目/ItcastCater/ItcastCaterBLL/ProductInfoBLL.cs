using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItcastCater.Model;
using ItcastCater.DAL;

namespace ItcastCater.BLL
{
    public class ProductInfoBLL
    {
        ProductInfoDAL dal = new ProductInfoDAL();

        /// <summary>
        /// 查询一个CatId下产品的数量
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int GetProductInfoCountByCatId(int id)
        {
            return Convert.ToInt32(dal.GetProductInfoCountByCatId(id));
        }
        /// <summary>
        /// 模糊查询产品数量获得产品信息
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public List<ProductInfo> GetProductInforByNum(string num)
        {
            return dal.GetProductInforByNum(num);
        }
        /// <summary>
        /// 通过CatId获取商品信息
        /// </summary>
        /// <param name="catId"></param>
        /// <returns></returns>
        public List<ProductInfo> GetProductInfoByCatId(int catId)
        {
            return dal.GetProductInfoByCatId(catId);
        }

        /// <summary>
        /// 通过id获取产品信息
        /// </summary>
        /// <param name="proId"></param>
        /// <returns></returns>
        public ProductInfo GetProductInfoById(int proId)
        {
            return dal.GetProductInfoById(proId);
        }

        /// <summary>
        /// 保存新增或修改的产品信息
        /// </summary>
        /// <param name="temp"></param>
        /// <param name="proi"></param>
        /// <returns></returns>
        public bool SaveProductInfo(int temp, ProductInfo proi)
        {
            int r = -1;
            if (temp == 1)//新增
            {
                r = dal.AddProductInfo(proi);
            }
            else if (temp == 2)//修改
            {
                r = dal.UpdateProductInfo(proi);
            }

            return r > 0 ? true : false;
        }

        /// <summary>
        /// 根据Id删除产品信息
        /// </summary>
        /// <param name="proId"></param>
        /// <returns></returns>
        public bool DeleteProductInfoById(int proId)
        {
            return dal.DeleteProductInfoById(proId) > 0 ? true : false;
        }

        /// <summary>
        /// 获得全部的产品信息
        /// </summary>
        /// <param name="delFlag"></param>
        /// <returns></returns>
        public List<ProductInfo> GetAllProductInfoByDelFlag(int delFlag)
        {
            return dal.GetAllProductInfoByDelFlag(delFlag);
        }
    }
}
