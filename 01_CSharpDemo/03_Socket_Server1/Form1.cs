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

namespace _Socket_Server1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnListen_Click(object sender, EventArgs e)
        {
            //新建监听socket,设置IP和端口，绑定端口，设置监听队列容量，等待连接请求
            Socket socketWatch = new Socket(AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.Tcp);
            IPAddress ip = IPAddress.Any;
            IPEndPoint endPoint = new IPEndPoint(ip, Convert.ToInt32(txtPort.Text));
            socketWatch.Bind(endPoint);
            socketWatch.Listen(10);
            ShowMsg("监听成功");

            Thread th = new Thread(Listen);//为监听开一个后台线程
            th.IsBackground = true;
            th.Start(socketWatch);
        }

        Dictionary<string, Socket> dicSocket = new Dictionary<string, Socket>();

        private void Listen(object o)
        {
            Socket socketWatch = o as Socket;

            while (true)
            {
                //获得客户机申请，并显示客户机的IP地址和端口,同时保存到键值对集合和下拉列表中
                Socket socketSend = socketWatch.Accept();
                ShowMsg(socketSend.RemoteEndPoint.ToString()+":连接成功");
                cboUsers.Items.Add(socketSend.RemoteEndPoint.ToString());
                dicSocket.Add(socketSend.RemoteEndPoint.ToString(), socketSend);

                Thread th = new Thread(Receive);
                th.IsBackground = true;
                th.Start(socketSend);
            }
        }

        private void ShowMsg(string str)
        {
            txtLog.AppendText(str + "\r\n");
        }

        private void btnSend_Click(object sender, EventArgs e)
        {            
            List<byte> list = new List<byte>();
            list.Add(0);
            list.AddRange(Encoding.UTF8.GetBytes(txtMsg.Text));//自定义协议

            byte[] buffer = list.ToArray();
            string ipAddress = cboUsers.SelectedItem.ToString();
            dicSocket[ipAddress].Send(buffer);//发送文字
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            txtPort.Text = "5000";
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "选择文件";
            ofd.Filter = "所有文件|*.*";
            ofd.InitialDirectory = @"C:\Users\Richard\Desktop";
            ofd.ShowDialog();

            txtPath.Text = ofd.FileName;
        }

        private void btnShock_Click(object sender, EventArgs e)
        {
            byte[] buffer = new byte[1];
            buffer[0] = 2;

            dicSocket[cboUsers.SelectedItem.ToString()].Send(buffer);
        }

        private void Receive(object o)
        {
            //接收客户端发送的消息
            Socket socketSend = o as Socket;
            byte[] buffer = new byte[1024 * 1024 * 5];            

            while (true)
            {
                int r = socketSend.Receive(buffer);
                if (0==r)
                {
                    break;
                }
                txtLog.AppendText(socketSend.RemoteEndPoint.ToString()+":"+Encoding.UTF8.GetString(buffer, 0, r));
            }
        }

        private void btnSendFile_Click(object sender, EventArgs e)
        {
            string path = txtPath.Text;
            using (FileStream fsRead = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                byte[] buffer = new byte[1024 * 1024 * 5];
                int r = fsRead.Read(buffer, 0, buffer.Length);
                List<byte> list = new List<byte>();
                list.Add(1);
                list.AddRange(buffer);
                byte[] newBuffer = list.ToArray();

                dicSocket[cboUsers.SelectedItem.ToString()].Send(newBuffer, r + 1, SocketFlags.None);
            }
        }
    }
}
