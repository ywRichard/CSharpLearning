using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _03大项目
{
    public partial class Form1 : Form
    {
        ////第一遍
        //string str = "Data Source = 127.0.0.1;Initial Catalog = TestDB;User ID = sa;Password = 123456";
        ////第二遍
        //string str = "Data Source = 127.0.0.1;Initial Catalog = TestDB;User ID = sa;Password = 123456";
        //第三遍
        string str = "Data Source = 127.0.0.1;Initial Catalog = TestDB;User ID = sa;Password = 123456";

        public Form1()
        {
            InitializeComponent();
        }
        //窗体加载
        private void Form1_Load(object sender, EventArgs e)
        {
            ////第一遍
            //LoadDeskInfoByDelFlag(0);
            ////第二遍
            //LoadDeskInfoByDelFlag(0);
            //第三遍
            LoadDeskInfoByDelFlag(0);
        }
        /// <summary>
        /// 加载所有没有被删除的餐桌
        /// </summary>
        /// <param name="p">删除标志0--未删除，1---删除>
        private void LoadDeskInfoByDelFlag(int p)
        {
            #region 第一遍
            //List<DeskInfo> list = new List<DeskInfo>();
            ////通过字符串连接数据
            //using(SqlConnection con = new SqlConnection(str))
            //{                
            //    //拼接sql语句
            //    string sql = "select DeskId, DeskName, DeskNamePinYin, DeskNum from DeskInfo where DeskDelFlag = 0";
            //    using(SqlCommand cmd = new SqlCommand(sql,con))
            //    {
            //        con.Open();
            //        //准备读取数据
            //        using (SqlDataReader reader = cmd.ExecuteReader())
            //        {
            //            //判断是否有数据
            //            if(reader.HasRows)
            //            {
            //                //读取每一行
            //                while(reader.Read())
            //                {
            //                    DeskInfo dk = new DeskInfo();
            //                    dk.DeskId = Convert.ToInt32(reader["DeskId"]);
            //                    dk.DeskName = reader["DeskName"].ToString();
            //                    dk.DeskNamePinYin = reader["DeskNamePinYin"].ToString();
            //                    dk.DeskNum = reader["DeskNum"].ToString();
            //                    list.Add(dk);
            //                }//end while
            //            }//end if
            //        }//end SqlDataReader
            //    }//end SqlCommand
            //}//end SqlConnection

            //dgv.AutoGenerateColumns = false;//禁止自动生成列
            //dgv.DataSource = list; 
            #endregion
            #region 第二遍
            ////第二遍
            //List<DeskInfo> list = new List<DeskInfo>();
            ////连接数据库
            //using (SqlConnection con = new SqlConnection(str))
            //{
            //    string sql = "select DeskId, DeskName, DeskNamePinYin, DeskNum from DeskInfo where DeskDelFlag = 0";
            //    //执行命令
            //    using (SqlCommand cmd = new SqlCommand(sql, con))
            //    {
            //        //打开数据库
            //        con.Open();
            //        //读取数据
            //        using (SqlDataReader reader = cmd.ExecuteReader())
            //        {
            //            //判断是否有数据
            //            if (reader.HasRows)
            //            {
            //                //读取每一行的数据
            //                while (reader.Read())
            //                {
            //                    DeskInfo dk = new DeskInfo();
            //                    dk.DeskId = Convert.ToInt32(reader["DeskId"]);
            //                    dk.DeskName = reader["DeskName"].ToString();
            //                    dk.DeskNamePinYin = reader["DeskNamePinYin"].ToString();
            //                    dk.DeskNum = reader["DeskNum"].ToString();
            //                    list.Add(dk);
            //                }//end while
            //            }//end if
            //        }//end SqlCommand
            //    }//end SqlCommand
            //}//end SqlConnection

            //dgv.AutoGenerateColumns = false;//不创建新列
            //dgv.DataSource = list; 
            #endregion
            //第三遍
            List<DeskInfo> list = new List<DeskInfo>();
            //连接数据库
            using(SqlConnection con = new SqlConnection(str))
            {
                string sql = "select DeskId, DeskName, DeskNamePinYin, DeskNum from DeskInfo where DeskDelFlag = "+p;
                //打开数据库
                using(SqlCommand cmd = new SqlCommand(sql,con))
                {
                    con.Open();
                    //执行数据库
                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        //判断是否有数据
                        if(reader.HasRows)
                        { 
                            while(reader.Read())
                            {
                                DeskInfo dk = new DeskInfo();
                                dk.DeskId=Convert.ToInt32(reader["DeskId"]);
                                dk.DeskName = reader["DeskName"].ToString();
                                dk.DeskNamePinYin = reader["DeskNamePinYin"].ToString();
                                dk.DeskNum = reader["DeskNum"].ToString();
                                list.Add(dk);
                            }//end while
                        }//end if
                    }//end SqlReader
                }//end SqlCommand
            }//end SqlConnection
            dgv.AutoGenerateColumns = false;//禁止自动创建列
            dgv.DataSource = list;//连接数据源
            dgv.SelectedRows[0].Selected = false;//禁止被选中
        }// end LoadDesk

        private void btnOK_Click(object sender, EventArgs e)
        {
            int n = -1;
            //连接数据库
            using(SqlConnection con = new SqlConnection(str))
            {
                string sql = string.Format("insert into DeskInfo(DeskName,DeskNamePinYin,DeskNum,DeskDelFlag) values('{0}','{1}',{2},'0')",txtName.Text,txtPinYin.Text,txtNum.Text);
                using(SqlCommand cmd = new SqlCommand(sql,con))
                {
                    con.Open();
                    n = cmd.ExecuteNonQuery();
                    LoadDeskInfoByDelFlag(0);
                }
            }

            string msg = n>0?"操作成功":"操作失败";
            MessageBox.Show(msg);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            #region 第一遍
            ////是否选中行
            //if (dgv.SelectedRows.Count > 0)
            //{
            //    string strID = dgv.SelectedCells[0].Value.ToString();
            //    int id = Convert.ToInt32(strID);
            //    int n = -1;
            //    //连接数据库
            //    using (SqlConnection con = new SqlConnection(str))
            //    {
            //        string sql = "update DeskInfo set DeskDelFlag=1 where DeskId =" + id;
            //        //操作数据库
            //        using (SqlCommand cmd = new SqlCommand(sql, con))
            //        {
            //            con.Open();
            //            n = cmd.ExecuteNonQuery();
            //        }//end cmd
            //    }//end con

            //    string msg = n > 0 ? "操作成功" : "操作失败";
            //    MessageBox.Show(msg);
            //    LoadDeskInfoByDelFlag(0);//刷新
            //} 
            #endregion
            //是否选中行
            if(dgv.SelectedRows.Count>0)
            {
                //得到选中的ID
                int id = Convert.ToInt32(dgv.SelectedCells[0].Value.ToString());
                int n = -1;

                using(SqlConnection con = new SqlConnection(str))
                {
                    string sql = "update DeskInfo set DeskDelFlag = 1 where DeskId="+id;
                    //操作数据库 
                    using(SqlCommand cmd = new SqlCommand(sql,con))
                    {
                        con.Open();
                        n = cmd.ExecuteNonQuery();
                    }

                    string msg = n > 0 ? "操作成功" : "操作失败";
                    MessageBox.Show(msg);
                    LoadDeskInfoByDelFlag(0);
                }
            }
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgv.SelectedRows.Count>0)
            {
                //id name pinyin num
                lbID.Text = dgv.SelectedCells[0].Value.ToString();
                txtUName.Text = dgv.SelectedCells[1].Value.ToString();
                txtUPinyin.Text = dgv.SelectedCells[2].Value.ToString();
                txtUNum.Text = dgv.SelectedCells[3].Value.ToString();
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if(dgv.SelectedRows.Count>0)
            {
                int n = -1;
                if(lbID.Text!="")
                {
                    using(SqlConnection con = new SqlConnection(str))
                    {
                        string sql = string.Format("update DeskInfo set DeskName='{0}',DeskNamePinYin='{1}',DeskNum='{2}' where DeskId='{3}'", txtUName.Text, txtUPinyin.Text, txtUNum.Text, Convert.ToInt32(lbID.Text));
                        using(SqlCommand cmd = new SqlCommand(sql,con))
                        {
                            con.Open();
                            n = cmd.ExecuteNonQuery();
                        }
                    }

                    string msg = n > 0 ? "修改成功" : "修改失败";
                    MessageBox.Show(msg);
                    LoadDeskInfoByDelFlag(0);
                }
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            object obj;
            using(SqlConnection con = new SqlConnection(str))
            {
                string sql = "select count(*) from DeskInfo where DeskDelFlag=0";
                using(SqlCommand cmd = new SqlCommand(sql,con))
                {
                    con.Open();
                    obj = cmd.ExecuteScalar();
                }
                MessageBox.Show(obj.ToString());
            }
        }

        private void btnRecycle_Click(object sender, EventArgs e)
        {
            LoadDeskInfoByDelFlag(1);
        }

        private void btnDelDelete_Click(object sender, EventArgs e)
        {
            string id = dgv.SelectedCells[0].Value.ToString();
            using (SqlConnection con = new SqlConnection(str))
            { 
                string sql = "update DeskInfo set DeskDelFlag=5 where DeskId = "+id;
                using(SqlCommand cmd = new SqlCommand(sql,con))
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                }

                LoadDeskInfoByDelFlag(1);
            }
        }


    }
}
