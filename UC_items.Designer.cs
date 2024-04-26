
namespace caseStudy
{
    partial class UC_items
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.imgItem = new System.Windows.Forms.PictureBox();
            this.ItemName = new System.Windows.Forms.Label();
            this.ItemPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgItem)).BeginInit();
            this.SuspendLayout();
            // 
            // imgItem
            // 
            this.imgItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgItem.Location = new System.Drawing.Point(3, 3);
            this.imgItem.Name = "imgItem";
            this.imgItem.Size = new System.Drawing.Size(194, 141);
            this.imgItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgItem.TabIndex = 0;
            this.imgItem.TabStop = false;
            // 
            // ItemName
            // 
            this.ItemName.AutoSize = true;
            this.ItemName.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemName.Location = new System.Drawing.Point(12, 164);
            this.ItemName.Name = "ItemName";
            this.ItemName.Size = new System.Drawing.Size(96, 23);
            this.ItemName.TabIndex = 1;
            this.ItemName.Text = "ItemName";
            // 
            // ItemPrice
            // 
            this.ItemPrice.AutoSize = true;
            this.ItemPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ItemPrice.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemPrice.Location = new System.Drawing.Point(146, 164);
            this.ItemPrice.Name = "ItemPrice";
            this.ItemPrice.Size = new System.Drawing.Size(32, 25);
            this.ItemPrice.TabIndex = 2;
            this.ItemPrice.Text = "10";
            // 
            // UC_items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ItemPrice);
            this.Controls.Add(this.ItemName);
            this.Controls.Add(this.imgItem);
            this.Name = "UC_items";
            this.Size = new System.Drawing.Size(200, 200);
            ((System.ComponentModel.ISupportInitialize)(this.imgItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgItem;
        private System.Windows.Forms.Label ItemName;
        private System.Windows.Forms.Label ItemPrice;
    }
}
