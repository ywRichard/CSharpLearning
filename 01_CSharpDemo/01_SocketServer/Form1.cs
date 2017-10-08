using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_SocketServer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Socket listenSocket = null;
        private void btnServer_Click(object sender, EventArgs e)
        {
            listenSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);//创建socket
            var ipAddress = IPAddress.Parse(this.txtIp.Text);//获取IP地址
            var endPoint = new IPEndPoint(ipAddress, Convert.ToInt32(this.txtPort.Text));
            listenSocket.Bind(endPoint);//开始监听
            listenSocket.Listen(10);//设置监听队列

            var accpetThread = new Thread(AcceptData);
            accpetThread.IsBackground = true;
            accpetThread.Start();
        }

        private void AcceptData()
        {
            while (true)
            {
                var accept = listenSocket.Accept();
                DataConnection dataConnection = new DataConnection(accept, ShowMsg);
            }
        }

        private void ShowMsg(string msg)
        {
            if (txtContent.InvokeRequired)
            {
                txtContent.Invoke(new Action<string, TextBox>(SetValue), msg, txtContent);
            }
            else
            {
                txtContent.AppendText(msg + "\r\n");
            }
        }

        private void SetValue(string str, TextBox tb)
        {
            tb.AppendText(str + "\r\n");
        }
    }
}
