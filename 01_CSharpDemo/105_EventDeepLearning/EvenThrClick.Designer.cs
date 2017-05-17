namespace _30_事件的三连击
{
    partial class EvenThrClick
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
            this.EventClick = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EventClick
            // 
            this.EventClick.Location = new System.Drawing.Point(0, 0);
            this.EventClick.Name = "EventClick";
            this.EventClick.Size = new System.Drawing.Size(150, 74);
            this.EventClick.TabIndex = 0;
            this.EventClick.Text = "事件按钮";
            this.EventClick.UseVisualStyleBackColor = true;
            this.EventClick.Click += new System.EventHandler(this.EventClick_Click);
            // 
            // EvenThrClick
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.EventClick);
            this.Name = "EvenThrClick";
            this.Size = new System.Drawing.Size(150, 71);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button EventClick;
    }
}
