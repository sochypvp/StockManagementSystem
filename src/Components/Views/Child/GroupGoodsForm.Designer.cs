namespace WarehouseMG.src.Components.Views.Child
{
    partial class GroupGoodsForm
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
            this.pContainer = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnViews = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pContainer
            // 
            this.pContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pContainer.Location = new System.Drawing.Point(12, 54);
            this.pContainer.Name = "pContainer";
            this.pContainer.Size = new System.Drawing.Size(930, 545);
            this.pContainer.TabIndex = 10;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(116, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(98, 36);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnViews
            // 
            this.btnViews.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnViews.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViews.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViews.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnViews.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViews.Location = new System.Drawing.Point(12, 12);
            this.btnViews.Name = "btnViews";
            this.btnViews.Size = new System.Drawing.Size(98, 36);
            this.btnViews.TabIndex = 8;
            this.btnViews.Text = "Views";
            this.btnViews.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnViews.UseVisualStyleBackColor = false;
            this.btnViews.Click += new System.EventHandler(this.btnViews_Click);
            // 
            // GroupGoodsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(954, 611);
            this.Controls.Add(this.pContainer);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnViews);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GroupGoodsForm";
            this.Text = "GroupGoods";
            this.Load += new System.EventHandler(this.GroupGoods_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pContainer;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnViews;
    }
}