namespace WarehouseMG.src.Components.Views.Child
{
    partial class OrderGoods
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderGoods));
            this.listCategory = new System.Windows.Forms.ComboBox();
            this.listGroups = new System.Windows.Forms.ComboBox();
            this.goodsTableView = new System.Windows.Forms.DataGridView();
            this.gId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gBarcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsCartBox = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addOne = new System.Windows.Forms.Button();
            this.backOne = new System.Windows.Forms.Button();
            this.addAll = new System.Windows.Forms.Button();
            this.backAll = new System.Windows.Forms.Button();
            this.ff = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearchBox = new System.Windows.Forms.TextBox();
            this.listCustomer = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.addWithNumber = new System.Windows.Forms.NumericUpDown();
            this.backWithNumber = new System.Windows.Forms.NumericUpDown();
            this.btnAddNumber = new System.Windows.Forms.Button();
            this.btnBackNumber = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.goodsTableView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsCartBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addWithNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backWithNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // listCategory
            // 
            this.listCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listCategory.DropDownWidth = 211;
            this.listCategory.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.listCategory.Font = new System.Drawing.Font("AKbalthom KhmerNew", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listCategory.FormattingEnabled = true;
            this.listCategory.Location = new System.Drawing.Point(12, 29);
            this.listCategory.Name = "listCategory";
            this.listCategory.Size = new System.Drawing.Size(211, 30);
            this.listCategory.TabIndex = 33;
            this.listCategory.SelectedIndexChanged += new System.EventHandler(this.listCategory_SelectedIndexChanged);
            // 
            // listGroups
            // 
            this.listGroups.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listGroups.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.listGroups.Font = new System.Drawing.Font("AKbalthom KhmerNew", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listGroups.FormattingEnabled = true;
            this.listGroups.Location = new System.Drawing.Point(238, 29);
            this.listGroups.Name = "listGroups";
            this.listGroups.Size = new System.Drawing.Size(211, 30);
            this.listGroups.TabIndex = 34;
            this.listGroups.SelectedIndexChanged += new System.EventHandler(this.listGroups_SelectedIndexChanged);
            // 
            // goodsTableView
            // 
            this.goodsTableView.AllowUserToAddRows = false;
            this.goodsTableView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.goodsTableView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.goodsTableView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
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
            this.Column1});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("AKbalthom KhmerNew", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.MediumAquamarine;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.goodsTableView.DefaultCellStyle = dataGridViewCellStyle5;
            this.goodsTableView.Location = new System.Drawing.Point(12, 161);
            this.goodsTableView.Name = "goodsTableView";
            this.goodsTableView.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.goodsTableView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("AKbalthom KhmerNew", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goodsTableView.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.goodsTableView.RowTemplate.Height = 25;
            this.goodsTableView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.goodsTableView.Size = new System.Drawing.Size(421, 438);
            this.goodsTableView.TabIndex = 35;
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
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.gBarcode.DefaultCellStyle = dataGridViewCellStyle3;
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
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("AKbalthom KhmerNew", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column1.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column1.FillWeight = 50F;
            this.Column1.HeaderText = "Qty";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // goodsCartBox
            // 
            this.goodsCartBox.AllowUserToAddRows = false;
            this.goodsCartBox.AllowUserToDeleteRows = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.goodsCartBox.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
            this.goodsCartBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.goodsCartBox.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.goodsCartBox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.goodsCartBox.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.Qty});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("AKbalthom KhmerNew", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.MediumAquamarine;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.goodsCartBox.DefaultCellStyle = dataGridViewCellStyle12;
            this.goodsCartBox.Location = new System.Drawing.Point(550, 161);
            this.goodsCartBox.Name = "goodsCartBox";
            this.goodsCartBox.ReadOnly = true;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.goodsCartBox.RowHeadersDefaultCellStyle = dataGridViewCellStyle13;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("AKbalthom KhmerNew", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goodsCartBox.RowsDefaultCellStyle = dataGridViewCellStyle14;
            this.goodsCartBox.RowTemplate.Height = 25;
            this.goodsCartBox.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.goodsCartBox.Size = new System.Drawing.Size(392, 438);
            this.goodsCartBox.TabIndex = 36;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id.FillWeight = 50F;
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewTextBoxColumn2.HeaderText = "Barcode";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.HeaderText = "Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.HeaderText = "Model";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // Qty
            // 
            this.Qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("AKbalthom KhmerNew", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Qty.DefaultCellStyle = dataGridViewCellStyle11;
            this.Qty.FillWeight = 50F;
            this.Qty.HeaderText = "Qty";
            this.Qty.Name = "Qty";
            this.Qty.ReadOnly = true;
            // 
            // addOne
            // 
            this.addOne.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.addOne.BackColor = System.Drawing.Color.White;
            this.addOne.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.addOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addOne.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addOne.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addOne.Location = new System.Drawing.Point(440, 258);
            this.addOne.Name = "addOne";
            this.addOne.Size = new System.Drawing.Size(104, 30);
            this.addOne.TabIndex = 37;
            this.addOne.Text = ">";
            this.addOne.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addOne.UseVisualStyleBackColor = false;
            this.addOne.Click += new System.EventHandler(this.addOne_Click);
            // 
            // backOne
            // 
            this.backOne.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.backOne.BackColor = System.Drawing.Color.White;
            this.backOne.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.backOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backOne.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.backOne.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.backOne.Location = new System.Drawing.Point(440, 392);
            this.backOne.Name = "backOne";
            this.backOne.Size = new System.Drawing.Size(104, 30);
            this.backOne.TabIndex = 38;
            this.backOne.Text = "<";
            this.backOne.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.backOne.UseVisualStyleBackColor = false;
            this.backOne.Click += new System.EventHandler(this.backOne_Click);
            // 
            // addAll
            // 
            this.addAll.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.addAll.BackColor = System.Drawing.Color.White;
            this.addAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.addAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAll.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addAll.Location = new System.Drawing.Point(440, 326);
            this.addAll.Name = "addAll";
            this.addAll.Size = new System.Drawing.Size(104, 30);
            this.addAll.TabIndex = 39;
            this.addAll.Text = ">>";
            this.addAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addAll.UseVisualStyleBackColor = false;
            this.addAll.Click += new System.EventHandler(this.addAll_Click);
            // 
            // backAll
            // 
            this.backAll.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.backAll.BackColor = System.Drawing.Color.White;
            this.backAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.backAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backAll.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.backAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.backAll.Location = new System.Drawing.Point(440, 460);
            this.backAll.Name = "backAll";
            this.backAll.Size = new System.Drawing.Size(104, 30);
            this.backAll.TabIndex = 40;
            this.backAll.Text = "<<";
            this.backAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.backAll.UseVisualStyleBackColor = false;
            this.backAll.Click += new System.EventHandler(this.backAll_Click);
            // 
            // ff
            // 
            this.ff.AutoSize = true;
            this.ff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ff.Location = new System.Drawing.Point(12, 10);
            this.ff.Name = "ff";
            this.ff.Size = new System.Drawing.Size(62, 16);
            this.ff.TabIndex = 42;
            this.ff.Text = "Category";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(235, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 43;
            this.label1.Text = "Groups goods";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 44;
            this.label2.Text = "Find Customer ";
            // 
            // txtSearchBox
            // 
            this.txtSearchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchBox.Font = new System.Drawing.Font("AKbalthom KhmerNew", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchBox.Location = new System.Drawing.Point(12, 89);
            this.txtSearchBox.Name = "txtSearchBox";
            this.txtSearchBox.Size = new System.Drawing.Size(137, 30);
            this.txtSearchBox.TabIndex = 31;
            this.txtSearchBox.TextChanged += new System.EventHandler(this.txtSearchBox_TextChanged);
            this.txtSearchBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearchBox_KeyUp);
            // 
            // listCustomer
            // 
            this.listCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listCustomer.DropDownWidth = 155;
            this.listCustomer.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.listCustomer.Font = new System.Drawing.Font("AKbalthom KhmerNew", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listCustomer.FormattingEnabled = true;
            this.listCustomer.Location = new System.Drawing.Point(155, 89);
            this.listCustomer.Name = "listCustomer";
            this.listCustomer.Size = new System.Drawing.Size(164, 30);
            this.listCustomer.TabIndex = 45;
            this.listCustomer.SelectedIndexChanged += new System.EventHandler(this.listCustomer_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(152, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 47;
            this.label3.Text = "Customer List";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::WarehouseMG.Properties.Resources.close_window_20px;
            this.pictureBox1.Location = new System.Drawing.Point(423, 92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.White;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button6.Enabled = false;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button6.Image = global::WarehouseMG.Properties.Resources.Add_Male_User_Group_20px;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(325, 89);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(124, 30);
            this.button6.TabIndex = 46;
            this.button6.Text = "Add";
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button5.Enabled = false;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button5.Image = global::WarehouseMG.Properties.Resources.buy_for_cash_30px;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(820, 52);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(106, 54);
            this.button5.TabIndex = 41;
            this.button5.Text = "Order";
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSave.Enabled = false;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSave.Image = global::WarehouseMG.Properties.Resources.High_Indicator_Filter_20px1;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(12, 125);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(137, 30);
            this.btnSave.TabIndex = 32;
            this.btnSave.Text = "Search";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // addWithNumber
            // 
            this.addWithNumber.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.addWithNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addWithNumber.Location = new System.Drawing.Point(440, 294);
            this.addWithNumber.Name = "addWithNumber";
            this.addWithNumber.Size = new System.Drawing.Size(71, 26);
            this.addWithNumber.TabIndex = 53;
            this.addWithNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.addWithNumber.ValueChanged += new System.EventHandler(this.addWithNumber_ValueChanged);
            // 
            // backWithNumber
            // 
            this.backWithNumber.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.backWithNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backWithNumber.Location = new System.Drawing.Point(473, 428);
            this.backWithNumber.Name = "backWithNumber";
            this.backWithNumber.Size = new System.Drawing.Size(71, 26);
            this.backWithNumber.TabIndex = 54;
            this.backWithNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.backWithNumber.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // btnAddNumber
            // 
            this.btnAddNumber.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAddNumber.BackColor = System.Drawing.Color.White;
            this.btnAddNumber.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAddNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNumber.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddNumber.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNumber.Location = new System.Drawing.Point(517, 291);
            this.btnAddNumber.Name = "btnAddNumber";
            this.btnAddNumber.Size = new System.Drawing.Size(27, 32);
            this.btnAddNumber.TabIndex = 55;
            this.btnAddNumber.Text = ">";
            this.btnAddNumber.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddNumber.UseVisualStyleBackColor = false;
            this.btnAddNumber.Click += new System.EventHandler(this.btnAddNumber_Click);
            // 
            // btnBackNumber
            // 
            this.btnBackNumber.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnBackNumber.BackColor = System.Drawing.Color.White;
            this.btnBackNumber.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBackNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackNumber.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBackNumber.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBackNumber.Location = new System.Drawing.Point(440, 425);
            this.btnBackNumber.Name = "btnBackNumber";
            this.btnBackNumber.Size = new System.Drawing.Size(27, 32);
            this.btnBackNumber.TabIndex = 56;
            this.btnBackNumber.Text = "<";
            this.btnBackNumber.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBackNumber.UseVisualStyleBackColor = false;
            this.btnBackNumber.Click += new System.EventHandler(this.btnBackNumber_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
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
            // 
            // OrderGoods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(954, 611);
            this.Controls.Add(this.btnBackNumber);
            this.Controls.Add(this.btnAddNumber);
            this.Controls.Add(this.backWithNumber);
            this.Controls.Add(this.addWithNumber);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.listCustomer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ff);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.backAll);
            this.Controls.Add(this.addAll);
            this.Controls.Add(this.backOne);
            this.Controls.Add(this.addOne);
            this.Controls.Add(this.goodsCartBox);
            this.Controls.Add(this.goodsTableView);
            this.Controls.Add(this.listGroups);
            this.Controls.Add(this.listCategory);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtSearchBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrderGoods";
            this.Text = "OrderGoods";
            this.Load += new System.EventHandler(this.OrderGoods_Load);
            ((System.ComponentModel.ISupportInitialize)(this.goodsTableView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsCartBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addWithNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backWithNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox listCategory;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox listGroups;
        private System.Windows.Forms.DataGridView goodsTableView;
        private System.Windows.Forms.DataGridView goodsCartBox;
        private System.Windows.Forms.Button addOne;
        private System.Windows.Forms.Button backOne;
        private System.Windows.Forms.Button addAll;
        private System.Windows.Forms.Button backAll;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label ff;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearchBox;
        private System.Windows.Forms.ComboBox listCustomer;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gId;
        private System.Windows.Forms.DataGridViewTextBoxColumn gBarcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn gName;
        private System.Windows.Forms.DataGridViewTextBoxColumn gModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.NumericUpDown addWithNumber;
        private System.Windows.Forms.NumericUpDown backWithNumber;
        private System.Windows.Forms.Button btnAddNumber;
        private System.Windows.Forms.Button btnBackNumber;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}