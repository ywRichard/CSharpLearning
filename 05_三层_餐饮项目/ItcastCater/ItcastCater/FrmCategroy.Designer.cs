namespace ItcastCater
{
    partial class FrmCategroy
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
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.btnUpdateCategory = new System.Windows.Forms.Button();
            this.btnDeleteCategory = new System.Windows.Forms.Button();
            this.btnAddPro = new System.Windows.Forms.Button();
            this.btnUpdatePro = new System.Windows.Forms.Button();
            this.btnDeletePro = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvCategoryInfo = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProductInfo = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoryInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductInfo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Location = new System.Drawing.Point(339, 43);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(109, 23);
            this.btnAddCategory.TabIndex = 0;
            this.btnAddCategory.Text = "添加商品类别";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // btnUpdateCategory
            // 
            this.btnUpdateCategory.Location = new System.Drawing.Point(339, 88);
            this.btnUpdateCategory.Name = "btnUpdateCategory";
            this.btnUpdateCategory.Size = new System.Drawing.Size(109, 23);
            this.btnUpdateCategory.TabIndex = 1;
            this.btnUpdateCategory.Text = "修改商品类别";
            this.btnUpdateCategory.UseVisualStyleBackColor = true;
            this.btnUpdateCategory.Click += new System.EventHandler(this.btnUpdateCategory_Click);
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.Location = new System.Drawing.Point(339, 133);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(109, 23);
            this.btnDeleteCategory.TabIndex = 2;
            this.btnDeleteCategory.Text = "删除商品类别";
            this.btnDeleteCategory.UseVisualStyleBackColor = true;
            this.btnDeleteCategory.Click += new System.EventHandler(this.btnDeleteCategory_Click);
            // 
            // btnAddPro
            // 
            this.btnAddPro.Location = new System.Drawing.Point(467, 158);
            this.btnAddPro.Name = "btnAddPro";
            this.btnAddPro.Size = new System.Drawing.Size(75, 23);
            this.btnAddPro.TabIndex = 3;
            this.btnAddPro.Text = "增加产品";
            this.btnAddPro.UseVisualStyleBackColor = true;
            this.btnAddPro.Click += new System.EventHandler(this.btnAddPro_Click);
            // 
            // btnUpdatePro
            // 
            this.btnUpdatePro.Location = new System.Drawing.Point(590, 158);
            this.btnUpdatePro.Name = "btnUpdatePro";
            this.btnUpdatePro.Size = new System.Drawing.Size(75, 23);
            this.btnUpdatePro.TabIndex = 4;
            this.btnUpdatePro.Text = "修改产品";
            this.btnUpdatePro.UseVisualStyleBackColor = true;
            this.btnUpdatePro.Click += new System.EventHandler(this.btnUpdatePro_Click);
            // 
            // btnDeletePro
            // 
            this.btnDeletePro.Location = new System.Drawing.Point(712, 158);
            this.btnDeletePro.Name = "btnDeletePro";
            this.btnDeletePro.Size = new System.Drawing.Size(75, 23);
            this.btnDeletePro.TabIndex = 5;
            this.btnDeletePro.Text = "删除产品";
            this.btnDeletePro.UseVisualStyleBackColor = true;
            this.btnDeletePro.Click += new System.EventHandler(this.btnDeletePro_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(531, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "检索";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(531, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "搜索";
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(590, 51);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(121, 20);
            this.cmbCategory.TabIndex = 8;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(590, 96);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(121, 21);
            this.txtSearch.TabIndex = 9;
            // 
            // dgvCategoryInfo
            // 
            this.dgvCategoryInfo.AllowUserToAddRows = false;
            this.dgvCategoryInfo.AllowUserToDeleteRows = false;
            this.dgvCategoryInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategoryInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvCategoryInfo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgvCategoryInfo.Location = new System.Drawing.Point(3, 17);
            this.dgvCategoryInfo.Name = "dgvCategoryInfo";
            this.dgvCategoryInfo.ReadOnly = true;
            this.dgvCategoryInfo.RowHeadersVisible = false;
            this.dgvCategoryInfo.RowTemplate.Height = 23;
            this.dgvCategoryInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCategoryInfo.Size = new System.Drawing.Size(312, 164);
            this.dgvCategoryInfo.TabIndex = 10;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "CatId";
            this.Column1.HeaderText = "商品类别id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "CatName";
            this.Column2.HeaderText = "商品类别";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "CatNum";
            this.Column3.HeaderText = "商品类别编号";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Remark";
            this.Column4.HeaderText = "商品备注";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // dgvProductInfo
            // 
            this.dgvProductInfo.AllowUserToAddRows = false;
            this.dgvProductInfo.AllowUserToDeleteRows = false;
            this.dgvProductInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13});
            this.dgvProductInfo.Location = new System.Drawing.Point(2, 11);
            this.dgvProductInfo.Name = "dgvProductInfo";
            this.dgvProductInfo.ReadOnly = true;
            this.dgvProductInfo.RowHeadersVisible = false;
            this.dgvProductInfo.RowTemplate.Height = 23;
            this.dgvProductInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductInfo.Size = new System.Drawing.Size(790, 264);
            this.dgvProductInfo.TabIndex = 11;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "ProId";
            this.Column5.HeaderText = "商品id";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Visible = false;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "ProNum";
            this.Column6.HeaderText = "产品编号";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "ProName";
            this.Column7.HeaderText = "产品名称";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "ProCost";
            this.Column8.HeaderText = "原价";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "ProSpell";
            this.Column9.HeaderText = "产品拼音";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "ProUnit";
            this.Column10.HeaderText = "单位";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "ProPrice";
            this.Column11.HeaderText = "单价";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "ProStock";
            this.Column12.HeaderText = "当前库存";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            // 
            // Column13
            // 
            this.Column13.DataPropertyName = "Remark";
            this.Column13.HeaderText = "备注";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvProductInfo);
            this.groupBox1.Location = new System.Drawing.Point(3, 187);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(795, 280);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // FrmCategroy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(799, 469);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvCategoryInfo);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeletePro);
            this.Controls.Add(this.btnUpdatePro);
            this.Controls.Add(this.btnAddPro);
            this.Controls.Add(this.btnDeleteCategory);
            this.Controls.Add(this.btnUpdateCategory);
            this.Controls.Add(this.btnAddCategory);
            this.Name = "FrmCategroy";
            this.Text = "商品类别和产品";
            this.Load += new System.EventHandler(this.FrmCategroy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoryInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductInfo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.Button btnUpdateCategory;
        private System.Windows.Forms.Button btnDeleteCategory;
        private System.Windows.Forms.Button btnAddPro;
        private System.Windows.Forms.Button btnUpdatePro;
        private System.Windows.Forms.Button btnDeletePro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvCategoryInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridView dgvProductInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}