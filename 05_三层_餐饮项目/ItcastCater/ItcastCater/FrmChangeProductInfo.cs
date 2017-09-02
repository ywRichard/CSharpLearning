using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ItcastCater.Model;
using ItcastCater.BLL;

namespace ItcastCater
{
    public partial class FrmChangeProductInfo : Form
    {
        private int _tp;
        public FrmChangeProductInfo()
        {
            InitializeComponent();
        }

        public void Frm_SetText(object sender, EventArgs e)
        {

            var mea = e as MyEventArgs;
            _tp = mea.Temp;
            LoadCategoryInfoToCmb();

            if (_tp == 1)//新增
            {
                cmbCategory.Text = "香烟";

                foreach (var c in this.Controls)
                {
                    if (c is TextBox)
                    {
                        ((TextBox)c).Text = "";
                    }
                }
            }
            else if (_tp == 2)//修改
            {
                var proi = mea.Obj as ProductInfo;
                cmbCategory.SelectedValue = proi.CatId;
                txtName.Text = proi.ProName;
                txtCost.Text = proi.ProCost.ToString();
                txtNum.Text = proi.ProNum;
                txtPrice.Text = proi.ProPrice.ToString();
                txtRemark.Text = proi.Remark;
                txtSpell.Text = proi.ProSpell;
                txtStock.Text = proi.ProStock.ToString();
                txtUnit.Text = proi.ProUnit;
                labId.Text = proi.ProId.ToString();
            }
        }

        private void LoadCategoryInfoToCmb()
        {
            var bll = new CategoryInfoBLL();
            var list = bll.GetAllCategoryInfoByDelFlag(0);
            cmbCategory.DataSource = list;
            cmbCategory.DisplayMember = "CatName";
            cmbCategory.ValueMember = "CatId";
        }

        private string[] GetAllCategoryName()
        {
            var bll = new CategoryInfoBLL();
            return bll.GetAllCategoryInfoByDelFlag(0).Select(ci => ci.CatName).ToArray();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (CheckTextBox())
            {
                
                var proi = new ProductInfo();
                proi.ProCost = Convert.ToDecimal(txtCost.Text);
                proi.ProName = txtName.Text;
                proi.ProNum = txtNum.Text;
                proi.ProPrice = Convert.ToDecimal(txtPrice.Text);
                proi.ProSpell = txtSpell.Text;
                proi.ProStock = Convert.ToDecimal(txtStock.Text);
                proi.ProUnit = txtUnit.Text;
                proi.Remark = txtRemark.Text;
                proi.CatId = Convert.ToInt32(cmbCategory.SelectedValue);

                if (_tp == 1)//新增
                {
                    proi.DelFlag = 0;
                    proi.SubTime = DateTime.Now;
                    proi.SubBy = 1;
                }
                else if (_tp == 2)//修改
                {
                    proi.ProId = Convert.ToInt32(labId.Text);
                }

                var proiBLL = new ProductInfoBLL();
                var msg = proiBLL.SaveProductInfo(_tp, proi) ? "操作成功" : "操作失败";
                MessageBox.Show(msg);
                this.Close();
            }
        }

        private bool CheckTextBox()
        {
            if (cmbCategory.Text == "")
            {
                MessageBox.Show("商品类别不能为空");
                return false;
            }
            if (txtCost.Text == "")
            {
                MessageBox.Show("商品成本不能为空");
                return false;
            }
            if (txtName.Text == "")
            {
                MessageBox.Show("商品名称不能为空");
                return false;
            }
            if (txtNum.Text == "")
            {
                MessageBox.Show("商品数量不能为空");
                return false;
            }
            if (txtPrice.Text == "")
            {
                MessageBox.Show("商品价格不能为空");
                return false;
            }
            if (txtRemark.Text == "")
            {
                MessageBox.Show("商品备注不能为空");
                return false;
            }
            if (txtSpell.Text == "")
            {
                MessageBox.Show("商品拼音不能为空");
                return false;
            }
            if (txtStock.Text == "")
            {
                MessageBox.Show("商品库存不能为空");
                return false;
            }
            if (txtUnit.Text == "")
            {
                MessageBox.Show("商品单位不能为空");
                return false;
            }

            return true;
        }
    }
}
