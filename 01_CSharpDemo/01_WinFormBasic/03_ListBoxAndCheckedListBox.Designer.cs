namespace _01_WinFormBasic
{
    partial class _03_ListBoxAndCheckedListBox
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
            this.lbShow = new System.Windows.Forms.ListBox();
            this.lbCheckedSource = new System.Windows.Forms.CheckedListBox();
            this.btnMove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbNewItem = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbShow
            // 
            this.lbShow.FormattingEnabled = true;
            this.lbShow.ItemHeight = 12;
            this.lbShow.Items.AddRange(new object[] {
            "你好",
            "我不好"});
            this.lbShow.Location = new System.Drawing.Point(256, 39);
            this.lbShow.Name = "lbShow";
            this.lbShow.Size = new System.Drawing.Size(173, 136);
            this.lbShow.TabIndex = 0;
            // 
            // lbCheckedSource
            // 
            this.lbCheckedSource.CheckOnClick = true;
            this.lbCheckedSource.FormattingEnabled = true;
            this.lbCheckedSource.Items.AddRange(new object[] {
            "第一行",
            "第二行",
            "第3行",
            "第4行",
            "第五行",
            "第陸行"});
            this.lbCheckedSource.Location = new System.Drawing.Point(12, 39);
            this.lbCheckedSource.Name = "lbCheckedSource";
            this.lbCheckedSource.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbCheckedSource.Size = new System.Drawing.Size(173, 132);
            this.lbCheckedSource.TabIndex = 1;
            // 
            // btnMove
            // 
            this.btnMove.Location = new System.Drawing.Point(191, 88);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(53, 40);
            this.btnMove.TabIndex = 2;
            this.btnMove.Text = ">>";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(29, 206);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbNewItem
            // 
            this.tbNewItem.Location = new System.Drawing.Point(118, 208);
            this.tbNewItem.Name = "tbNewItem";
            this.tbNewItem.Size = new System.Drawing.Size(100, 21);
            this.tbNewItem.TabIndex = 4;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(269, 206);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // _03_ListBoxAndCheckedListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 277);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.tbNewItem);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.lbCheckedSource);
            this.Controls.Add(this.lbShow);
            this.Name = "_03_ListBoxAndCheckedListBox";
            this.Text = "_03_ListBoxAndCheckedListBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbShow;
        private System.Windows.Forms.CheckedListBox lbCheckedSource;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbNewItem;
        private System.Windows.Forms.Button btnClear;
    }
}