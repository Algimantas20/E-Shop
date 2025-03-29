namespace E_Shop.Components
{
    partial class A_SidePanelButton
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.PictureBox icon_PictureBox;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.icon_PictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.icon_PictureBox)).BeginInit();
            this.SuspendLayout();

            // icon_PictureBox
            this.icon_PictureBox.BackColor = System.Drawing.Color.Transparent;
            this.icon_PictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.icon_PictureBox.Location = new System.Drawing.Point(3, 3);
            this.icon_PictureBox.Name = "icon_PictureBox";
            this.icon_PictureBox.Size = new System.Drawing.Size(34, 34);
            this.icon_PictureBox.TabIndex = 0;
            this.icon_PictureBox.TabStop = false;
            this.icon_PictureBox.Enabled = false;

            // A_SidePanelButton
            this.BackColor = System.Drawing.Color.FromArgb(29, 30, 33);
            this.Controls.Add(this.icon_PictureBox);
            this.Size = new System.Drawing.Size(177, 40);
            this.UseVisualStyleBackColor = false;

            ((System.ComponentModel.ISupportInitialize)(this.icon_PictureBox)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
