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
    public partial class FrmChangeMemberInfo : Form
    {
        private int _tp;
        public FrmChangeMemberInfo()
        {
            InitializeComponent();
        }

        public void SetText(object sender, EventArgs e)
        {
            var mea = e as MyEventArgs;
            _tp = mea.Temp;//储存标志

            if (_tp == 1)
            {
                foreach (Control item in this.Controls)
                {
                    if (item is TextBox)
                    {
                        ((TextBox)item).Text = "";
                    }
                }
            }
            else if (_tp == 2)
            {
                var mem = mea.obj as MemberInfo;
                txtBirs.Text = mem.MemBirthday.ToString();//生日
                txtMemDiscount.Text = mem.MemDiscount.ToString();//折扣
                txtMemIntegral.Text = mem.MemIntegral.ToString();//积分
                txtmemMoney.Text = mem.MemMoney.ToString();//余额
                txtMemName.Text = mem.MemName;//会员姓名
                txtMemNum.Text = mem.MemNum;//编号
                txtMemPhone.Text = mem.MemMobilePhone;//手机号码
                //性别
                rdoMan.Checked = mem.MemGender == "男" ? true : false;
                rdoWoman.Checked = mem.MemGender == "女" ? true : false;
                dtEndServerTime.Value = mem.MemEndServerTime;

            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
