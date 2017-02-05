using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MyEditPlus;
using System.Reflection;
using System.IO;

namespace _34_插件开发之记事本
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //从Lib文件夹获得获得DLL文件
            string appPath =Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);//得到程序集所在的文件路径
            string libPath = Path.Combine(appPath, "Lib");//得到Lib路径
            string[] files = Directory.GetFiles(libPath,"*.dll");

            for (int i = 0; i < files.Length; i++)
            {
                Assembly asb = Assembly.LoadFrom(files[i]);//获取程序集
                Type[] tps = asb.GetTypes();//得到类型
                Type iEdi = typeof(IEditPlus);//获取接口的类型

                for (int j = 0; j < tps.Length; j++)
                {
                    
                }//判断插件是否符合规范
            }
            
        }
    }
}
