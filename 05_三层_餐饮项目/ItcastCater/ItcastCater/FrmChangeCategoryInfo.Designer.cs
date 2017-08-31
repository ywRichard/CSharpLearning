namespace ItcastCater
{
    partial class FrmChangeCategoryInfo
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
            this.labId = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtCRemark = new System.Windows.Forms.TextBox();
            this.txtCNum = new System.Windows.Forms.TextBox();
            this.txtCName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labId
            // 
            this.labId.AutoSize = true;
            this.labId.Location = new System.Drawing.Point(109, 180);
            this.labId.Name = "labId";
            this.labId.Size = new System.Drawing.Size(0, 12);
            this.labId.TabIndex = 42;
            this.labId.Visible = false;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(98, 175);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 41;
            this.btnOk.Text = "确定";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtCRemark
            // 
            this.txtCRemark.Location = new System.Drawing.Point(98, 130);
            this.txtCRemark.Name = "txtCRemark";
            this.txtCRemark.Size = new System.Drawing.Size(100, 21);
            this.txtCRemark.TabIndex = 39;
            // 
            // txtCNum
            // 
            this.txtCNum.Location = new System.Drawing.Point(98, 81);
            this.txtCNum.Name = "txtCNum";
            this.txtCNum.Size = new System.Drawing.Size(100, 21);
            this.txtCNum.TabIndex = 40;
            // 
            // txtCName
            // 
            this.txtCName.Location = new System.Drawing.Point(98, 29);
            this.txtCName.Name = "txtCName";
            this.txtCName.Size = new System.Drawing.Size(100, 21);
            this.txtCName.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 35;
            this.label3.Text = "商品备注：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 36;
            this.label2.Text = "商品编号：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 37;
            this.label1.Text = "商品类别：";
            // 
            // FrmChangeCategoryInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(254, 219);
            this.Controls.Add(this.labId);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtCRemark);
            this.Controls.Add(this.txtCNum);
            this.Controls.Add(this.txtCName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmChangeCategoryInfo";
            this.Text = "新增或修改";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labId;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtCRemark;
        private System.Windows.Forms.TextBox txtCNum;
        private System.Windows.Forms.TextBox txtCName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}