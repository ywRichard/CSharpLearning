using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _02_ThreadBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            //TryThreadBasic();
            //TryIsBackgroundThread();
            TryThreadSync();
        }

        #region Thread Basic
        static void TryThreadBasic()
        {
            //var thread1 = new Thread(new ThreadStart(TryThreadStart));
            var thread1 = new Thread(() => Console.WriteLine("无参线程"));
            thread1.Start();

            //var thread2 = new Thread(new ParameterizedThreadStart(TryThreadWithPara));
            var thread2 = new Thread(a => Console.WriteLine(a));
            thread2.Name = "thread2.1";
            thread2.Start("带参数的线程");
            //thread2.Name = "thread2.2";//线程运行在设置线程属性会抛异常
            Console.WriteLine($"主线程:{Thread.CurrentThread.ManagedThreadId}");
            Console.WriteLine($"{thread2.Name}:{thread2.ManagedThreadId}");
        }

        private static void TryThreadWithPara(object obj)
        {
            var str = obj as string;
            Console.WriteLine($"{str}:{Thread.CurrentThread.ManagedThreadId}");
        }

        private static void TryThreadStart()
        {
            Console.WriteLine(DateTime.Now.Second);
            Thread.Sleep(2000);
            Console.WriteLine(DateTime.Now.Second);
            Console.WriteLine("调用无参线程");
        }
        #endregion

        #region 前台线程和后台线程
        static void TryIsBackgroundThread()
        {
            var thread1 = new Thread(() => RunLoop())
            {
                Name = "thread1 -> background thread",
                IsBackground = true
            };
            thread1.Start();

            var thread2 = new Thread(a => RunLoop(a))
            {
                Name = "Thread2 -> foreground",
            };
            thread2.Start(10);
        }

        static void RunLoop()
        {
            RunLoop(20);
        }
        static void RunLoop(object a)
        {
            var num = (int)a;
            var name = Thread.CurrentThread.Name;
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine($"{name}:{i}");
                if (Thread.CurrentThread.IsBackground == true)
                {
                    Thread.Sleep(50);
                }
            }
        }
        #endregion

        #region 线程同步
        static void TryThreadSync()
        {
            var book = new BookShop();
            //创建两个线程同时访问Sale方法
            var t1 = new Thread(new ThreadStart(book.Sale));
            var t2 = new Thread(new ThreadStart(book.Sale));
            //启动线程
            t1.Start();
            t2.Start();
        }

        #endregion
    }

    /// <summary>
    /// 线程同步的例子
    /// </summary>
    class BookShop
    {
        //剩余图书数量
        public int num = 1;
        public void Sale()
        {
            //int tmp = num;
            //if (tmp > 0)//判断是否有书，如果有就可以卖
            //{
            //    Thread.Sleep(1000);
            //    num -= 1;
            //    Console.WriteLine("售出一本图书，还剩余{0}本", num);
            //}
            //else
            //{
            //    Console.WriteLine("没有了");
            //}

            //使用lock关键字解决线程同步问题
            //如果是类实例 this
            //如果是静态变量 一般使用类名
            lock (this)
            {
                int tmp = num;
                if (tmp > 0)//判断是否有书，如果有就可以卖
                {
                    Thread.Sleep(1000);
                    num -= 1;
                    Console.WriteLine("售出一本图书，还剩余{0}本", num);
                }
                else
                {
                    Console.WriteLine("没有了");
                }
            }
        }
    }
}
