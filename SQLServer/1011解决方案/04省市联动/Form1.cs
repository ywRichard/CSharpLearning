using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _04省市联动
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadAreaByAreaPid(0);
        }

        private void LoadAreaByAreaPid(int AreaPID)
        {
            List<Area> list = new List<Area>();
            list.Add(new Area() { AreaID = -1, AreaName = "请选择" });
            string sql = "select AreaName, AreaID from Area where AreaPID="+AreaPID;

            using (SqlDataReader reader = SqlHelper.ExecuteReader(sql))
            {
                if(reader.HasRows)
                {
                    while(reader.Read())
                    {
                        Area a = new Area();
                        a.AreaName = reader["AreaName"].ToString();
                        a.AreaID = Convert.ToInt32(reader["AreaID"].ToString());
                        list.Add(a);
                    }
                }
            }
            cmbProvince.DataSource = list;
            cmbProvince.ValueMember = "AreaID";
            cmbProvince.DisplayMember = "AreaName";
        }

        private void cmbProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbProvince.SelectedIndex!=0)
            {
                int AreaPID = Convert.ToInt32(cmbProvince.SelectedValue);
                List<Area> list = new List<Area>();
                string sql;
                if (AreaPID > 4)
                    sql = "select AreaName, AreaID from Area where AreaPID=" + AreaPID;
                else 
                    sql = "select AreaName, AreaID from Area where AreaID=" + AreaPID;

                using (SqlDataReader reader = SqlHelper.ExecuteReader(sql))
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Area a = new Area();
                            a.AreaName = reader["AreaName"].ToString();
                            a.AreaID = Convert.ToInt32(reader["AreaID"].ToString());
                            list.Add(a);
                        }
                    }
                }

                cmbCity.DataSource = list;
                cmbCity.DisplayMember = "AreaName";
                cmbCity.ValueMember = "AreaID";
            } 
        }
    }
}
