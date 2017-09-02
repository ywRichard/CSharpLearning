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
        CategoryInfoBLL catBLL = new CategoryInfoBLL();
        ProductInfoBLL proiBll = new ProductInfoBLL();

        public EventHandler evt { get; set; }

        public FrmCategroy()
        {
            InitializeComponent();
        }

        private void FrmCategroy_Load(object sender, EventArgs e)
        {
            LoadCategoryInfoByDelFlag(0);//加载商品信息
            LoadProductInfoByDelFlag(0);//加载产品信息

            LoadCategoryInfoToCmb();
        }

        private void LoadCategoryInfoToCmb()
        {
            var list = catBLL.GetAllCategoryInfoByDelFlag(0);
            list.Insert(0, new CategoryInfo { CatId = -1, CatName = "请选择" });
            cmbCategory.DataSource = list;
            cmbCategory.DisplayMember = "CatName";
            cmbCategory.ValueMember = "CatId";
        }

        private void LoadProductInfoByDelFlag(int delFlag)
        {
            dgvProductInfo.AutoGenerateColumns = false;
            dgvProductInfo.DataSource = proiBll.GetAllProductInfoByDelFlag(delFlag);
            dgvProductInfo.SelectedRows[0].Selected = false;
        }

        private void LoadCategoryInfoByDelFlag(int delFlag)
        {
            dgvCategoryInfo.AutoGenerateColumns = false;
            dgvCategoryInfo.DataSource = catBLL.GetAllCategoryInfoByDelFlag(delFlag);
            dgvCategoryInfo.SelectedRows[0].Selected = false;

        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            LoadFrmChangeCategoryInfo(1);//新增
        }

        MyEventArgs mea = new MyEventArgs();
        private void btnUpdateCategory_Click(object sender, EventArgs e)
        {
            if (dgvCategoryInfo.SelectedRows.Count > 0)
            {
                var id = Convert.ToInt32(dgvCategoryInfo.SelectedRows[0].Cells[0].Value);
                mea.Obj = catBLL.GetCategoryInfoByID(id);
                LoadFrmChangeCategoryInfo(2);//修改
            }
            else
            {
                MessageBox.Show("未选中需要修改的行");
            }

        }


        /// <summary>
        /// 新增和修改
        /// </summary>
        /// <param name="p">1->新增； 2->修改</param>
        private void LoadFrmChangeCategoryInfo(int p)
        {
            var frm = new FrmChangeCategoryInfo();
            if (p == 1)
            {
                frm.Text = "新增商品信息";
            }
            else if (p == 2)
            {
                frm.Text = "修改商品信息";
            }
            this.evt += new EventHandler(frm.SetText);

            if (evt != null)
            {
                mea.Temp = p;
                evt(this, mea);
                frm.FormClosed += new FormClosedEventHandler(Frm_Closed);
                frm.ShowDialog();
            }
        }

        private void Frm_Closed(object sender, FormClosedEventArgs e)
        {
            LoadCategoryInfoByDelFlag(0);
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            if (dgvCategoryInfo.SelectedRows.Count > 0)
            {
                var id = Convert.ToInt32(dgvCategoryInfo.SelectedRows[0].Cells[0].Value);

                if (proiBll.GetProductInfoCountByCatId(id) > 0)
                {
                    MessageBox.Show("该商品目录下有产品，不能删除");
                }
                else
                {
                    var msg = catBLL.DeleteCategoryInfoById(id) ? "删除成功" : "删除失败";

                    MessageBox.Show(msg);
                    LoadCategoryInfoByDelFlag(0);
                }
            }
            else
            {
                MessageBox.Show("未选中要删除的行");
            }
        }

        private void btnAddPro_Click(object sender, EventArgs e)
        {
            LoadFrmChangeProductInfo(1);
        }

        private void btnUpdatePro_Click(object sender, EventArgs e)
        {
            if (dgvProductInfo.SelectedRows.Count > 0)
            {
                var id = Convert.ToInt32(dgvProductInfo.SelectedRows[0].Cells[0].Value);
                mea.Obj = proiBll.GetProductInfoById(id);
                LoadFrmChangeProductInfo(2);
            }
            else
            {
                MessageBox.Show("未选中行");
            }
        }

        private void LoadFrmChangeProductInfo(int p)
        {
            var fcp = new FrmChangeProductInfo();
            if (p == 1)//新增
            {
                fcp.Text = "新增产品信息";
            }
            else if (p == 2)//修改
            {
                fcp.Text = "修改产品信息";
            }
            this.evt += new EventHandler(fcp.Frm_SetText);
            if (this.evt != null)
            {
                mea.Temp = p;
                evt(this, mea);
                fcp.FormClosed += new FormClosedEventHandler(Fcp_Closed);
                fcp.ShowDialog();
            }
        }

        private void Fcp_Closed(object sender, FormClosedEventArgs e)
        {
            LoadProductInfoByDelFlag(0);
        }

        private void btnDeletePro_Click(object sender, EventArgs e)
        {
            if (dgvProductInfo.SelectedRows.Count > 0)
            {
                if (DialogResult.OK == MessageBox.Show("确定删除", "删除", MessageBoxButtons.OKCancel))
                {
                    var proId = Convert.ToInt32(dgvProductInfo.SelectedRows[0].Cells[0].Value);
                    var msg = proiBll.DeleteProductInfoById(proId) ? "删除成功" : "删除失败";
                    MessageBox.Show(msg);
                    LoadProductInfoByDelFlag(0);
                }
            }
            else
            {
                MessageBox.Show("未选中要删除的行");
            }
        }

        private void cmbCategory_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbCategory.SelectedIndex != 0)
            {
                var id = Convert.ToInt32(cmbCategory.SelectedValue);
                dgvProductInfo.DataSource = proiBll.GetProductInfoByCatId(id);
            }
            else
            {
                LoadCategoryInfoByDelFlag(0);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvProductInfo.AutoGenerateColumns = false;
            dgvProductInfo.DataSource = proiBll.GetProductInforByNum(txtSearch.Text);
            if (dgvProductInfo.SelectedRows.Count > 0)
            {
                dgvProductInfo.SelectedRows[0].Selected = false;
            }
        }
    }
}
