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

namespace _Socket_Server
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //点击开始监听的时候，创建用于监听的Socket和IP地址
            Socket socketWatch = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPAddress ip = IPAddress.Any;
            //创建用于监听的端口
            IPEndPoint point = new IPEndPoint(ip, Convert.ToInt32(txtPort.Text));
            //开始监听
            socketWatch.Bind(point);
            //MessageBox.Show("监听成功");
            ShowMsg("监听成功");
            socketWatch.Listen(10);//一个时间点上可以同时侦听的队列容量   
            Thread th = new Thread(Listen);
            th.IsBackground = true;//设为后台线程
            th.Start(socketWatch);
        }

        void ShowMsg(string str)
        {
            txtLog.AppendText(str + "\r\n");
        }

        Socket socketSend;//声明负责通信的套接字

        Dictionary<string, Socket> dicSocket = new Dictionary<string, Socket>();//声明一个键值对集合，用于储存IP地址和套接字

        /// <summary>
        /// 等待客户端的连接，并创建一个负责通信的socket
        /// </summary>
        void Listen(object o)
        {
            Socket socketWatch = o as Socket;
            while (true)
            {
                //等待客户端的连接，并创建一个负责通信的Socket
                socketSend = socketWatch.Accept();//放在主线程中会造成软件假死
                //将客户端的IP地址和端口保存到键值对集合中
                dicSocket.Add(socketSend.RemoteEndPoint.ToString(), socketSend);
                //酱客户端的IP地址和端口保存到下拉框中
                cboUsers.Items.Add(socketSend.RemoteEndPoint.ToString());

                ShowMsg(socketSend.RemoteEndPoint.ToString() + ":连接成功");
                Thread th = new Thread(Receive);
                th.IsBackground = true;
                th.Start(socketSend);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        void Receive(object o)
        {
            Socket socketReceive = o as Socket;
            byte[] buffer = new byte[1024 * 1024 * 1];
            while (true)
            {
                int count = socketReceive.Receive(buffer);
                if (0 == count)
                {
                    break;
                }
                string str = Encoding.UTF8.GetString(buffer, 0, count);
                ShowMsg(socketReceive.RemoteEndPoint.ToString() + ":" + str);
            }
        }

        /// <summary>
        /// 服务器发送消息，
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelect_Click(object sender, EventArgs e)
        {
            //标题，初始路径，显示窗口，文件过滤
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "选择要发送的文件";
            ofd.InitialDirectory = @"C:\Users\Richard\Desktop\qwe";
            ofd.Filter = "所有文件|*.*";
            ofd.ShowDialog();

            txtPath.Text = ofd.FileName;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            byte[] buffer = Encoding.UTF8.GetBytes(txtMsg.Text.Trim());

            List<byte> list = new List<byte>();
            list.Add(0);
            list.AddRange(buffer);
            byte[] newBuffer = list.ToArray();
            string ip = cboUsers.SelectedItem.ToString();
            dicSocket[ip].Send(newBuffer);
            //socketSend.Send(buffer);
        }

        private void btnSendFile_Click(object sender, EventArgs e)
        {

            using (FileStream fsRead = new FileStream(txtPath.Text,FileMode.Open,FileAccess.Read))
            {
                byte[] buffer = new byte[1024*1024*5];
                
                int r = fsRead.Read(buffer,0,buffer.Length);
                List<byte> list = new List<byte>();
                list.Add(1);
                list.AddRange(buffer);
                byte[] newBuffer = list.ToArray();

                socketSend.Send(newBuffer, r+1, SocketFlags.None);
            }
        }

        private void btnShock_Click(object sender, EventArgs e)
        {
            byte[] buffer = new byte[1];
            buffer[0] = 2;
            socketSend.Send(buffer);
        }
    }
}
