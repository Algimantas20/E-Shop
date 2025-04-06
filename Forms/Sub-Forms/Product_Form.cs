using E_Shop.Classes;
using System.Threading.Tasks;
using System;
using System.Windows.Forms;
using E_Shop.Components;
using E_Shop.Database;

namespace E_Shop.Forms.Sub_Forms
{
    public partial class Product_Form : Form
    {
        private Product _product;
        public Product_Form(Product product)
        {
            InitializeComponent();
            new A_Form(this).Apply(product_Panel);

            this.addToCart_Button.Click += (s, e) => AppendOrderToDB();
            this.back_Button.Click += (s, e) => A_Button.OpenForm<Shop_Form>(this);
            this.exitButton.Click += async (s, e) => await A_Button.ExitApplication(this);

            if (User.Privilege != "Admin")
                editProduct_Button.Visible = false;

            _product = product;

            title_Label.Text = _product.Title;
            description_label.Text = _product.Description;
            price_label.Text = $"€{_product.Price:0.00}";
            product_PictureBox.Image = _product.Image;
        }

        #region -> Private Methods
        private void Product_Form_Load(object sender, EventArgs e)
        {
            this.cartTableAdapter.Fill(this.e_Shop_DatabaseDataSet.Cart);
        }

        private void AppendOrderToDB()
        {
            try
            {
                E_Shop_DatabaseDataSet.CartRow newCartRow;
                newCartRow = e_Shop_DatabaseDataSet.Cart.NewCartRow();

                newCartRow.User_Id = User.Id;
                newCartRow.Product_Id = _product.ID;

                this.e_Shop_DatabaseDataSet.Cart.Rows.Add(newCartRow);
                newCartRow.EndEdit();
                int rowsAffected = this.cartTableAdapter.Update(e_Shop_DatabaseDataSet.Cart);

                this.e_Shop_DatabaseDataSet.AcceptChanges();
                MessageBox.Show("Works");
                A_Button.OpenForm<Shop_Form>(this);
            }
            catch (Exception ex)
            {
                e_Shop_DatabaseDataSet.RejectChanges();

                throw new Exception(ex.Message);
            }

        }
        #endregion
    }
}
