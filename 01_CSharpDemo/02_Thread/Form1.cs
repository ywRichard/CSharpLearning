using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_Thread
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Control.CheckForIllegalCrossThreadCalls = false;//跨线程访问1（不推荐使用），禁用跨线程安全检查
            //TextBox.CheckForIllegalCrossThreadCalls = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("单线程结束");
            CountMax();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var threStart = new ThreadStart(CountMax);
            var myThred = new Thread(threStart);
            //myThred.Name = "";//为线程命名

            //myThred.Abort();//强制终止线程，会引发异常

            //myThred.Priority = ThreadPriority.Highest;//建议，执不执行取决于操作系统

            //myThred.Join(1000);//主线程阻塞1000ms,影响子线程执行。

            //后台线程 -> 当主程序或者窗口被关闭时，线程结束；
            //前台线程 -> ..., 线程不结束。
            myThred.IsBackground = true;

            //将线程状态设置为Running，由操作系统决定什么时候执行线程
            myThred.Start();
        }

        private void CountMax()
        {
            var max = Int32.MaxValue;
            var a = 0;
            for (int i = 0; i < max - 1; i++)
            {
                a = i;
            }
            Console.WriteLine("计数结束");
            MessageBox.Show(a.ToString());
            //this.textBox1.Text = a.ToString();//跨线程访问
            //跨线程访问2，专业的解决方案
            if (this.textBox1.InvokeRequired)//判断textBox1是否在创建线程以外的线程访问，true则是跨线程。
            {
                //Invoke:会沿着TextBox标签去找Form窗体，找到创建Form窗体的那个线程，执行下面的方法。谁创建了label的线程，就用该线程调用这个委托。
                this.textBox1.Invoke(new Action<string, TextBox>(SetText), a.ToString(), this.textBox1);
            }
            else
            {
                this.textBox1.Text = a.ToString();
            }
        }

        private void SetText(string str, TextBox tb)
        {
            tb.Text = str;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var list = new List<int> { 1, 2, 3 };
            var myThreaStart = new ParameterizedThreadStart(ShowList);
            var myThres = new Thread(myThreaStart);
            myThres.Start(list);
        }

        private void ShowList(object obj)
        {
            var list = (List<int>)obj;
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var threStart = new ThreadStart(CountMax);
            var myThrea = new Thread(threStart);
            myThrea.Start();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //线程同步 -> 多线程竞争使用同一个程序或者同一个资源（并发），但是资源调用的顺序由操作系统决定。所以结果不可预测。
            //并发问题的解决方案，1.需要给资源上锁；2.消息队列（专业）。
            var thread1 = new Thread(ForThredSync);
            thread1.IsBackground = true;
            thread1.Start();

            var thread2 = new Thread(ForThredSync);
            thread2.IsBackground = true;
            thread2.Start();
        }

        int b = 0;
        private static readonly object obj = new object();

        /// <summary>
        /// 模拟多线程竞争资源
        /// </summary>
        private void ForThredSync()
        {
            //上锁 -> 得到锁的线程先使用资源，使用完成后将返回系统，再转交到其他的线程。
            //可以解决资源并发问题，但是也会牺牲计算机性能。
            lock (obj)//用static readonly的object对象来上锁，防止和其他的程序或者dll冲突，造成
            {
                for (int i = 0; i < 2000; i++)
                {
                    b = b + i;
                }

                MessageBox.Show(b.ToString());
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            for (int i = 0; i < 1000; i++)
            {
                //线程的创建非常消耗资源
                new Thread(() =>
                {
                    int i2 = 1 + 1;
                }).Start();
            }
            sw.Stop();
            Console.WriteLine(sw.Elapsed.TotalMilliseconds);

            sw.Reset();
            sw.Restart();
            for (int i = 0; i < 1000; i++)
            {
                //启动线程池 -> 能用就用，微软对线程池做了优化。使用与大部分情况。
                //不适用线程池，只能手动创建的情况：
                //1、要调用线程的Abort(), Join(); 
                //2、需要对线程池的线程优先级做设置。
                //3、如果线程执行时间特别长，建议手动创建。 因为线程池的是通过栈来实现的，如果执行时间长会堵塞线程池。
                ThreadPool.QueueUserWorkItem(new WaitCallback(PoolCallBack), "sssss" + i);
            }
            sw.Stop();
            Console.WriteLine(sw.Elapsed.TotalMilliseconds);
        }

        private static void PoolCallBack(object state)
        {
            int i = 1 + 1;
        }
    }
}
