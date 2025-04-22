using E_Shop.Classes;
using E_Shop.Components;
using static E_Shop.Database.E_Shop_DatabaseDataSet;

using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace E_Shop.Forms.Sub_Forms
{
    public partial class Product_Form : Form
    {
        private Product _product;
        public Product_Form(Product product)
        {
            _product = product;

            InitializeComponent();
            SubscribeMethods();

            ChangeLabelText();

            if (User.Privilege != "Admin")
                editProduct_Button.Visible = false;
        }

        #region -> Event Handlers

        private void Product_Form_Load(object sender, EventArgs e)
        {
            this.cartTableAdapter.Fill(this.e_Shop_DatabaseDataSet.Cart);
        }

        #endregion

        #region -> Private Methods
        private async void AppendOrderToDB()
        {
            DataRow row = e_Shop_DatabaseDataSet.Cart.Select($"User_Id = '{User.Id}' AND Product_Id = '{_product.ID}'").FirstOrDefault();
            if (CheckIfItemIsInCart(row))
            {
                await ChangeProductAmount(row);
                return;
            }

            try
            {
                CartRow newCartRow = GenerateNewRow();

                this.e_Shop_DatabaseDataSet.Cart.Rows.Add(newCartRow);
                this.cartTableAdapter.Update(e_Shop_DatabaseDataSet.Cart);

                this.e_Shop_DatabaseDataSet.AcceptChanges();
                await MessageHelper.PrintOutMessage("Product amount updated successfully.", output_label, MessageType.Success);
            }
            catch (Exception ex)
            {
                e_Shop_DatabaseDataSet.RejectChanges();
                await MessageHelper.PrintOutMessage(ex.Message, output_label, MessageType.Error);
            }
        }

        private void ChangeLabelText()
        {
            title_Label.Text = _product.Title;
            description_label.Text = _product.Description;
            price_label.Text = $"€{_product.Price:0.00}";
            image_Box.Image = _product.Image;
        }

        private void SubscribeMethods()
        {
            new A_Form(this).Apply(product_Panel);

            this.addToCart_Button.Click += (s, e) => AppendOrderToDB();
            this.back_Button.Click += (s, e) => A_Button.OpenForm<Shop_Form>(this);
            this.exitButton.Click += async (s, e) => await A_Button.ExitApplication(this);
        }

        private CartRow GenerateNewRow()
        {
            CartRow newCartRow = e_Shop_DatabaseDataSet.Cart.NewCartRow();

            newCartRow.User_Id = User.Id;
            newCartRow.Product_Id = _product.ID;
            newCartRow.Amount = 1;
            newCartRow.EndEdit();

            return newCartRow;
        }

        private async Task ChangeProductAmount(DataRow row)
        {
            try
            {
                row.BeginEdit();
                row["Amount"] = int.Parse(row["Amount"].ToString()) + 1;
                row.EndEdit();

                this.cartTableAdapter.Update(e_Shop_DatabaseDataSet.Cart);
                this.e_Shop_DatabaseDataSet.AcceptChanges();
                await MessageHelper.PrintOutMessage("Product amount updated successfully.", output_label, MessageType.Success);
            }
            catch (Exception ex)
            {
                e_Shop_DatabaseDataSet.RejectChanges();
                await MessageHelper.PrintOutMessage(ex.Message, output_label, MessageType.Error);
            }
        }

        private bool CheckIfItemIsInCart(DataRow dataRow)
        {     
            return dataRow != null;
        }
        #endregion
    }
}
