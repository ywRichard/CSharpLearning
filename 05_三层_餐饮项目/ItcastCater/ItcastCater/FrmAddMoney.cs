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
    public partial class FrmAddMoney : Form
    {
        public FrmAddMoney()
        {
            InitializeComponent();
        }

        public void SetText(object sender, EventArgs e)
        {
            var mea = e as MyEventArgs;
            labDeskName.Text = mea.Name;
            labOrderId.Text = mea.Temp.ToString();
        }

        private void FrmAddMoney_Load(object sender, EventArgs e)
        {
            //加载所有的产品
            LoadProductInfoByDelFlag(0);
            //加载节点数的产品
            LoadCategoryInfoByDelFlag(0);
            //加载所有点的菜
            LoadROrderInfoProductByOrderId(Convert.ToInt32(labOrderId.Text));
        }

        private void LoadROrderInfoProductByOrderId(int id)
        {
            dgvROrderProduct.AutoGenerateColumns = false;
            var bll = new R_OrderInfo_ProductBLL();
            dgvROrderProduct.DataSource = bll.GetR_OrderInfo_ProductByOrderId(id);
            if (dgvROrderProduct.SelectedRows.Count > 0)
            {
                dgvROrderProduct.SelectedRows[0].Selected = false;
            }
            //这里不用判断是否点了菜
            var rop = bll.GetAllMoneyAndCount(id);
            labSumMoney.Text = rop.MONEY.ToString();
            labCount.Text = rop.CT.ToString();
        }

        //加载节点树
        private void LoadCategoryInfoByDelFlag(int p)
        {
            var bll = new CategoryInfoBLL();
            var list = bll.GetAllCategoryInfoByDelFlag(p);
            foreach (var c in list)
            {
                var tn = tvCategory.Nodes.Add(c.CatName);
                LoadProductInfoByCatId(c.CatId, tn.Nodes);
            }
        }

        private void LoadProductInfoByCatId(int catId, TreeNodeCollection nodes)
        {
            var bll = new ProductInfoBLL();
            var listProds = bll.GetProductInfoByCatId(catId);
            foreach (var pro in listProds)
            {
                nodes.Add(pro.ProName + "===" + pro.ProPrice + "元");
            }
        }

        //加载主菜单
        private void LoadProductInfoByDelFlag(int p)
        {
            var bll = new ProductInfoBLL();
            dgvProduct.AutoGenerateColumns = false;
            dgvProduct.DataSource = bll.GetAllProductInfoByDelFlag(p);
            dgvProduct.SelectedRows[0].Selected = false;
        }

        private void dgvProduct_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProduct.SelectedRows.Count > 0)
            {
                //OrderId,ProId,DelFlag,SubTime,State,UnitCount
                var rop = new R_OrderInfo_Product();
                rop.OrderId = Convert.ToInt32(labOrderId.Text);
                rop.ProId = Convert.ToInt32(dgvProduct.SelectedRows[0].Cells[0].Value);
                rop.DelFlag = 0;
                rop.SubTime = DateTime.Now;
                rop.State = 0;
                if (txtCount.Text != "")
                {
                    try
                    {
                        rop.UnitCount = Convert.ToInt32(txtCount.Text) > 1 ? Convert.ToInt32(txtCount.Text) : 1;
                    }
                    catch
                    {
                        MessageBox.Show("消费数量输入错误");
                        return;
                    }
                }
                else
                {
                    rop.UnitCount = 1;
                }

                var bll = new R_OrderInfo_ProductBLL();
                bll.AddROrderInfoProduct(rop);
                LoadROrderInfoProductByOrderId(Convert.ToInt32(rop.OrderId));
            }
            else
            {
                MessageBox.Show("未选中行");
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            int flag = 0;
            if (string.IsNullOrEmpty(txtSearch.Text))
            {
                LoadProductInfoByDelFlag(0);
                return;
            }
            else
            {
                flag = char.IsNumber(txtSearch.Text[0]) ? 2 : 1;
                var bll = new ProductInfoBLL();
                dgvProduct.DataSource = bll.GetProductInfoBySpellNum(txtSearch.Text, flag);
                if (dgvProduct.SelectedRows.Count > 0)
                {
                    dgvProduct.SelectedRows[0].Selected = false;
                }
            }
        }

        private void btnDeleteRorderPro_Click(object sender, EventArgs e)
        {
            if (dgvROrderProduct.SelectedRows.Count > 0)
            {
                var id = Convert.ToInt32(dgvROrderProduct.SelectedRows[0].Cells[0].Value);
                var bll = new R_OrderInfo_ProductBLL();
                var msg = bll.DeleteROrderProductById(id) ? "退菜成功" : "退菜失败";
                MessageBox.Show(msg);
                LoadROrderInfoProductByOrderId(Convert.ToInt32(labOrderId.Text));
            }
            else
            {
                MessageBox.Show("请选择要退的菜");
            }
        }

        private void FrmAddMoney_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (labSumMoney.Text!="" && !string.IsNullOrEmpty(labSumMoney.Text))
            {
                var bll = new OrderInfoBLL();
                var id = Convert.ToInt32(labOrderId.Text);
                var money = Convert.ToInt32(labSumMoney.Text);

                if (bll.UpdateMoneyByOrderId(id,money)==false)
                {
                    MessageBox.Show("保存订单总消费失败");
                }
            }
        }
    }
}
