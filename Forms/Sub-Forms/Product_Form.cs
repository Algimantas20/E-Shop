using E_Shop.Classes;
using System.Threading.Tasks;
using System;
using System.Windows.Forms;

namespace E_Shop.Forms.Sub_Forms
{
    public partial class Product_Form : Form
    {
        private Form _parentForm;  
        public Product_Form(Product product)
        {
            InitializeComponent();
            new A_Form(this).Apply(product_Panel);

            if (User.Privilege != "Admin")
                editProduct_Button.Visible = false;

            title_Label.Text = product.Title;
            description_label.Text = product.Description;
            price_label.Text = $"€{product.Price:0.00}";
            product_PictureBox.Image = product.Image;
        }

        private async void Back_Button_Click(object sender, System.EventArgs e)
        {
            Shop_Form form = new Shop_Form();
            {
                form.StartPosition = FormStartPosition.Manual;
                form.Location = this.Location;
            }
            form.Show();
            form.BringToFront();
            await Task.Delay(3);
            this.Close();
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
