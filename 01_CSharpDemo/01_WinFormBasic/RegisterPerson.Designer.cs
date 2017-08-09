namespace _01_WinFormBasic
{
    partial class RegisterPerson
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
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbGender = new System.Windows.Forms.GroupBox();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.cbGraduate = new System.Windows.Forms.CheckBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.tbOut = new System.Windows.Forms.TextBox();
            this.gbGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(73, 19);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 21);
            this.tbName.TabIndex = 0;
            // 
            // tbAge
            // 
            this.tbAge.Location = new System.Drawing.Point(73, 64);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(100, 21);
            this.tbAge.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Age";
            // 
            // gbGender
            // 
            this.gbGender.Controls.Add(this.rbFemale);
            this.gbGender.Controls.Add(this.rbMale);
            this.gbGender.Location = new System.Drawing.Point(26, 109);
            this.gbGender.Name = "gbGender";
            this.gbGender.Size = new System.Drawing.Size(96, 77);
            this.gbGender.TabIndex = 4;
            this.gbGender.TabStop = false;
            this.gbGender.Text = "Gender";
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(17, 49);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(59, 16);
            this.rbFemale.TabIndex = 1;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(17, 26);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(47, 16);
            this.rbMale.TabIndex = 0;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // cbGraduate
            // 
            this.cbGraduate.AutoSize = true;
            this.cbGraduate.Location = new System.Drawing.Point(158, 109);
            this.cbGraduate.Name = "cbGraduate";
            this.cbGraduate.Size = new System.Drawing.Size(72, 16);
            this.cbGraduate.TabIndex = 5;
            this.cbGraduate.Text = "Graduate";
            this.cbGraduate.UseVisualStyleBackColor = true;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(216, 17);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 6;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // tbOut
            // 
            this.tbOut.Location = new System.Drawing.Point(26, 202);
            this.tbOut.Multiline = true;
            this.tbOut.Name = "tbOut";
            this.tbOut.Size = new System.Drawing.Size(265, 85);
            this.tbOut.TabIndex = 7;
            // 
            // RegisterPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 310);
            this.Controls.Add(this.tbOut);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.cbGraduate);
            this.Controls.Add(this.gbGender);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbAge);
            this.Controls.Add(this.tbName);
            this.Name = "RegisterPerson";
            this.Text = "RegisterPerson";
            this.gbGender.ResumeLayout(false);
            this.gbGender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbAge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbGender;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.CheckBox cbGraduate;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox tbOut;
    }
}