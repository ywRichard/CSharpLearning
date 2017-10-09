using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.IO;

namespace _Socket_Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Socket socketSend = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        private void btnConnect_Click(object sender, EventArgs e)
        {
            //连接服务器，IP+端口
            IPAddress ip = IPAddress.Parse(txtServer.Text);
            IPEndPoint point = new IPEndPoint(ip, Convert.ToInt32(txtPort.Text));

            socketSend.Connect(point);//连接服务器
            ShowMsg("连接成功");

            //开启一个接受线程，不停的接受服务器发来的数据
            Thread th = new Thread(Receive);
            th.IsBackground = true;//后台线程为true
            th.Start(socketSend);

        }

        void ShowMsg(string str)
        {
            txtLog.AppendText(str + "\r\n");
        }

        private void Receive(object o)
        {
            Socket socketSend = o as Socket;
            byte[] buffer = new byte[1024 * 1024 * 5];//接收小于5M的文件，大文件传输应用断点传输
            while (true)
            {
                int r = socketSend.Receive(buffer);

                if (0 == r)
                {
                    break;
                }

                if (0 == buffer[0])//接收文字
                {
                    string strMsg = Encoding.UTF8.GetString(buffer, 1, r - 1);
                    ShowMsg(socketSend.RemoteEndPoint.ToString() + ":" + strMsg);
                }

                else if (1 == buffer[0])//接收文件
                {
                    //保存文件，标题，文件过滤，初始路径，显示窗口
                    SaveFileDialog sfd = new SaveFileDialog();
                    sfd.Title = "保存文件";
                    sfd.InitialDirectory = @"C:\Users\Richard\Desktop\qwe";
                    sfd.Filter = "所有文件|*.*";
                    sfd.ShowDialog(this);

                    //string path = sfd.FileName;
                    using (FileStream fsWrite = new FileStream(sfd.FileName,FileMode.OpenOrCreate,FileAccess.Write))
                    {
                        fsWrite.Write(buffer, 1, r - 1);
                    }
                    MessageBox.Show("保存成功");
                }
                else if (2 == buffer[0])//接收震动
                {
                    Shock();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            byte[] buffer = Encoding.UTF8.GetBytes(txtMsg.Text.Trim());
            socketSend.Send(buffer);
        }

        private void Shock()
        {
            for (int i = 0; i < 500; i++)
            {                 
                this.Location = new Point(this.Location.X+20,this.Location.Y+20);
                this.Location = new Point(this.Location.X-20,this.Location.Y-20);
            }
        }
    }
}
