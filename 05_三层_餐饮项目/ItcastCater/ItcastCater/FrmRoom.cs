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
    public partial class FrmRoom : Form
    {
        public FrmRoom()
        {
            InitializeComponent();
        }

        private static FrmRoom _instance;

        public static FrmRoom Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                {
                    _instance = new FrmRoom();
                }
                return _instance;
            }
        }

        private void FrmRoom_Load(object sender, EventArgs e)
        {
            LoadRoomInfoByDelFlag(0);
        }

        private void LoadRoomInfoByDelFlag(int temp)
        {
            dgvRoomInfo.AutoGenerateColumns = false;
            dgvRoomInfo.DataSource = (new RoomInfoBLL()).GetAllRoomInfoByDelFlag(temp);
        }

        private event EventHandler evtFrm;
        private MyEventArgs mea = new MyEventArgs();
        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            LoadFrmChangeRoomInfo(1);//新增
        }

        /// <summary>
        /// 显示新增或修改房间窗口
        /// </summary>
        /// <param name="flag">1:新增；2:修改</param>
        private void LoadFrmChangeRoomInfo(int flag)
        {
            var fcr = new FrmChangeRoom();
            var ri = new RoomInfo();

            if (flag == 1)
            {
                fcr.Text = "新增房间";
            }
            else if (flag == 2)
            {
                fcr.Text = "修改房间";
                var row = dgvRoomInfo.SelectedRows[0];
                ri.RoomId = Convert.ToInt32(row.Cells[0].Value);
                ri.RoomName = row.Cells[1].Value.ToString();
                ri.RoomMinimunConsume = Convert.ToDecimal(row.Cells[2].Value);
                ri.RoomMaxConsumer = Convert.ToDecimal(row.Cells[3].Value);
                ri.IsDefault = Convert.ToInt32(row.Cells[4].Value);
                ri.RoomType = Convert.ToInt32(row.Cells[5].Value);
            }

            evtFrm += new EventHandler(fcr.SetText);
            if (evtFrm != null)
            {
                mea.Temp = flag;
                mea.Obj = ri;
                evtFrm(this, mea);
                fcr.FormClosed += new FormClosedEventHandler(Frm_Closed);
                fcr.ShowDialog();
            }
        }

        private void Frm_Closed(object sender, FormClosedEventArgs e)
        {
            LoadRoomInfoByDelFlag(0);
        }

        private void btnUpdateRoom_Click(object sender, EventArgs e)
        {
            if (dgvRoomInfo.SelectedRows.Count > 0)
            {
                LoadFrmChangeRoomInfo(2);//修改
            }
            else
            {
                MessageBox.Show("未选中行");
            }
        }

        private void btnDeleteRoom_Click(object sender, EventArgs e)
        {
            if (dgvRoomInfo.SelectedRows.Count > 0)
            {
                var id = Convert.ToInt32(dgvRoomInfo.SelectedRows[0].Cells[0].Value);
                (new RoomInfoBLL()).DeleteRoomInfoByRoomId(id);
            }
            else
            {
                MessageBox.Show("未选中要删除的行");
            }

            LoadRoomInfoByDelFlag(0);
        }
    }
}
