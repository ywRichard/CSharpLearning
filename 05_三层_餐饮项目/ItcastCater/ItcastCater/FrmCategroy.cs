using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ItcastCater.BLL;
using ItcastCater.Model;

namespace ItcastCater
{
    public partial class FrmCategroy : Form
    {
        public FrmCategroy()
        {
            InitializeComponent();
        }

        private void FrmCategroy_Load(object sender, EventArgs e)
        {
            LoadCategoryInfo(0);//加载商品信息
            LoadProductInfo(0);//加载产品信息

        }

        private void LoadProductInfo(int delFlag)
        {
            var bll = new ProductInfoBLL();
            dgvProductInfo.AutoGenerateColumns = false;
            dgvProductInfo.DataSource = bll.GetAllProductInfo(delFlag);
            dgvProductInfo.SelectedRows[0].Selected = false;
        }

        private void LoadCategoryInfo(int delFlag)
        {
            var bll = new CategoryInfoBLL();
            dgvCategoryInfo.AutoGenerateColumns = false;
            dgvCategoryInfo.DataSource = bll.GetAllCategoryInfo(delFlag);
            dgvCategoryInfo.SelectedRows[0].Selected = false;

        }
    }
}
