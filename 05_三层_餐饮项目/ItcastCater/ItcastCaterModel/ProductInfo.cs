using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItcastCater.Model
{
    public class ProductInfo
    {
        private int _proid;
        private int? _catid;
        private string _proname;
        private decimal? _procost;
        private string _prospell;
        private decimal? _proprice;
        private string _prounit;
        private string _remark;
        private int? _delflag;
        private DateTime? _subtime;
        private decimal? _prostock;
        private string _pronum;
        private int? _subby;

        /// <summary>
        /// 商品主键
        /// </summary>
        public int ProId { get => _proid; set => _proid = value; }

        /// <summary>
        /// 商品类型id
        /// </summary>
        public int? CatId { get => _catid; set => _catid = value; }

        /// <summary>
        /// 商品名字
        /// </summary>
        public string ProName { get => _proname; set => _proname = value; }

        /// <summary>
        /// 商品成本
        /// </summary>
        public decimal? ProCost { get => _procost; set => _procost = value; }

        /// <summary>
        /// 商品拼音
        /// </summary>
        public string ProSpell { get => _prospell; set => _prospell = value; }

        /// <summary>
        /// 商品实际价格
        /// </summary>
        public decimal? ProPrice { get => _proprice; set => _proprice = value; }

        /// <summary>
        /// 商品单位
        /// </summary>
        public string ProUnit { get => _prounit; set => _prounit = value; }

        /// <summary>
        /// 商品备注
        /// </summary>
        public string Remark { get => _remark; set => _remark = value; }
        /// <summary>
        /// 商品删除标识
        /// </summary>
        public int? DelFlag { get => _delflag; set => _delflag = value; }

        /// <summary>
        /// 商品提交时间
        /// </summary>
        public DateTime? SubTime { get => _subtime; set => _subtime = value; }

        /// <summary>
        /// 商品库存
        /// </summary>
        public decimal? ProStock { get => _prostock; set => _prostock = value; }

        /// <summary>
        /// 商品编号
        /// </summary>
        public string ProNum { get => _pronum; set => _pronum = value; }

        /// <summary>
        /// 商品提交人
        /// </summary>
        public int? SubBy { get => _subby; set => _subby = value; }
    }
}
