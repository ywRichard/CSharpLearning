namespace _01_DOMBasic
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
            this.btnLoop = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnCreateNode = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnSingle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLoop
            // 
            this.btnLoop.Location = new System.Drawing.Point(320, 20);
            this.btnLoop.Name = "btnLoop";
            this.btnLoop.Size = new System.Drawing.Size(75, 23);
            this.btnLoop.TabIndex = 0;
            this.btnLoop.Text = "Loop";
            this.btnLoop.UseVisualStyleBackColor = true;
            this.btnLoop.Click += new System.EventHandler(this.btnLoop_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(12, 22);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResult.Size = new System.Drawing.Size(289, 199);
            this.txtResult.TabIndex = 1;
            // 
            // btnCreateNode
            // 
            this.btnCreateNode.Location = new System.Drawing.Point(320, 61);
            this.btnCreateNode.Name = "btnCreateNode";
            this.btnCreateNode.Size = new System.Drawing.Size(75, 23);
            this.btnCreateNode.TabIndex = 2;
            this.btnCreateNode.Text = "Insert";
            this.btnCreateNode.UseVisualStyleBackColor = true;
            this.btnCreateNode.Click += new System.EventHandler(this.btnCreateNode_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(320, 100);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 3;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnSingle
            // 
            this.btnSingle.Location = new System.Drawing.Point(307, 140);
            this.btnSingle.Name = "btnSingle";
            this.btnSingle.Size = new System.Drawing.Size(88, 23);
            this.btnSingle.TabIndex = 4;
            this.btnSingle.Text = "SelectSingle";
            this.btnSingle.UseVisualStyleBackColor = true;
            this.btnSingle.Click += new System.EventHandler(this.btnSingle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 262);
            this.Controls.Add(this.btnSingle);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnCreateNode);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnLoop);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoop;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnCreateNode;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnSingle;
    }
}

