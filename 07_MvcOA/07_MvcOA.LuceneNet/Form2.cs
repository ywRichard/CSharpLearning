using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServiceStack.Logging;
using ServiceStack.Redis;

namespace _07_MvcOA.LuceneNet
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public static IRedisClientsManager clientManager = new PooledRedisClientManager("127.0.0.1:6379");
        public static IRedisClient redisClient = clientManager.GetClient();


        private void button1_Click(object sender, EventArgs e)
        {
            //新开一个线程去轮询消息队列，如果有异常消息，则取出执行。
            //用CLR维护的线程池里的线程性能更好
            var fileLogPath = @"C:\Users\Victor\Documents\GitHub\CSharpLearning\07_MvcOA\07_MvcOA.LuceneNet\Log\";
            //WaitCallback
            ThreadPool.QueueUserWorkItem(a =>
            {
                //必须死循环，否则执行后线程释放
                while (true)
                {
                    if (redisClient.GetListCount("errorMsg") > 0)
                    {
                        var ex = redisClient.DequeueItemFromList("errorMsg");
                        var fileName = DateTime.Now.ToString("yyyy-M-d") + ".txt";
                        File.AppendAllText(fileLogPath + fileName, ex.ToString(), Encoding.Default);
                    }
                    else
                    {
                        //线程休息，节约CPU开销
                        Thread.Sleep(3000);
                    }
                }
            }, fileLogPath);
        }
    }
}
