namespace WarehouseMG.src.Components.Views.Child
{
    partial class GoodsForm
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
            this.btnViews = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pContainer = new System.Windows.Forms.Panel();
            this.SuspendLayout();
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
            this.btnViews.TabIndex = 1;
            this.btnViews.Text = "Views";
            this.btnViews.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnViews.UseVisualStyleBackColor = false;
            this.btnViews.Click += new System.EventHandler(this.btnViews_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(116, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 36);
            this.button2.TabIndex = 2;
            this.button2.Text = "Add";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pContainer
            // 
            this.pContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pContainer.Location = new System.Drawing.Point(16, 66);
            this.pContainer.Location = new System.Drawing.Point(16, 67);
            this.pContainer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pContainer.Location = new System.Drawing.Point(12, 54);
            this.pContainer.Name = "pContainer";
            this.pContainer.Size = new System.Drawing.Size(930, 545);
            this.pContainer.TabIndex = 4;
            // 
            // GoodsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(954, 611);
            this.Controls.Add(this.pContainer);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnViews);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GoodsForm";
            this.Text = "GoodsForm";
            this.Load += new System.EventHandler(this.GoodsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel pContainer;
        public System.Windows.Forms.Button btnViews;
    }
}