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
    public partial class FrmMemberInfo : Form
    {
        public FrmMemberInfo()
        {
            InitializeComponent();
        }

        private void FrmMemberInfo_Load(object sender, EventArgs e)
        {
            LoadMemberInfoByDelFlag(0);
        }

        private void LoadMemberInfoByDelFlag(int p)
        {
            var bll = new MemberInfoBLL();
            dgvMemmber.AutoGenerateColumns = false;
            dgvMemmber.DataSource = bll.GetAllMemberInfoByDelFlag(p);
            dgvMemmber.SelectedRows[0].Selected = false;
        }

        //删除会员信息，假删
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvMemmber.SelectedRows.Count > 0)
            {
                var id = Convert.ToInt32(dgvMemmber.SelectedRows[0].Cells[0].Value.ToString());
                var bll = new MemberInfoBLL();
                var msg = bll.DeleteMemberInfoByMemberId(id) ? "删除成功" : "删除失败";
                MessageBox.Show(msg);
                LoadMemberInfoByDelFlag(0);
            }
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            LoadMemberInfoByDelFlag(comboBox1.SelectedIndex);
        }
    }
}
