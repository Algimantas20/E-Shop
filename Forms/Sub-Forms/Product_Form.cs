using E_Shop.Classes;
using E_Shop.Components;
using static E_Shop.Database.E_Shop_DatabaseDataSet;

using System;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Shop.Forms.Sub_Forms
{
    public partial class Product_Form : Form
    {

        #region -> Variables

        private readonly Product _product;
        private int _amount;

        #endregion

        public Product_Form(Product product, int amount, Form parentForm)
        {
            _product = product;
            _amount = amount;

            InitializeComponent();
            SubscirbeMethods();
            UpdateGUI(parentForm);
        }
        #region -> Event Handlers

        private void Product_Form_Load(object sender, EventArgs e)
        {
            this.ordersTableAdapter.Fill(this.e_Shop_DatabaseDataSet.Orders);
            this.cartTableAdapter.Fill(this.e_Shop_DatabaseDataSet.Cart);
        }

        private async void AddToCart_Button_Click(object sender, EventArgs e)
        {
            DataRow product = GetProduct();

            bool isInCart = CheckIfItemIsInCart(product);
            if (isInCart)
            {
                await ChangeProductAmount(product, type: Operations.Add);
                return;
            }

            AddProductToCart();      
        }

        private async void RemoveFromCart_Button_Click(object sender, EventArgs e)
        {
            if (_amount <= 0)
                return;

            var product = GetProduct();
            await ChangeProductAmount(product, type: Operations.Remove);   
        }

        private async void Purchase_Button_Click(object sender, EventArgs e)
        {
            var product = GetProduct();
            var orderAmount = _amount;

            if (_amount > 0)
            {
                await ChangeProductAmount(product, type: Operations.Buy);
            }

            AppendOrder(_product, orderAmount);
            await MessageHelper.Print("Product successfully purchased.", label: output_Label, type: MessageType.Success);
        }
        #endregion

        #region -> Private Methods

        private void SubscirbeMethods()
        {
            new A_Form(form: this).Apply(panels: new Panel[] { picture_Panel, title_Panel, description_Panel, cart_Amount_Panel, cart_Price_panel, shop_Price_Panel });

            this.back_Button.Click += (sender, e) => A_Button.OpenForm<Shop_Form>(currentForm: this);
            this.exitButton.Click += async(sender, e) => await A_Button.ExitApplication(form: this);
            this.purchase_Button.ActionTriggered += (sender, e) => Purchase_Button_Click(sender, e);
        }

        private async void AppendOrder(Product product, int amount = 1)
        {
            try
            {
                OrdersRow newOrderRow = GenerateOrdersRow(product, amount);

                this.e_Shop_DatabaseDataSet.Orders.Rows.Add(newOrderRow);
                newOrderRow.EndEdit();

                this.ordersTableAdapter.Update(e_Shop_DatabaseDataSet.Orders);
                this.e_Shop_DatabaseDataSet.AcceptChanges();
            }
            catch (Exception ex)
            {
                e_Shop_DatabaseDataSet.RejectChanges();
                await MessageHelper.Print(ex.Message, label: output_Label, type: MessageType.Error);
            }
        }

        private void UpdateGUI(Form form)
        {
            title_Label.Text = _product.Title;
            description_Label.Text = _product.Description;
            image_PictureBox.Image = _product.Image;

            if(form is Shop_Form)
            {
                UpdateGUIShop_Form();
            }
            else if (form is ViewCart_Form)
            {
                UpdateGUIViewCart_Form();
            }
        }

        private void UpdateGUI(int amount)
        {
            cart_Amount_Label.Text = $"Amount: {_amount}";
            cart_Price_Label.Text = $"Price: {_product.Price}; Total Price: {_product.Price * _amount}$";
        }

        private void UpdateGUIShop_Form()
        {
            shop_Price_Panel.Visible = true;
            shop_Price_Label.Text = $"Price: {_product.Price}$";
        }

        private void UpdateGUIViewCart_Form()
        {
            cart_Price_panel.Visible = true;
            cart_Amount_Panel.Visible = true;

            if (_amount > 0)
            {
                removeFromCart_Button.Visible = true;
            }

            cart_Amount_Label.Text = $"Amount: {_amount}";
            cart_Price_Label.Text = $"Price: {_product.Price}; Total Price: {_product.Price * _amount}$";
        }

        private async void AddProductToCart()
        {
            try
            {
                CartRow newCartRow = GenerateNewRow();

                this.e_Shop_DatabaseDataSet.Cart.Rows.Add(newCartRow);

                this.cartTableAdapter.Update(e_Shop_DatabaseDataSet.Cart);
                this.e_Shop_DatabaseDataSet.AcceptChanges();

                await MessageHelper.Print("Product successfully added to cart.", label: output_Label, type: MessageType.Success);
            }
            catch (Exception ex)
            {
                e_Shop_DatabaseDataSet.RejectChanges();
                await MessageHelper.Print(ex.Message, label: output_Label, type: MessageType.Error);
            }
        }

        private DataRow GetProduct()
        {
            return e_Shop_DatabaseDataSet.Cart.Select($"User_Id = '{Session.User.Id}' AND Product_Id = '{_product.ID}'").FirstOrDefault();
        }

        private CartRow GenerateNewRow()
        {
            CartRow newCartRow = e_Shop_DatabaseDataSet.Cart.NewCartRow();

            newCartRow.User_Id = Session.User.Id;
            newCartRow.Product_Id = _product.ID;
            newCartRow.Amount = 1;

            newCartRow.EndEdit();

            return newCartRow;
        }

        private OrdersRow GenerateOrdersRow(Product product, int amount)
        {
            if(amount == 0)
            {
                amount = 1;
            }

            OrdersRow newOrderRow = e_Shop_DatabaseDataSet.Orders.NewOrdersRow();

            newOrderRow.User_Id = Session.User.Id;
            newOrderRow.Product_Id = product.ID;
            newOrderRow.Order_Date = DateTime.Now;
            newOrderRow.Order_Amount = amount;

            return newOrderRow;
        }

        private async Task ChangeProductAmount(DataRow row, Operations type)
        {
            string outputText;
            try
            {
                row.BeginEdit();

                switch (type)
                {
                    case Operations.Add:
                        row["Amount"] = int.Parse(row["Amount"].ToString()) + 1;
                        _amount += 1;
                        outputText = "Product successfully added to cart.";
                        break;
                    case Operations.Remove:
                        row["Amount"] = int.Parse(row["Amount"].ToString()) - 1;
                        _amount -= 1;
                        outputText = "Product successfully removed from cart.";
                        break;
                    case Operations.Buy:
                        row["Amount"] = 0;
                        _amount = 0;
                        outputText = "";
                        break;
                    default:
                        throw new Exception("Invalid operation.");
                }

                row.EndEdit();

                this.cartTableAdapter.Update(e_Shop_DatabaseDataSet.Cart);
                this.e_Shop_DatabaseDataSet.AcceptChanges();
  
                await MessageHelper.Print(outputText, output_Label, MessageType.Success);

                UpdateGUI(_amount);
            }
            catch (Exception ex)
            {
                e_Shop_DatabaseDataSet.RejectChanges();
                await MessageHelper.Print(ex.Message, label: output_Label, type: MessageType.Error);
            }
        }

        private bool CheckIfItemIsInCart(DataRow dataRow)
        {
            return dataRow != null;
        }

        #endregion

        private enum Operations
        {
            Add,
            Remove,
            Buy
        }

    }
}
