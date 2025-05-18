using E_Shop.Classes;
using E_Shop.Components;

using System;
using System.IO;
using System.Linq;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Collections.Generic;
using E_Shop.Forms.SidePanelForms;

namespace E_Shop.Forms
{
    public partial class ViewCart_Form : Form
    {
        #region -> Variables
        private const int _itemWidth = 250;
        private const int _itemHeight = 300;
        private const int _itemSpacing = 10;
        #endregion

        public ViewCart_Form()
        {
            InitializeComponent();
            SubscribeMethods();

            if (Session.User.Privilege != "Admin")
            {
                userPrivilige_Button.Visible = false;
                orderDB_Button.Visible = false;
            }
        }

        #region -> Event Handlers

        private async void ViewCart_Form_Load(object sender, EventArgs e)
        {
            this.productsTableAdapter.Fill(this.e_Shop_DatabaseDataSet.Products);
            this.cartTableAdapter.Fill(this.e_Shop_DatabaseDataSet.Cart);
            await GenerateItemWindowsAsync();
        }

        #endregion

        #region -> Private Methods

        private void SubscribeMethods()
        {
            new A_Form(form: this).Apply(panels: new Panel[] { viewCart_Panel, side_Panel });
            this.FormClosing += (sender, eventArgs) => A_Panel.ClearPanel(panel: viewCart_Panel);

            this.shop_Button.Click += (sender, eventArgs) => A_Button.OpenForm<Shop_Form>(currentForm: this);
            this.addProducts_Button.Click += (sender, eventArgs) => A_Button.OpenForm<AddProducts_Form>(currentForm: this);
            this.userPrivilige_Button.Click += (sender, eventArgs) => A_Button.OpenForm<UserPriviliges_Form>(currentForm: this);
            this.orderDB_Button.Click += (sender, eventArgs) => A_Button.OpenForm<OrderDatabase_Form>(currentForm: this);
            this.exitButton.Click += async (sender, eventArgs) => await A_Button.ExitApplication(form: this);
            this.signOut_Button.Click += (sender, eventArgs) =>
            {
                Session.SignOut();
                A_Button.OpenForm<SignIn_Form>(currentForm: this);
            };
        }

        private async Task GenerateItemWindowsAsync()
        {
            var products = await Task.Run(GetCart);

            if (products == null || products.Count == 0)
            {
                return;
            }

            viewCart_Panel.SuspendLayout();
            viewCart_Panel.Controls.Clear();

            int itemsPerRow = Math.Max(1, (viewCart_Panel.Width - _itemSpacing) / (_itemWidth + _itemSpacing));

            var itemWindows = GenerateItemWindows(products, itemsPerRow);

            itemWindows.ToList()
                       .ForEach(item => viewCart_Panel.Controls.Add(value: item));

            viewCart_Panel.ResumeLayout();
            viewCart_Panel.Refresh();
        }

        private Image BinaryToImage(Byte[] binaryData)
        {
            if (binaryData == null || binaryData.Length == 0)
            {
                return null;
            }

            try
            {
                using (MemoryStream memStream = new MemoryStream(buffer: binaryData))
                {
                    Image img = Image.FromStream(memStream, useEmbeddedColorManagement: false, validateImageData: true);
                    return img;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error converting binary data to image: {ex.Message}");
                return null;
            }
        }

        private int GetAmount(Product product)
        {
            DataRow[] rows = this.e_Shop_DatabaseDataSet.Cart
                .Select($"User_Id = '{Session.User.Id}' AND Product_Id = '{product.ID}'");

            if (rows.Length <= 0)
            {
                throw new Exception("Product not found in cart");
            }

            return int.Parse(rows[0]["Amount"].ToString());
        }

        private List<Product> GetCart()
        {
            DataRow[] cartItems = e_Shop_DatabaseDataSet.Cart.Select($"User_Id = '{Session.User.Id}'");

            if (cartItems.Length <= 0)
            {
                return new List<Product>();
            }

            List<int> IdArray = GetProductIds(cartItems);

            if (!IdArray.Any())
            {
                return new List<Product>();
            }

            DataRow[] products = e_Shop_DatabaseDataSet.Products.Select($"Id in ({string.Join(separator: ",", values: IdArray)})");
            return FormProducts(products);
        }

        private List<int> GetProductIds(DataRow[] cartItems)
        {
            List<int> idArray = new List<int>();

            foreach (DataRow cartItem in cartItems)
            {
                if (int.TryParse(cartItem["Product_Id"].ToString(), out int id))
                {
                    idArray.Add(id);
                }
            }

            return idArray;
        }

        private List<Product> FormProducts(DataRow[] productRows)
        {
            var products = new List<Product>();

            foreach (DataRow productRow in productRows)
            {
                products.Add(item: new Product(
                    Id: int.Parse(productRow["Id"].ToString()),
                    title: productRow["Product_Name"].ToString(),
                    description: productRow["Product_Description"].ToString(),
                    price: float.Parse(productRow["Product_Price"].ToString()),
                    image: BinaryToImage(binaryData: productRow["Product_Image"] as Byte[])
                ));
            }

            return products;
        }

        private IEnumerable<A_ItemWindow> GenerateItemWindows(List<Product> products, int itemsPerRow)
        {
            return products
                .Where(product => GetAmount(product) > 0)
                .Select(selector: (product, index) =>
                {
                    return new A_ItemWindow
                    (
                        product: product,
                        parentForm: this,
                        amount: GetAmount(product),
                        isCart: true
                    )
                    {
                        Location = new Point(
                            x: 10 + (index % itemsPerRow) * (_itemWidth + _itemSpacing),
                            y: 10 + (index / itemsPerRow) * (_itemHeight + _itemSpacing)
                        )
                    };
                });
        }

        #endregion
    }
}
