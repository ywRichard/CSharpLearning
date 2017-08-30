using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItcastCater.Model
{
    public class CategoryInfo
    {
        private int _catId;
        private string _catName;
        private string _catNum;
        private string _remark;
        private int? _delFlag;
        private DateTime? _subtim;
        private int? _subBy;

        /// <summary>
        /// 商品分类主键
        /// </summary>
        public int CatId { get => _catId; set => _catId = value; }

        /// <summary>
        /// 商品分类名字
        /// </summary>
        public string CatName { get => _catName; set => _catName = value; }

        /// <summary>
        /// 商品分类编号
        /// </summary>
        public string CatNum { get => _catNum; set => _catNum = value; }

        /// <summary>
        /// 商品分类备注
        /// </summary>
        public string Remark { get => _remark; set => _remark = value; }

        /// <summary>
        /// 商品分类删除标识
        /// </summary>
        public int? DelFlag { get => _delFlag; set => _delFlag = value; }

        /// <summary>
        /// 商品分类提交时间
        /// </summary>
        public DateTime? Subtim { get => _subtim; set => _subtim = value; }

        /// <summary>
        /// 商品分类提交人 
        /// </summary>
        public int? SubBy { get => _subBy; set => _subBy = value; }
    }
}
