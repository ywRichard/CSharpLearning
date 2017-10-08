using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_Process
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var prs = Process.GetProcesses();
            foreach (var pr in prs)
            {
                Console.WriteLine(pr.ProcessName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Console.WriteLine(Process.GetCurrentProcess().ProcessName);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start("notepad.exe");
        }
    }
}
