namespace WarehouseMG.src.Components.Views.Child
{
    partial class FormReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReport));
            this.reportTableView = new System.Windows.Forms.DataGridView();
            this.gId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gCusId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gUserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lineTableView = new System.Windows.Forms.DataGridView();
            this.lineId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Groups = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.listCustomer = new System.Windows.Forms.ComboBox();
            this.txtCusSearch = new System.Windows.Forms.TextBox();
            this.txtUserSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listUser = new System.Windows.Forms.ComboBox();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.btnDelete = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.reportTableView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineTableView)).BeginInit();
            this.SuspendLayout();
            // 
            // reportTableView
            // 
            this.reportTableView.AllowUserToAddRows = false;
            this.reportTableView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.reportTableView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.reportTableView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.reportTableView.BackgroundColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.reportTableView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.reportTableView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reportTableView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gId,
            this.gDate,
            this.gCusId,
            this.gUserId});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("AKbalthom KhmerNew", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.reportTableView.DefaultCellStyle = dataGridViewCellStyle3;
            this.reportTableView.GridColor = System.Drawing.Color.DimGray;
            this.reportTableView.Location = new System.Drawing.Point(15, 108);
            this.reportTableView.MultiSelect = false;
            this.reportTableView.Name = "reportTableView";
            this.reportTableView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.reportTableView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.MediumAquamarine;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.reportTableView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.reportTableView.RowTemplate.Height = 25;
            this.reportTableView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.reportTableView.Size = new System.Drawing.Size(405, 491);
            this.reportTableView.TabIndex = 5;
            this.reportTableView.SelectionChanged += new System.EventHandler(this.reportTableView_SelectionChanged);
            this.reportTableView.Click += new System.EventHandler(this.reportTableView_Click);
            // 
            // gId
            // 
            this.gId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gId.FillWeight = 50F;
            this.gId.HeaderText = "ID";
            this.gId.Name = "gId";
            this.gId.ReadOnly = true;
            this.gId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // gDate
            // 
            this.gDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gDate.FillWeight = 120F;
            this.gDate.HeaderText = "Datetime";
            this.gDate.Name = "gDate";
            this.gDate.ReadOnly = true;
            this.gDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // gCusId
            // 
            this.gCusId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gCusId.FillWeight = 50F;
            this.gCusId.HeaderText = "Cus ID";
            this.gCusId.Name = "gCusId";
            this.gCusId.ReadOnly = true;
            this.gCusId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // gUserId
            // 
            this.gUserId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gUserId.FillWeight = 50F;
            this.gUserId.HeaderText = "User ID";
            this.gUserId.Name = "gUserId";
            this.gUserId.ReadOnly = true;
            this.gUserId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // lineTableView
            // 
            this.lineTableView.AllowUserToAddRows = false;
            this.lineTableView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            this.lineTableView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.lineTableView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lineTableView.BackgroundColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.lineTableView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.lineTableView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lineTableView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lineId,
            this.goodsID,
            this.QTY,
            this.Barcode,
            this.goodsName,
            this.Model,
            this.Groups});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("AKbalthom KhmerNew", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.lineTableView.DefaultCellStyle = dataGridViewCellStyle8;
            this.lineTableView.GridColor = System.Drawing.Color.DimGray;
            this.lineTableView.Location = new System.Drawing.Point(426, 108);
            this.lineTableView.MultiSelect = false;
            this.lineTableView.Name = "lineTableView";
            this.lineTableView.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.lineTableView.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.MediumAquamarine;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            this.lineTableView.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.lineTableView.RowTemplate.Height = 25;
            this.lineTableView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.lineTableView.Size = new System.Drawing.Size(516, 491);
            this.lineTableView.TabIndex = 6;
            // 
            // lineId
            // 
            this.lineId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lineId.HeaderText = "LineID";
            this.lineId.Name = "lineId";
            this.lineId.ReadOnly = true;
            // 
            // goodsID
            // 
            this.goodsID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.goodsID.HeaderText = "GoodsID";
            this.goodsID.Name = "goodsID";
            this.goodsID.ReadOnly = true;
            // 
            // QTY
            // 
            this.QTY.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.QTY.HeaderText = "QTY";
            this.QTY.Name = "QTY";
            this.QTY.ReadOnly = true;
            // 
            // Barcode
            // 
            this.Barcode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Barcode.HeaderText = "Barcode";
            this.Barcode.Name = "Barcode";
            this.Barcode.ReadOnly = true;
            // 
            // goodsName
            // 
            this.goodsName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.goodsName.HeaderText = "GoodsName";
            this.goodsName.Name = "goodsName";
            this.goodsName.ReadOnly = true;
            // 
            // Model
            // 
            this.Model.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Model.HeaderText = "Model";
            this.Model.Name = "Model";
            this.Model.ReadOnly = true;
            // 
            // Groups
            // 
            this.Groups.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Groups.HeaderText = "GroupsID";
            this.Groups.Name = "Groups";
            this.Groups.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 32;
            this.label1.Text = "Customer";
            // 
            // listCustomer
            // 
            this.listCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listCustomer.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.listCustomer.Font = new System.Drawing.Font("AKbalthom KhmerNew", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listCustomer.FormattingEnabled = true;
            this.listCustomer.Location = new System.Drawing.Point(100, 25);
            this.listCustomer.Name = "listCustomer";
            this.listCustomer.Size = new System.Drawing.Size(186, 30);
            this.listCustomer.TabIndex = 31;
            this.listCustomer.SelectedIndexChanged += new System.EventHandler(this.listCustomer_SelectedIndexChanged);
            // 
            // txtCusSearch
            // 
            this.txtCusSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCusSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusSearch.Location = new System.Drawing.Point(15, 27);
            this.txtCusSearch.Name = "txtCusSearch";
            this.txtCusSearch.Size = new System.Drawing.Size(79, 26);
            this.txtCusSearch.TabIndex = 33;
            this.txtCusSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCusSearch_KeyUp);
            // 
            // txtUserSearch
            // 
            this.txtUserSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserSearch.Location = new System.Drawing.Point(310, 27);
            this.txtUserSearch.Name = "txtUserSearch";
            this.txtUserSearch.Size = new System.Drawing.Size(79, 26);
            this.txtUserSearch.TabIndex = 36;
            this.txtUserSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtUserSearch_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(392, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 35;
            this.label2.Text = "User Accounts";
            // 
            // listUser
            // 
            this.listUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listUser.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.listUser.Font = new System.Drawing.Font("AKbalthom KhmerNew", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listUser.FormattingEnabled = true;
            this.listUser.Location = new System.Drawing.Point(395, 25);
            this.listUser.Name = "listUser";
            this.listUser.Size = new System.Drawing.Size(186, 30);
            this.listUser.TabIndex = 34;
            this.listUser.SelectedIndexChanged += new System.EventHandler(this.listUser_SelectedIndexChanged);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDelete.Image = global::WarehouseMG.Properties.Resources.Remove_20px2;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(15, 61);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(93, 41);
            this.btnDelete.TabIndex = 40;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Image = global::WarehouseMG.Properties.Resources.print_25px;
            this.button1.Location = new System.Drawing.Point(840, 20);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(2);
            this.button1.Size = new System.Drawing.Size(102, 41);
            this.button1.TabIndex = 39;
            this.button1.Text = "Print";
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
            this.btnRefresh.Location = new System.Drawing.Point(722, 20);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Padding = new System.Windows.Forms.Padding(2);
            this.btnRefresh.Size = new System.Drawing.Size(112, 41);
            this.btnRefresh.TabIndex = 38;
            this.btnRefresh.Text = "View All";
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSearch.Enabled = false;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSearch.Image = global::WarehouseMG.Properties.Resources.High_Indicator_Filter_20px1;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(600, 20);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Padding = new System.Windows.Forms.Padding(2);
            this.btnSearch.Size = new System.Drawing.Size(116, 41);
            this.btnSearch.TabIndex = 37;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FormReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(954, 611);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtUserSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listUser);
            this.Controls.Add(this.txtCusSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listCustomer);
            this.Controls.Add(this.lineTableView);
            this.Controls.Add(this.reportTableView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormReport";
            this.Text = "FormReport";
            this.Load += new System.EventHandler(this.FormReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reportTableView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineTableView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView reportTableView;
        private System.Windows.Forms.DataGridView lineTableView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox listCustomer;
        private System.Windows.Forms.TextBox txtCusSearch;
        private System.Windows.Forms.TextBox txtUserSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox listUser;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn lineId;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsID;
        private System.Windows.Forms.DataGridViewTextBoxColumn QTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn Groups;
        public System.Windows.Forms.Button btnRefresh;
        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn gId;
        private System.Windows.Forms.DataGridViewTextBoxColumn gDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn gCusId;
        private System.Windows.Forms.DataGridViewTextBoxColumn gUserId;
    }
}