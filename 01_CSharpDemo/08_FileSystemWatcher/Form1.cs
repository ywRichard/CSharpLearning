using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _08_FileSystemWatcher
{
    public partial class Form1 : Form
    {
        private FileSystemWatcher watcher;
        private delegate void UpdateWatchTextDelegate(string newText);
        public Form1()
        {
            InitializeComponent();
            this.watcher = new FileSystemWatcher();
            //注册FileSystemWatcher的四个事件
            this.watcher.Deleted += new FileSystemEventHandler(this.OnDelete);
            this.watcher.Renamed += new RenamedEventHandler(this.OnRenamed);
            this.watcher.Changed += new FileSystemEventHandler(this.OnChanged);
            this.watcher.Created += new FileSystemEventHandler(this.OnCreate);

            //DirectoryInfo dir = new DirectoryInfo(Directory.GetCurrentDirectory());
            //if (dir.Exists)
            //{
            //    //检查目录是否存在
            //}
        }

        public void UpdateWatchText(string newText)
        {
            lblWatch.Text = newText;
        }

        public void OnChanged(object source, FileSystemEventArgs e)
        {
            try
            {
                StreamWriter sw = new StreamWriter("Log.txt", true);
                sw.WriteLine("File: {0} {1}", e.FullPath, e.ChangeType.ToString());
                sw.Close();

                //异步调用指定的委托
                this.BeginInvoke(new UpdateWatchTextDelegate(UpdateWatchText), "Wrote change to event to log")
            }
            catch (IOException)
            {
                this.BeginInvoke(new UpdateWatchTextDelegate(UpdateWatchText), "Error Writing to log");
            }
        }

        public void OnRenamed(object source, RenamedEventArgs e)
        {
            try
            {
                StreamWriter sw = new StreamWriter("Log.txt", true);
                sw.WriteLine("File renamed from {0} to {1}", e.OldName, e.FullPath);
                sw.Close();
                this.BeginInvoke(new UpdateWatchTextDelegate(UpdateWatchText), "Wrote renamed event to log");
            }
            catch (IOException)
            {
                this.BeginInvoke(new UpdateWatchTextDelegate(UpdateWatchText), "Error Writing to log");
            }
        }

        public void OnDelete(object source, FileSystemEventArgs e)
        {
            try
            {
                StreamWriter sw = new StreamWriter("Log.txt", true);
                sw.WriteLine("File: {0} Deleted", e.FullPath);
                sw.Close();
                this.BeginInvoke(new UpdateWatchTextDelegate(UpdateWatchText), "Wrote delete event to log");
            }
            catch (IOException)
            {
                this.BeginInvoke(new UpdateWatchTextDelegate(UpdateWatchText), "Error Writing to log");
            }
        }

        public void OnCreate(object source, FileSystemEventArgs e)
        {
            try
            {
                StreamWriter sw = new StreamWriter("Log.txt", true);
                sw.WriteLine("File: {0} Created", e.FullPath);
                sw.Close();
                this.BeginInvoke(new UpdateWatchTextDelegate(UpdateWatchText), "Wrote create event to log");
            }
            catch (IOException)
            {
                this.BeginInvoke(new UpdateWatchTextDelegate(UpdateWatchText), "Error Writing to log");
            }
        }

        private void cmdBrowse_Click(object sender, EventArgs e)
        {
            if (FileDialog.ShowDialog() != DialogResult.Cancel)
            {
                txtLocation.Text = FileDialog.FileName;
                cmdWatch.Enabled = true;
            }
        }

        private void cmdWatch_Click(object sender, EventArgs e)
        {
            watcher.Path = Path.GetDirectoryName(txtLocation.Text);
            watcher.Filter = Path.GetFileName(txtLocation.Text);
            //设置监控过滤器
            watcher.NotifyFilter = NotifyFilters.LastWrite
                | NotifyFilters.FileName
                | NotifyFilters.Size;
            lblWatch.Text = "Watching" + txtLocation.Text;
            watcher.EnableRaisingEvents = true;
        }
    }
}
