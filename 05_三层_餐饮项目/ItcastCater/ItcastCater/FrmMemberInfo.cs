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
        MemberInfoBLL bll = new MemberInfoBLL();

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
                
                var msg = bll.DeleteMemberInfoByMemberId(id) ? "删除成功" : "删除失败";
                MessageBox.Show(msg);
                LoadMemberInfoByDelFlag(0);
            }
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            LoadMemberInfoByDelFlag(comboBox1.SelectedIndex);
        }

        public event EventHandler evtMember;
        //标识:1----新增，2----修改
        private void btnAddMember_Click(object sender, EventArgs e)
        {
            ShowFrmChangeMember(1);
        }

        //修改会员
        private void btnUpdateMember_Click(object sender, EventArgs e)
        {
            if (dgvMemmber.SelectedRows.Count>0)//是否有选中的行
            {
                //获取选中行的id，根据id去数据库查询
                var id = Convert.ToInt32(dgvMemmber.SelectedRows[0].Cells[0].Value.ToString());
                //去数据库查询数据
                mea.obj = bll.GetMemberInfoByMemberId(id);
                ShowFrmChangeMember(2);
            }
            else
            {
                MessageBox.Show("未选中行");
            }
        }

        MyEventArgs mea = new MyEventArgs();
        private void ShowFrmChangeMember(int p)
        {
            var fcm = new FrmChangeMemberInfo();
            if (p==1)
            {
                fcm.Text = "新增会员";
            }
            else if(p==2)
            {
                fcm.Text = "修改会员";
            }
            this.evtMember += new EventHandler(fcm.SetText);
            mea.Temp = p;
            if (this.evtMember!=null)
            {
                this.evtMember(this, mea);
                fcm.FormClosed += new FormClosedEventHandler(fcm_FormClosed);
                fcm.ShowDialog();
            }
        }

        private void fcm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadMemberInfoByDelFlag(0);
        }
    }
}
