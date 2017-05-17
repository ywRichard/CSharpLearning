namespace _29_委托的三连击
{
    partial class UserThreeClick
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.ThreeClick = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ThreeClick
            // 
            this.ThreeClick.Location = new System.Drawing.Point(0, 3);
            this.ThreeClick.Name = "ThreeClick";
            this.ThreeClick.Size = new System.Drawing.Size(147, 50);
            this.ThreeClick.TabIndex = 0;
            this.ThreeClick.Text = "三连击";
            this.ThreeClick.UseVisualStyleBackColor = true;
            this.ThreeClick.Click += new System.EventHandler(this.ThreeClick_Click);
            // 
            // UserThreeClick
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ThreeClick);
            this.Name = "UserThreeClick";
            this.Size = new System.Drawing.Size(149, 55);
            this.Load += new System.EventHandler(this.UserThreeClick_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ThreeClick;
    }
}
