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
        CategoryInfoBLL bll = new CategoryInfoBLL();

        public EventHandler evtCategoryInfo { get; set; }

        public FrmCategroy()
        {
            InitializeComponent();
        }

        private void FrmCategroy_Load(object sender, EventArgs e)
        {
            LoadCategoryInfoByDelFlag(0);//加载商品信息
            LoadProductInfo(0);//加载产品信息

        }

        private void LoadProductInfo(int delFlag)
        {
            var bll = new ProductInfoBLL();

            dgvProductInfo.AutoGenerateColumns = false;
            dgvProductInfo.DataSource = bll.GetAllProductInfo(delFlag);
            dgvProductInfo.SelectedRows[0].Selected = false;
        }

        private void LoadCategoryInfoByDelFlag(int delFlag)
        {
            var bll = new CategoryInfoBLL();

            dgvCategoryInfo.AutoGenerateColumns = false;
            dgvCategoryInfo.DataSource = bll.GetAllCategoryInfoByDelFlag(delFlag);
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
                mea.Obj = bll.GetCategoryInfoByID(id);
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
            this.evtCategoryInfo += new EventHandler(frm.SetText);
            mea.Temp = p;
            if (evtCategoryInfo != null)
            {
                evtCategoryInfo(this, mea);
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
                var msg = bll.DeleteCategoryInfoById(id) ? "删除成功" : "删除失败";

                MessageBox.Show(msg);
                LoadCategoryInfoByDelFlag(0);
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
            
        }

        private void btnDeletePro_Click(object sender, EventArgs e)
        {
            if (dgvProductInfo.SelectedRows.Count > 0)
            {
                if (DialogResult.OK == MessageBox.Show("确定删除", "删除", MessageBoxButtons.OKCancel))
                {
                    var proId = Convert.ToInt32(dgvProductInfo.SelectedRows[0].Cells[0].Value);
                    var msg = bll.DeleteProductInfoById(proId) ? "删除成功" : "删除失败";
                    MessageBox.Show(msg);
                }
            }
            else
            {
                MessageBox.Show("未选中要删除的行");
            }
        }
    }
}
