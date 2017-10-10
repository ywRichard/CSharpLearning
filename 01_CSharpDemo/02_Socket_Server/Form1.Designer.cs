namespace _Socket_Server
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtLog = new System.Windows.Forms.TextBox();
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.cboUsers = new System.Windows.Forms.ComboBox();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnSendFile = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnShock = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(27, 67);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(480, 101);
            this.txtLog.TabIndex = 0;
            // 
            // txtMsg
            // 
            this.txtMsg.Location = new System.Drawing.Point(27, 179);
            this.txtMsg.Multiline = true;
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.Size = new System.Drawing.Size(480, 105);
            this.txtMsg.TabIndex = 1;
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(27, 41);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(100, 21);
            this.txtServer.TabIndex = 2;
            this.txtServer.Text = "192.168.233.130";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(147, 41);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(54, 21);
            this.txtPort.TabIndex = 3;
            this.txtPort.Text = "50000";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(232, 39);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "开始监听";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // cboUsers
            // 
            this.cboUsers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUsers.FormattingEnabled = true;
            this.cboUsers.Location = new System.Drawing.Point(331, 39);
            this.cboUsers.Name = "cboUsers";
            this.cboUsers.Size = new System.Drawing.Size(121, 20);
            this.cboUsers.TabIndex = 5;
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(27, 296);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(326, 21);
            this.txtPath.TabIndex = 6;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(359, 296);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 7;
            this.btnSelect.Text = "选择";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnSendFile
            // 
            this.btnSendFile.Location = new System.Drawing.Point(440, 296);
            this.btnSendFile.Name = "btnSendFile";
            this.btnSendFile.Size = new System.Drawing.Size(75, 23);
            this.btnSendFile.TabIndex = 8;
            this.btnSendFile.Text = "发送文件";
            this.btnSendFile.UseVisualStyleBackColor = true;
            this.btnSendFile.Click += new System.EventHandler(this.btnSendFile_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(300, 328);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 9;
            this.btnSend.Text = "发送消息";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnShock
            // 
            this.btnShock.Location = new System.Drawing.Point(405, 328);
            this.btnShock.Name = "btnShock";
            this.btnShock.Size = new System.Drawing.Size(75, 23);
            this.btnShock.TabIndex = 10;
            this.btnShock.Text = "震动";
            this.btnShock.UseVisualStyleBackColor = true;
            this.btnShock.Click += new System.EventHandler(this.btnShock_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 361);
            this.Controls.Add(this.btnShock);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnSendFile);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.cboUsers);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtServer);
            this.Controls.Add(this.txtMsg);
            this.Controls.Add(this.txtLog);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.TextBox txtMsg;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ComboBox cboUsers;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnSendFile;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnShock;
    }
}

