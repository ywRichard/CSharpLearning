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
    public partial class FrmChangeCategoryInfo : Form
    {
        private int _tp;
        public FrmChangeCategoryInfo()
        {
            InitializeComponent();
        }

        public void SetText(object sender, EventArgs e)
        {
            var mea = e as MyEventArgs;
            _tp = mea.Temp;

            if (_tp == 1)//新增
            {
                foreach (Control ctl in this.Controls)
                {
                    if (ctl is TextBox)
                    {
                        ((TextBox)ctl).Text = "";
                    }
                }
            }
            else if (_tp == 2)//修改
            {
                var ci = mea.Obj as CategoryInfo;
                txtCName.Text = ci.CatName;
                txtCNum.Text = ci.CatNum;
                txtCRemark.Text = ci.Remark;
                labId.Text = ci.CatId.ToString();
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            var cti = new CategoryInfo
            {
                CatName = txtCName.Text,
                CatNum = txtCNum.Text,
                Remark = txtCRemark.Text
            };

            if (CheckTextBox())
            {
                if (this._tp == 1)//新增
                {
                    cti.DelFlag = 0;
                    cti.Subtime = DateTime.Now;
                }
                else if (this._tp == 2)//修改
                {
                    cti.CatId = Convert.ToInt32(labId.Text);
                }

                var bll = new CategoryInfoBLL();
                var msg = bll.SaveCategoryInfoBLL(cti, _tp) ? "操作成功" : "操作失败";
                MessageBox.Show(msg);
                this.Close();
            }
        }

        private bool CheckTextBox()
        {
            if (string.IsNullOrEmpty(txtCName.Text))
            {
                MessageBox.Show("类别不能为空");
                return false;
            }
            if (string.IsNullOrEmpty(txtCNum.Text))
            {
                MessageBox.Show("编号不能为空");
                return false;
            }
            if (string.IsNullOrEmpty(txtCRemark.Text))
            {
                MessageBox.Show("备注不能为空");
                return false;
            }

            return true;
        }
    }
}
