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
            SubscribeMethods();

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
                MessageBox.Show(text: $"Error loading image: {ex.Message}");
            }
        }

        private void SubscribeMethods()
        {
            new A_Form(form: this).Apply(panels: picture_PictureBox);

            this.back_Button.Click += (sender, e) => { this.Close(); this.Dispose(); };
        }
        #endregion
    }
}
