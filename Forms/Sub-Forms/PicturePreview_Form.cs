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
            GetImageFromFile(filePath);
        }

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

        private void Back_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
