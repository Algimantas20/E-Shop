using E_Shop.Classes;
using E_Shop.Components;

using System;
using System.Windows.Forms;

namespace E_Shop.Forms.Sub_Forms
{
    public partial class Product_Form : Form
    {
        private readonly Product _product;
        private readonly int _amount;

        public Product_Form(Product product, int amount)
        {
            _product = product;
            _amount = amount;

            InitializeComponent();
            SubscirbeMethods();
            UpdateGUI();
        }

        private void SubscirbeMethods()
        {
            new A_Form(form: this).Apply();
            this.back_Button.Click += (sender, e) => A_Button.OpenForm<Shop_Form>(currentForm: this);
            this.exitButton.Click += (sender, e) => Environment.Exit(exitCode: 0);
        }

        private void UpdateGUI()
        {
            title_Label.Text = _product.Title;
            description_Label.Text = _product.Description;
            price_Label.Text = $"Price: {_product.Price}$";
            amount_Label.Text = $"Amount: {_amount}";
            image_PictureBox.Image = _product.Image;
        }
    }
}
