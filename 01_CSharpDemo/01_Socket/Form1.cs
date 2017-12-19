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

namespace _01_Socket
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
            listenSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            var ipAddress = IPAddress.Parse(txtIP.ToString());
            var endPoint = new IPEndPoint(ipAddress, Convert.ToInt32(txtPort.Text));
            listenSocket.Bind(endPoint);//开始监听
            listenSocket.Listen(10);//设置监听队列
            //将监听程序放到线程中
            var listenThread = new Thread(AcceptData);
            listenThread.IsBackground = true;
            listenThread.Start();
        }

        private void AcceptData()
        {
            while (true)
            {
                var newSocket = listenSocket.Accept();
                //对请求报文进行处理
                var dataConnection = new DataConnection(newSocket,ShowMsg);
            }

        }

        private void ShowMsg(string obj)
        {
            throw new NotImplementedException();
        }
    }
}
