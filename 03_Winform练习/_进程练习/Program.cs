using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace _进程练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //Process[] process = Process.GetProcesses();

            //for (int i = 0; i < process.Length; i++)
            //{
            //    Console.WriteLine(process[i].ToString());
            //    process[i].Kill();
            //}
            //Console.ReadKey();

            //Process.Start("notepad");//创建进程
            //Process.Start("calc");
            //Process.Start("iexplore","www.baidu.com");
            ProcessStartInfo psi = new ProcessStartInfo("notepad");
            Process proc = new Process();
            proc.StartInfo = psi;
            proc.Start();
        }
    }
}
