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
using System.IO;
using System.Threading;

namespace _Socket_Client1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        Socket socketSend = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        private void btnConnect_Click(object sender, EventArgs e)
        {
            IPAddress ip = IPAddress.Parse(txtIP.Text);
            IPEndPoint endPoint = new IPEndPoint(ip, Convert.ToInt32(txtPort.Text));
            socketSend.Connect(endPoint);

            ShowMsg("连接成功");
            Thread th = new Thread(Receive);
            th.IsBackground = true;
            th.Start(socketSend);
        }

        private void ShowMsg(string str)
        {
            txtLog.AppendText(str + "\r\n");
        }

        private void Receive(object o)
        {
            Socket socketSend = o as Socket;
            byte[] buffer = new byte[1024 * 1024 * 5];

            while (true)
            {
                int r = socketSend.Receive(buffer);
                if (0 == r)
                {
                    break;
                }

                if (0 == buffer[0])//接收到的是文字信息
                {
                    txtLog.AppendText(socketSend.RemoteEndPoint.ToString()+":"+Encoding.UTF8.GetString(buffer, 1, r)+"\r\n");
                }
                else if (1 == buffer[0])//接收到的是文件
                {
                    SaveFileDialog sfd = new SaveFileDialog();
                    sfd.Title = "保存文件";
                    sfd.InitialDirectory = @"C:\Users\Richard\Desktop\qwe";
                    sfd.Filter = "所有文件|*.*";
                    sfd.ShowDialog(this);

                    string path = sfd.FileName;
                    using (FileStream fsWrite = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
                    {
                        fsWrite.Write(buffer, 1, r);
                    }
                    MessageBox.Show("发送成功");
                }
                else if (2 == buffer[0])//接收到的是震动信息
                {
                    for (int i = 0; i < 100; i++)
                    {
                        this.Location = new Point(this.Location.X - 5, this.Location.Y - 5);
                        this.Location = new Point(this.Location.X + 5, this.Location.Y + 5);
                    }
                }
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            byte[] buffer = Encoding.UTF8.GetBytes(txtMsg.Text);

            socketSend.Send(buffer, buffer.Length, SocketFlags.None);
        }
    }
}
