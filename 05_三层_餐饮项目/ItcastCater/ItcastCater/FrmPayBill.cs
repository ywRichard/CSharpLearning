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
        public FrmPayBill()
        {
            InitializeComponent();
        }

        public void SetText(object sender, EventArgs e)
        {
            //餐桌编号
            var mea=e as MyEventArgs;
            var dk = mea.Obj as DeskInfo;
            labDeskName.Text = dk.DeskName;
            //订单号 -> 根据DeskId查询OrderId
            var orderBLL = new OrderInfoBLL();
            var orderId = orderBLL.GetOrderIdByDeskId(dk.DeskId);
            labOrderId.Text = orderId.ToString();
            //消费总金额 -> 通过OrderId查询
            var money = orderBLL.GetMoneyByOrderId(orderId);
            if (money!=-1)
            {
                labMoney.Text = money.ToString();
                lblMoney.Text= money.ToString();
            }
            else
            {
                MessageBox.Show("查询订单消费失败");
            }
        }
    }
}
