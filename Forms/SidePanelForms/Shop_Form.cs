using E_Shop.Classes;
using E_Shop.Components;

using System;
using System.IO;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using E_Shop.Forms.SidePanelForms;

using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace E_Shop.Forms
{
    public partial class Shop_Form : Form
    {
        #region -> Variables

        private const int _itemWidth = 250;
        private const int _itemHeight = 300;
        private const int _itemSpacing = 10;

        #endregion

        public Shop_Form()
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

        private async void Shop_Form_Load(object sender, EventArgs e)
        {
            this.productsTableAdapter.Fill(this.e_Shop_DatabaseDataSet.Products);
            await GenerateItemWindowsAsync();
        }

        #endregion

        #region -> Private Methods

        private void SubscribeMethods()
        {
            new A_Form(form: this).Apply(panels: new Panel[] { shop_Panel, side_Panel });
            this.FormClosing += (sender, eventArgs) => A_Panel.ClearPanel(panel: shop_Panel);

            this.addProducts_Button.Click += (sender, eventArgs) => A_Button.OpenForm<AddProducts_Form>(currentForm: this);
            this.viewCart_Button.Click += (sender, eventArgs) => A_Button.OpenForm<ViewCart_Form>(currentForm: this);
            this.userPrivilige_Button.Click += (sender, eventArgs) => A_Button.OpenForm<UserPriviliges_Form>(currentForm: this);
            this.exitButton.Click += async (sender, eventArgs) => await A_Button.ExitApplication(form: this);
            this.orderDB_Button.Click += (sender, eventArgs) => A_Button.OpenForm<OrderDatabase_Form>(currentForm: this);
            this.signOut_Button.Click += (sender, eventArgs) =>
            {
                Session.SignOut();
                A_Button.OpenForm<SignIn_Form>(currentForm: this);
            };

        }

        private async Task GenerateItemWindowsAsync()
        {
            List<Product> products = await Task.Run(GetProducts);

            if (products == null || products.Count == 0)
            { 
                return;
            }

            shop_Panel.SuspendLayout();
            shop_Panel.Controls.Clear();

            int itemsPerRow = Math.Max(val1: 1, val2: (shop_Panel.Width - _itemSpacing) / (_itemWidth + _itemSpacing));

            IEnumerable<A_ItemWindow> itemWindows = GenerateItemWindows(products, itemsPerRow);

            itemWindows.ToList()
                .ForEach(item => shop_Panel.Controls.Add(item));

            shop_Panel.ResumeLayout();
            shop_Panel.Refresh();
        }

        private IEnumerable<A_ItemWindow> GenerateItemWindows(List<Product> products, int itemsPerRow)
        {
            return products.Select((product, index) =>
                new A_ItemWindow(product: product, parentForm: this)
                {
                    Location = new Point(
                        x: 10 + (index % itemsPerRow) * (_itemWidth + _itemSpacing),
                        y: 10 + (index / itemsPerRow) * (_itemHeight + _itemSpacing)
                    )
                });
        }

        #endregion

        #region -> Data Fetching

        private List<Product> GetProducts()
        {
            List<Product> formattedProducts = new List<Product>();

            try
            {
                DataTable table = this.e_Shop_DatabaseDataSet.Products;

                if (table == null || table.Rows.Count == 0)
                    return formattedProducts;

                foreach (DataRow row in table.Rows)
                {
                    Product product = FormAProduct(row);
                    formattedProducts.Add(product);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error fetching products: {ex.Message}");
            }

            return formattedProducts;
        }

        #endregion

        #region -> Data Formatting

        private Product FormAProduct(DataRow product)
        {
            try
            {
                return new Product(
                    Id: int.Parse(product["Id"].ToString()),
                    title: product["Product_Name"].ToString(),
                    description: product["Product_Description"].ToString(),
                    price: float.Parse(product["Product_Price"].ToString()),
                    image: BinaryToImage(product["Product_Image"] as byte[])
                );
            }
            catch (Exception ex)
            {
                throw new Exception($"Error forming product: {ex.Message}");
            }
        }

        public static Image BinaryToImage(byte[] binaryData)
        {
            if (binaryData == null || binaryData.Length == 0)
            {
                Debug.WriteLine("Binary data is empty or null.");
                return null;
            }

            try
            {
                using (MemoryStream memStream = new MemoryStream(binaryData))
                {
                    Image img = Image.FromStream(memStream, useEmbeddedColorManagement: false, validateImageData: true);
                    return img;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(message: $"Error converting binary data to image: {ex.Message}");
                return null;
            }
        }

        #endregion
    }
}
