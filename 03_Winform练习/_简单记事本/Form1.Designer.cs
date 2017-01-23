namespace _简单记事本
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
            this.txtConstent = new System.Windows.Forms.TextBox();
            this.btnWrap = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lalPsw = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPsw = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtConstent
            // 
            this.txtConstent.Location = new System.Drawing.Point(35, 103);
            this.txtConstent.Multiline = true;
            this.txtConstent.Name = "txtConstent";
            this.txtConstent.Size = new System.Drawing.Size(416, 279);
            this.txtConstent.TabIndex = 0;
            this.txtConstent.WordWrap = false;
            // 
            // btnWrap
            // 
            this.btnWrap.Location = new System.Drawing.Point(67, 50);
            this.btnWrap.Name = "btnWrap";
            this.btnWrap.Size = new System.Drawing.Size(75, 23);
            this.btnWrap.TabIndex = 1;
            this.btnWrap.Text = "自动换行";
            this.btnWrap.UseVisualStyleBackColor = true;
            this.btnWrap.Click += new System.EventHandler(this.btnWrap_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(251, 54);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(80, 157);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(53, 12);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "用户名：";
            // 
            // lalPsw
            // 
            this.lalPsw.AutoSize = true;
            this.lalPsw.Location = new System.Drawing.Point(80, 194);
            this.lalPsw.Name = "lalPsw";
            this.lalPsw.Size = new System.Drawing.Size(41, 12);
            this.lalPsw.TabIndex = 3;
            this.lalPsw.Text = "密码：";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(168, 160);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(158, 21);
            this.txtName.TabIndex = 4;
            // 
            // txtPsw
            // 
            this.txtPsw.Location = new System.Drawing.Point(168, 192);
            this.txtPsw.Name = "txtPsw";
            this.txtPsw.PasswordChar = '*';
            this.txtPsw.Size = new System.Drawing.Size(158, 21);
            this.txtPsw.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(106, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(243, 265);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "重置";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 435);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPsw);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lalPsw);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnWrap);
            this.Controls.Add(this.txtConstent);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtConstent;
        private System.Windows.Forms.Button btnWrap;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lalPsw;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPsw;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

