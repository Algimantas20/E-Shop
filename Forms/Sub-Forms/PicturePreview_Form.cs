using System;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace E_Shop.Forms.Sub_Forms
{
    public partial class PicturePreview_Form : Form
    {
        public PicturePreview_Form(string filePath)
        {
            InitializeComponent();
            new A_Form(this).Apply(picture_PictureBox);

            this.back_Button.Click += (s, e) => { this.Close(); this.Dispose(); };

            GetImageFromFile(filePath);
        }
        #region -> Private Methods
        private void GetImageFromFile(string filePath)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    Image image = Image.FromFile(filePath);
                    picture_PictureBox.BackgroundImage = image;
                }
                else
                {
                    MessageBox.Show("Image file not found!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading image: {ex.Message}");
            }
        }
        #endregion
    }
}
