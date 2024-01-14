namespace WarehouseMG.src.Components.Views.Child.Children
{
    partial class GoodFormViews
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.goodsTableView = new System.Windows.Forms.DataGridView();
            this.gId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gBarcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gDetails = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearchBox = new System.Windows.Forms.TextBox();
            this.txtStockQtyAlert1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotalGoodsQty = new System.Windows.Forms.TextBox();
            this.txtTotalGoods = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.goodsTableView)).BeginInit();
            this.SuspendLayout();
            // 
            // goodsTableView
            // 
            this.goodsTableView.AllowUserToAddRows = false;
            this.goodsTableView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.goodsTableView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.goodsTableView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.goodsTableView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.goodsTableView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.goodsTableView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gId,
            this.gBarcode,
            this.gName,
            this.gModel,
            this.gQty,
            this.gDesc,
            this.gDetails,
            this.gDate,
            this.gGroup});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("AKbalthom KhmerNew", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.goodsTableView.DefaultCellStyle = dataGridViewCellStyle4;
            this.goodsTableView.Location = new System.Drawing.Point(3, 53);
            this.goodsTableView.Name = "goodsTableView";
            this.goodsTableView.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.goodsTableView.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.MediumAquamarine;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.goodsTableView.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.goodsTableView.RowTemplate.Height = 25;
            this.goodsTableView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.goodsTableView.Size = new System.Drawing.Size(924, 455);
            this.goodsTableView.TabIndex = 4;
            this.goodsTableView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.goodsTableView_CellValueChanged);
            // 
            // gId
            // 
            this.gId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gId.FillWeight = 50F;
            this.gId.HeaderText = "ID";
            this.gId.Name = "gId";
            this.gId.ReadOnly = true;
            // 
            // gBarcode
            // 
            this.gBarcode.HeaderText = "Barcode";
            this.gBarcode.Name = "gBarcode";
            this.gBarcode.ReadOnly = true;
            // 
            // gName
            // 
            this.gName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gName.HeaderText = "Name";
            this.gName.Name = "gName";
            this.gName.ReadOnly = true;
            // 
            // gModel
            // 
            this.gModel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gModel.HeaderText = "Model";
            this.gModel.Name = "gModel";
            this.gModel.ReadOnly = true;
            // 
            // gQty
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gQty.DefaultCellStyle = dataGridViewCellStyle3;
            this.gQty.HeaderText = "Qty";
            this.gQty.Name = "gQty";
            this.gQty.ReadOnly = true;
            // 
            // gDesc
            // 
            this.gDesc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gDesc.HeaderText = "Description";
            this.gDesc.Name = "gDesc";
            this.gDesc.ReadOnly = true;
            // 
            // gDetails
            // 
            this.gDetails.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gDetails.HeaderText = "Details";
            this.gDetails.Name = "gDetails";
            this.gDetails.ReadOnly = true;
            // 
            // gDate
            // 
            this.gDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gDate.HeaderText = "Date";
            this.gDate.Name = "gDate";
            this.gDate.ReadOnly = true;
            // 
            // gGroup
            // 
            this.gGroup.HeaderText = "Groups";
            this.gGroup.Name = "gGroup";
            this.gGroup.ReadOnly = true;
            // 
            // txtSearchBox
            // 
            this.txtSearchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchBox.Location = new System.Drawing.Point(3, 16);
            this.txtSearchBox.Name = "txtSearchBox";
            this.txtSearchBox.Size = new System.Drawing.Size(227, 26);
            this.txtSearchBox.TabIndex = 8;
            this.txtSearchBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearchBox_KeyUp);
            // 
            // txtStockQtyAlert1
            // 
            this.txtStockQtyAlert1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStockQtyAlert1.BackColor = System.Drawing.Color.Red;
            this.txtStockQtyAlert1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStockQtyAlert1.Font = new System.Drawing.Font("AKbalthom KhmerNew", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStockQtyAlert1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtStockQtyAlert1.Location = new System.Drawing.Point(786, 511);
            this.txtStockQtyAlert1.Name = "txtStockQtyAlert1";
            this.txtStockQtyAlert1.Padding = new System.Windows.Forms.Padding(4);
            this.txtStockQtyAlert1.Size = new System.Drawing.Size(141, 31);
            this.txtStockQtyAlert1.TabIndex = 11;
            this.txtStockQtyAlert1.Text = "ត្រូវការទិញទំនិញបន្ទាន់";
            this.txtStockQtyAlert1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtStockQtyAlert1.Click += new System.EventHandler(this.txtStockQtyAlert1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Gold;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("AKbalthom KhmerNew", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(641, 511);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(4);
            this.label1.Size = new System.Drawing.Size(139, 31);
            this.label1.TabIndex = 12;
            this.label1.Text = "ទំនិញជិតអស់";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("AKbalthom KhmerNew", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(496, 511);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(4);
            this.label2.Size = new System.Drawing.Size(139, 31);
            this.label2.TabIndex = 13;
            this.label2.Text = "ទំនិញគ្រប់គ្រាន់";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // txtTotalGoodsQty
            // 
            this.txtTotalGoodsQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTotalGoodsQty.BackColor = System.Drawing.Color.LightGray;
            this.txtTotalGoodsQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalGoodsQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalGoodsQty.Location = new System.Drawing.Point(320, 513);
            this.txtTotalGoodsQty.Name = "txtTotalGoodsQty";
            this.txtTotalGoodsQty.ReadOnly = true;
            this.txtTotalGoodsQty.Size = new System.Drawing.Size(103, 26);
            this.txtTotalGoodsQty.TabIndex = 14;
            // 
            // txtTotalGoods
            // 
            this.txtTotalGoods.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTotalGoods.BackColor = System.Drawing.Color.LightGray;
            this.txtTotalGoods.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalGoods.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalGoods.Location = new System.Drawing.Point(85, 513);
            this.txtTotalGoods.Name = "txtTotalGoods";
            this.txtTotalGoods.ReadOnly = true;
            this.txtTotalGoods.Size = new System.Drawing.Size(103, 26);
            this.txtTotalGoods.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 518);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Total Goods";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(194, 518);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Total Qty All Goods";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Image = global::WarehouseMG.Properties.Resources.microsoft_excel_2019_25px;
            this.button1.Location = new System.Drawing.Point(815, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 37);
            this.button1.TabIndex = 18;
            this.button1.Text = "Export";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.BackColor = System.Drawing.Color.White;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRefresh.Image = global::WarehouseMG.Properties.Resources.refresh_20px2;
            this.btnRefresh.Location = new System.Drawing.Point(489, 10);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(112, 37);
            this.btnRefresh.TabIndex = 10;
            this.btnRefresh.Text = "View All";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.White;
            this.btnFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFilter.Image = global::WarehouseMG.Properties.Resources.High_Indicator_Filter_20px;
            this.btnFilter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFilter.Location = new System.Drawing.Point(237, 11);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(98, 37);
            this.btnFilter.TabIndex = 9;
            this.btnFilter.Text = "Filter";
            this.btnFilter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFilter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.BackColor = System.Drawing.Color.White;
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEdit.Image = global::WarehouseMG.Properties.Resources.Edit_Text_File_20px;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(607, 10);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(98, 37);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Edit";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDelete.Image = global::WarehouseMG.Properties.Resources.Remove_20px2;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(711, 10);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(98, 37);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // GoodFormViews
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(930, 545);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTotalGoods);
            this.Controls.Add(this.txtTotalGoodsQty);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtStockQtyAlert1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.txtSearchBox);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.goodsTableView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GoodFormViews";
            this.Text = "GoodFormChild";
            this.Load += new System.EventHandler(this.GoodFormViews_Load);
            ((System.ComponentModel.ISupportInitialize)(this.goodsTableView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView goodsTableView;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox txtSearchBox;
        private System.Windows.Forms.Button btnFilter;
        public System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn gId;
        private System.Windows.Forms.DataGridViewTextBoxColumn gBarcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn gName;
        private System.Windows.Forms.DataGridViewTextBoxColumn gModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn gQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn gDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn gDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn gDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn gGroup;
        private System.Windows.Forms.Label txtStockQtyAlert1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTotalGoodsQty;
        private System.Windows.Forms.TextBox txtTotalGoods;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Button button1;
    }
}