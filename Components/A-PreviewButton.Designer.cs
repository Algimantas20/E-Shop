namespace E_Shop.Components
{
    partial class A_PreviewButton
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.PictureBox icon_PictureBox;

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

        private void InitializeComponent()
        {
            this.icon_PictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.icon_PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // icon_PictureBox
            // 
            this.icon_PictureBox.BackColor = System.Drawing.Color.Transparent;
            this.icon_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.icon_PictureBox.Location = new System.Drawing.Point(3, 3);
            this.icon_PictureBox.Name = "icon_PictureBox";
            this.icon_PictureBox.Size = new System.Drawing.Size(35, 35);
            this.icon_PictureBox.TabIndex = 0;
            this.icon_PictureBox.TabStop = false;
            this.icon_PictureBox.Enabled = false;

            // 
            // A_PreviewButton
            // 
            this.FlatAppearance.BorderSize = 0;
            this.Size = new System.Drawing.Size(40, 40);
            this.Controls.Add(this.icon_PictureBox);
            ((System.ComponentModel.ISupportInitialize)(this.icon_PictureBox)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion
    }
}
