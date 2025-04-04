using E_Shop.Classes;
using System.Threading.Tasks;
using System;
using System.Windows.Forms;
using E_Shop.Components;

namespace E_Shop.Forms.Sub_Forms
{
    public partial class Product_Form : Form
    {
        public Product_Form(Product product)
        {
            InitializeComponent();

            new A_Form(this).Apply(product_Panel);

            this.back_Button.Click += (s, e) => A_Button.OpenForm<Shop_Form>(this);
            this.exitButton.Click += (s, e) => A_Button.ExitApplication(this);

            if (User.Privilege != "Admin")
                editProduct_Button.Visible = false;

            title_Label.Text = product.Title;
            description_label.Text = product.Description;
            price_label.Text = $"€{product.Price:0.00}";
            product_PictureBox.Image = product.Image;
        }
    }
}
