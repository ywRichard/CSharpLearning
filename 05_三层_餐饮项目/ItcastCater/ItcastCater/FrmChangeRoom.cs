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
    public partial class FrmChangeRoom : Form
    {
        private int _tp;
        public FrmChangeRoom()
        {
            InitializeComponent();
        }

        public void SetText(object sender, EventArgs e)
        {
            var mea = e as MyEventArgs;
            _tp = mea.Temp;
            var ri = mea.Obj as RoomInfo;

            foreach (var ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    (ctrl as TextBox).Text = "";
                }
            }

            if (_tp == 1)//新增
            {

            }
            else if (_tp == 2)//修改
            {
                txtIsDeflaut.Text = ri.IsDefault.ToString();
                txtRMinMoney.Text = ri.RoomMinimunConsume.ToString();
                txtRName.Text = ri.RoomName;
                txtRPerNum.Text = ri.RoomMaxConsumer.ToString();
                txtRType.Text = ri.RoomType.ToString();
                labId.Text = ri.RoomId.ToString();
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            CheckEmptyTextBox();

            var ri = new RoomInfo();
            ri.IsDefault = Convert.ToInt32(txtIsDeflaut.Text);
            ri.RoomMinimunConsume = Convert.ToDecimal(txtRMinMoney.Text);
            ri.RoomName = txtRName.Text;
            ri.RoomMaxConsumer = Convert.ToDecimal(txtRPerNum.Text);
            ri.RoomType = Convert.ToInt32(txtRType.Text);

            if (_tp == 1)//新增
            {
                ri.SubTime = DateTime.Now;
                ri.DelFlag = 0;
                ri.SubBy = 1;
            }
            else if (_tp == 2)//修改
            {
                ri.RoomId = Convert.ToInt32(labId.Text);
            }

            var msg = (new RoomInfoBLL()).SaveRoomInfo(ri, _tp) ? "操作成功" : "操作失败";
            MessageBox.Show(msg);

            this.Close();
        }

        private void CheckEmptyTextBox()
        {
            foreach (var ctrl in Controls)
            {
                if (ctrl is TextBox)
                {
                    var tb = ctrl as TextBox;
                    if (tb.Text == "")
                    {
                        MessageBox.Show("未填写全部信息");
                    }
                }
            }
        }
    }
}
