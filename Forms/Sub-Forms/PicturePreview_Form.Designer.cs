namespace E_Shop.Forms.Sub_Forms
{
    partial class PicturePreview_Form
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
            this.back_Button = new System.Windows.Forms.Label();
            this.picture_PictureBox = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // back_Button
            // 
            this.back_Button.AutoSize = true;
            this.back_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_Button.Location = new System.Drawing.Point(16, 11);
            this.back_Button.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.back_Button.Name = "back_Button";
            this.back_Button.Size = new System.Drawing.Size(24, 25);
            this.back_Button.TabIndex = 4;
            this.back_Button.Text = "<";
            // 
            // picture_PictureBox
            // 
            this.picture_PictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picture_PictureBox.Location = new System.Drawing.Point(16, 46);
            this.picture_PictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.picture_PictureBox.Name = "picture_PictureBox";
            this.picture_PictureBox.Size = new System.Drawing.Size(971, 541);
            this.picture_PictureBox.TabIndex = 5;
            // 
            // PicturePreview_Form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.picture_PictureBox);
            this.Controls.Add(this.back_Button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PicturePreview_Form";
            this.Text = "PicturePreview_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label back_Button;
        private System.Windows.Forms.Panel picture_PictureBox;
    }
}