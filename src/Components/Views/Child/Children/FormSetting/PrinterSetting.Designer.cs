namespace WarehouseMG.src.Components.Views.Child.Children.FormSetting
{
    partial class PrinterSetting
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.printerSelectionBox = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.printerComboBox = new System.Windows.Forms.ComboBox();
            this.printButton = new System.Windows.Forms.Button();
            this.printerSelectionBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "PDF Printing",
            "Printing with Printer Devices"});
            this.comboBox1.Location = new System.Drawing.Point(12, 41);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(222, 26);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Change printer";
            // 
            // printerSelectionBox
            // 
            this.printerSelectionBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.printerSelectionBox.Controls.Add(this.printButton);
            this.printerSelectionBox.Controls.Add(this.label2);
            this.printerSelectionBox.Controls.Add(this.printerComboBox);
            this.printerSelectionBox.Location = new System.Drawing.Point(12, 82);
            this.printerSelectionBox.Name = "printerSelectionBox";
            this.printerSelectionBox.Size = new System.Drawing.Size(419, 98);
            this.printerSelectionBox.TabIndex = 2;
            this.printerSelectionBox.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Selecct Printer Devices";
            // 
            // printerComboBox
            // 
            this.printerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.printerComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printerComboBox.FormattingEnabled = true;
            this.printerComboBox.Location = new System.Drawing.Point(13, 37);
            this.printerComboBox.Name = "printerComboBox";
            this.printerComboBox.Size = new System.Drawing.Size(253, 26);
            this.printerComboBox.TabIndex = 3;
            // 
            // printButton
            // 
            this.printButton.BackColor = System.Drawing.Color.White;
            this.printButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.printButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.printButton.Image = global::WarehouseMG.Properties.Resources.save_20px1;
            this.printButton.Location = new System.Drawing.Point(284, 30);
            this.printButton.Name = "printButton";
            this.printButton.Padding = new System.Windows.Forms.Padding(2);
            this.printButton.Size = new System.Drawing.Size(108, 38);
            this.printButton.TabIndex = 41;
            this.printButton.Text = "Save";
            this.printButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.printButton.UseVisualStyleBackColor = false;
            this.printButton.Click += new System.EventHandler(this.printButton_Click_1);
            // 
            // PrinterSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(930, 524);
            this.Controls.Add(this.printerSelectionBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PrinterSetting";
            this.Text = "PrinterSetting";
            this.Load += new System.EventHandler(this.PrinterSetting_Load);
            this.printerSelectionBox.ResumeLayout(false);
            this.printerSelectionBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel printerSelectionBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox printerComboBox;
        public System.Windows.Forms.Button printButton;
    }
}