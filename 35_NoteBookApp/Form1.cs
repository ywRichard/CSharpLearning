using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using _ToolInterface;
using System.Reflection;
using System.IO;

namespace _35_NoteBookApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //***********get interface************
            string asmPath = Assembly.GetExecutingAssembly().Location;//get lib path
            string libPath = Path.Combine(Path.GetDirectoryName(asmPath), "Lib");
            string[] files = Directory.GetFiles(libPath,"*.dll");
            for (int i = 0; i < files.Length; i++)
            {
                //*************get Tool Type**************
                Assembly.LoadFile(files[i]).;
            }

            //MessageBox.Show(libPath);
            //***********match tool***************
        }
    }
}
