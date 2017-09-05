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
    public partial class FrmPayBill : Form
    {
        private int _dkId;
        public FrmPayBill()
        {
            InitializeComponent();
        }

        public void SetText(object sender, EventArgs e)
        {
            //餐桌编号
            var mea = e as MyEventArgs;
            var dk = mea.Obj as DeskInfo;
            labDeskName.Text = dk.DeskName;
            _dkId = dk.DeskId;
            //订单号 -> 根据DeskId查询OrderId
            var orderBLL = new OrderInfoBLL();
            var orderId = orderBLL.GetOrderIdByDeskId(dk.DeskId);
            labOrderId.Text = orderId.ToString();
            //消费总金额 -> 通过OrderId查询
            var money = orderBLL.GetMoneyByOrderId(orderId);
            if (money != -1)
            {
                labMoney.Text = money.ToString();
                lblMoney.Text = money.ToString();
            }
            else
            {
                MessageBox.Show("查询订单消费失败");
            }
        }

        private void FrmPayBill_Load(object sender, EventArgs e)
        {
            //加载会员信息
            LoadAllMemberInfoByDelFlag(0);
            //加载点了的菜
            LoadAllOrderProducts(Convert.ToInt32(labOrderId.Text));
        }

        private void LoadAllOrderProducts(int orderId)
        {
            var bll = new R_OrderInfo_ProductBLL();
            dgvAllPro.AutoGenerateColumns = false;
            dgvAllPro.DataSource = bll.GetR_OrderInfo_ProductByOrderId(orderId);
            dgvAllPro.SelectedRows[0].Selected = false;
        }

        private void LoadAllMemberInfoByDelFlag(int p)
        {
            var bll = new MemberInfoBLL();
            var list = bll.GetAllMemberInfoByDelFlag(0);
            list.Insert(0, new MemberInfo { MemberId = -1, MemName = "请选择" });
            cmbMemmber.DataSource = list;
            cmbMemmber.DisplayMember = "MemName";
            cmbMemmber.ValueMember = "MemberId";
        }

        private void cmbMemmber_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbMemmber.SelectedIndex != 0)
            {
                var member = cmbMemmber.SelectedItem as MemberInfo;
                lblDis.Text = member.MemDiscount.ToString();
                labyeMoney.Text = member.MemMoney.ToString();

                var bll = new MemberTypeBLL();
                labTp.Text = bll.GetMemberTypeByType(Convert.ToInt32(member.MemType));
                lblMoney.Text = (Convert.ToDecimal(labMoney.Text) * Convert.ToDecimal(lblDis.Text) / 10).ToString();
            }
            else
            {
                lblDis.Text = "";
                labyeMoney.Text = "";
                labTp.Text = "";
                lblMoney.Text = labMoney.Text;
            }
        }

        private void btnAccounts_Click(object sender, EventArgs e)
        {
            decimal remainMoney = 0;
            var orderInfo = new OrderInfo();
            if (cmbMemmber.SelectedIndex != 0)
            {
                remainMoney = Convert.ToDecimal(labyeMoney.Text) - Convert.ToDecimal(lblMoney.Text);
                if (remainMoney < 0)
                {
                    if (string.IsNullOrEmpty(txtMoney.Text))
                    {
                        MessageBox.Show("余额不足，付钱~");
                        return;
                    }
                    if ((remainMoney + Convert.ToDecimal(txtMoney.Text)) < 0)
                    {
                        MessageBox.Show("还是不够");
                        return;
                    }
                    lblSpareMoney.Text = (Convert.ToDecimal(txtMoney.Text) + remainMoney).ToString();
                    remainMoney = 0;
                }
                //会员的余额
                var mem = cmbMemmber.SelectedItem as MemberInfo;
                (new MemberInfoBLL()).UpdateMemberMoneyById(mem.MemberId, remainMoney);
                orderInfo.OrderMemId = mem.MemberId;
                orderInfo.DisCount = mem.MemDiscount;
            }
            else
            {
                if (string.IsNullOrEmpty(txtMoney.Text))
                {
                    MessageBox.Show("没给钱");
                    return;
                }
                if (Convert.ToDecimal(txtMoney.Text) < Convert.ToDecimal(lblMoney.Text))
                {
                    MessageBox.Show("钱不够");
                    return;
                }

                lblSpareMoney.Text = (Convert.ToDecimal(txtMoney.Text) - Convert.ToDecimal(lblMoney.Text)).ToString();
            }

            //餐桌的状态改变
            var dkFlag = (new DeskInfoBLL()).UpdateDeskStateByDeskId(_dkId, 0);

            orderInfo.OrderMoney = Convert.ToDecimal(lblMoney.Text);
            orderInfo.EndTime = System.DateTime.Now;
            orderInfo.OrderId = Convert.ToInt32(labOrderId.Text);

            //订单的状态改变，钱，会员的id，折扣
            var orderFlag = (new OrderInfoBLL()).UpdateOrderInfoByOrderId(orderInfo);
            if (dkFlag && orderFlag)
            {
                MessageBox.Show("结账成功");
            }
            else
            {
                MessageBox.Show("结账失败");
            }
        }
    }
}
