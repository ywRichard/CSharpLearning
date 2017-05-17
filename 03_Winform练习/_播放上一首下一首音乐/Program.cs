using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace _播放上一首下一首音乐
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
