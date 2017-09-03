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
    public partial class FrmBilling : Form
    {
        public FrmBilling()
        {
            InitializeComponent();
        }

        private int _id;

        public void SetText(object sender, EventArgs e)
        {
            var mea = e as MyEventArgs;
            var dk = mea.Obj as DeskInfo;
            labDeskName.Text = dk.DeskName;
            labLittleMoney.Text = mea.Money.ToString();
            labRoomType.Text = mea.Name.ToString();
            _id = dk.DeskId;
        }

        public event EventHandler evtFrmMoney;
        private void btnOK_Click(object sender, EventArgs e)
        {
            //餐桌的状态
            var bllBk = new DeskInfoBLL();
            var dkFlag = bllBk.UpdateDeskStateByDeskId(_id, 1);

            //添加一个订单
            var odrBll = new OrderInfoBLL();
            var odr = new OrderInfo();
            odr.BeginTime = System.DateTime.Now;
            odr.DelFlag = 0;
            odr.OrderMoney = 0;
            odr.OrderState = 1;
            odr.Remark = txtPersonCount.Text + txtDescription.Text;
            odr.SubBy = 1;
            int orderId = odrBll.AddOrderInfo(odr);

            //添加一个中间表
            var rodBll = new R_Order_DeskBLL();
            var rod = new R_Order_Desk();
            rod.DeskId = _id;
            rod.OrderId = orderId;
            var rodFlag = rodBll.AddROrderDesk(rod);

            if (dkFlag&&rodFlag)
            {
                MessageBox.Show("开单成功");
                if (ckbMeal.Checked)
                {
                    var mea = new MyEventArgs();
                    mea.Name = labDeskName.Text;//餐桌编号
                    mea.Temp = orderId;//订单Id
                    //窗体传值
                    var fam = new FrmAddMoney();
                    this.evtFrmMoney += new EventHandler(fam.SetText);
                    if (this.evtFrmMoney!=null)
                    {
                        this.evtFrmMoney(this, mea);
                        fam.FormClosed += new FormClosedEventHandler(fam_FormClosed);
                        fam.ShowDialog();
                    }
                }
                else
                {
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("开单失败");
            }
        }

        private void fam_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
