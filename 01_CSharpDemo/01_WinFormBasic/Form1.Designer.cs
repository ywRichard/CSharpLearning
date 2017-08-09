namespace _01_WinFormBasic
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textJob = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNewPanel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(58, 29);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 21);
            this.txtAge.TabIndex = 3;
            this.txtAge.Validating += new System.ComponentModel.CancelEventHandler(this.textEmpty_Validating);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(60, 85);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 21);
            this.txtName.TabIndex = 4;
            this.txtName.Validating += new System.ComponentModel.CancelEventHandler(this.textEmpty_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "age:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "name:";
            // 
            // textJob
            // 
            this.textJob.Location = new System.Drawing.Point(61, 126);
            this.textJob.Name = "textJob";
            this.textJob.Size = new System.Drawing.Size(100, 21);
            this.textJob.TabIndex = 7;
            this.textJob.Validating += new System.ComponentModel.CancelEventHandler(this.textJob_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "job:";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(54, 184);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(72, 24);
            this.btnOk.TabIndex = 9;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOk);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textJob);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtAge);
            this.groupBox1.Location = new System.Drawing.Point(22, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(186, 248);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "事件";
            // 
            // btnNewPanel
            // 
            this.btnNewPanel.Location = new System.Drawing.Point(268, 37);
            this.btnNewPanel.Name = "btnNewPanel";
            this.btnNewPanel.Size = new System.Drawing.Size(75, 23);
            this.btnNewPanel.TabIndex = 11;
            this.btnNewPanel.Text = "Register Perosn";
            this.btnNewPanel.UseVisualStyleBackColor = true;
            this.btnNewPanel.Click += new System.EventHandler(this.btnNewPanel_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(268, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "ListBox Panel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 304);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnNewPanel);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textJob;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnNewPanel;
        private System.Windows.Forms.Button button1;
    }
}

