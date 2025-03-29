namespace E_Shop.Components
{
    partial class A_ItemWindow
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
            this.title_label = new System.Windows.Forms.Label();
            this.image_Box = new System.Windows.Forms.PictureBox();
            this.price_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.image_Box)).BeginInit();
            this.SuspendLayout();
            // 
            // title_label
            // 
            this.title_label.BackColor = System.Drawing.Color.Transparent;
            this.title_label.Enabled = false;
            this.title_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.title_label.ForeColor = System.Drawing.Color.Silver;
            this.title_label.Location = new System.Drawing.Point(3, 217);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(244, 33);
            this.title_label.TabIndex = 1;
            this.title_label.Text = "Title";
            this.title_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // image_Box
            // 
            this.image_Box.BackColor = System.Drawing.Color.Transparent;
            this.image_Box.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.image_Box.Enabled = false;
            this.image_Box.Location = new System.Drawing.Point(3, 3);
            this.image_Box.Name = "image_Box";
            this.image_Box.Size = new System.Drawing.Size(244, 211);
            this.image_Box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.image_Box.TabIndex = 3;
            this.image_Box.TabStop = false;
            // 
            // price_label
            // 
            this.price_label.BackColor = System.Drawing.Color.Transparent;
            this.price_label.Enabled = false;
            this.price_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price_label.ForeColor = System.Drawing.Color.Silver;
            this.price_label.Location = new System.Drawing.Point(3, 268);
            this.price_label.Name = "price_label";
            this.price_label.Size = new System.Drawing.Size(145, 23);
            this.price_label.TabIndex = 4;
            this.price_label.Text = "0";
            this.price_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // A_ItemWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(34)))));
            this.Controls.Add(this.price_label);
            this.Controls.Add(this.image_Box);
            this.Controls.Add(this.title_label);
            this.Name = "A_ItemWindow";
            this.Size = new System.Drawing.Size(250, 300);
            ((System.ComponentModel.ISupportInitialize)(this.image_Box)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.PictureBox image_Box;
        private System.Windows.Forms.Label price_label;
    }
}
