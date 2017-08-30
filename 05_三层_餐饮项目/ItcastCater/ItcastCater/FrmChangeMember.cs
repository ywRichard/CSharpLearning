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

        private void LoadMemberTypeByDelFlag(int p)
        {
            var bll = new MemberTypeBLL();
            var list = bll.GetAllMemberTypeByDelFlag(p);
            list.Insert(0, new MemberType() { MemType = -1, MemTpName = "请选择" });
            cmbMemType.DataSource = list;
            cmbMemType.DisplayMember = "MemTpName";
            cmbMemType.ValueMember = "MemType";
        }

        public void SetText(object sender, EventArgs e)
        {
            LoadMemberTypeByDelFlag(0);
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
                txtMemIntegral.Text = "0";
                rdoMan.Checked = true;
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
                dtEndServerTime.Value = mem.MemEndServerTime;//会员截至日期
                lblId.Text = mem.MemberId.ToString();//储存会员id
                //会员等级
                cmbMemType.SelectedIndex = mem.MemType;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (CheckTextBoxEmpty())
            {
                var mem = new MemberInfo();
                //MemAddress不要
                mem.MemBirthday = Convert.ToDateTime(txtBirs.Text);
                mem.MemDiscount = Convert.ToDecimal(txtMemDiscount.Text);
                mem.MemIntegral = Convert.ToInt32(txtMemIntegral.Text);
                mem.MemMoney = Convert.ToDecimal(txtmemMoney.Text);
                mem.MemName = txtMemName.Text;
                mem.MemNum = txtMemNum.Text;
                mem.MemMobilePhone = txtMemPhone.Text;
                mem.MemEndServerTime = Convert.ToDateTime(dtEndServerTime.Value);
                mem.MemGender = CheckGender();
                mem.MemType = Convert.ToInt32(cmbMemType.SelectedValue);


                //判断新增还是修改
                if (this._tp == 1)//新增
                {
                    mem.DelFlag = 0;
                    mem.SubTime = System.DateTime.Now;
                }
                else if (this._tp == 2)//修改
                {
                    mem.MemberId = Convert.ToInt32(lblId.Text);
                }
                var bll = new MemberInfoBLL();
                var msg = bll.SaveMemberInfo(mem, this._tp) ? "操作成功" : "操作失败";
                MessageBox.Show(msg);
                this.Close();
            }
        }

        private string CheckGender()
        {
            var str = "";
            if (rdoMan.Checked)
            {
                str = "男";
            }
            else if (rdoWoman.Checked)
            {
                str = "女";
            }

            return str;
        }

        /// <summary>
        /// 所有文本框不能为空
        /// </summary>
        private bool CheckTextBoxEmpty()
        {
            if (string.IsNullOrEmpty(txtBirs.Text))
            {
                MessageBox.Show("生日不能为空");
                return false;
            }
            if (string.IsNullOrEmpty(txtMemDiscount.Text))
            {
                MessageBox.Show("折扣不能为空");
                return false;
            }
            if (string.IsNullOrEmpty(txtMemIntegral.Text))
            {
                MessageBox.Show("积分不能为空");
                return false;
            }
            if (string.IsNullOrEmpty(txtmemMoney.Text))
            {
                MessageBox.Show("余额不能为空");
                return false;
            }
            if (string.IsNullOrEmpty(txtMemName.Text))
            {
                MessageBox.Show("姓名不能为空");
                return false;
            }
            if (string.IsNullOrEmpty(txtMemNum.Text))
            {
                MessageBox.Show("会员编号不能为空");
                return false;
            }
            if (string.IsNullOrEmpty(txtMemPhone.Text))
            {
                MessageBox.Show("手机不能为空");
                return false;
            }
            if (cmbMemType.SelectedIndex == 0)
            {
                MessageBox.Show("请选择会员等级");
                return false;
            }

            return true;
        }
    }
}
