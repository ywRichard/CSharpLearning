namespace _06_UserControlBasic
{
    partial class ctrLabelTextbox
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCaption = new System.Windows.Forms.Label();
            this.txtTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblCaption
            // 
            this.lblCaption.AutoSize = true;
            this.lblCaption.Location = new System.Drawing.Point(-2, 0);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(35, 12);
            this.lblCaption.TabIndex = 0;
            this.lblCaption.Text = "Label";
            // 
            // txtTextbox
            // 
            this.txtTextbox.Location = new System.Drawing.Point(0, 15);
            this.txtTextbox.Name = "txtTextbox";
            this.txtTextbox.Size = new System.Drawing.Size(100, 21);
            this.txtTextbox.TabIndex = 1;
            this.txtTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTextbox_KeyDown);
            this.txtTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTextbox_KeyPress);
            this.txtTextbox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtTextbox_KeyUp);
            // 
            // ctrLabelTextbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtTextbox);
            this.Controls.Add(this.lblCaption);
            this.Name = "ctrLabelTextbox";
            this.Size = new System.Drawing.Size(150, 168);
            this.Load += new System.EventHandler(this.ctrLabelTextbox_Load);
            this.SizeChanged += new System.EventHandler(this.ctrLabelTextbox_SizeChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCaption;
        private System.Windows.Forms.TextBox txtTextbox;
    }
}
