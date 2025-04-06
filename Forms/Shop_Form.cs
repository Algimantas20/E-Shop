using E_Shop.Classes;
using E_Shop.Components;

using System;
using System.IO;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace E_Shop.Forms
{
    public partial class Shop_Form : Form
    {
        #region -> Variables
        private readonly int _itemWidth = 250;
        private readonly int _itemHeight = 300;
        private readonly int _itemSpacing = 10;
        #endregion

        public Shop_Form()
        {
            InitializeComponent();

            new A_Form(this).Apply(shop_Panel, side_Panel);
            this.addProducts_Button.Click += (s, e) => A_Button.OpenForm<AddProducts_Form>(this);
            this.viewCart_Button.Click += (s, e) => A_Button.OpenForm<ViewCart_Form>(this);
            this.exitButton.Click += async (s, e) => await A_Button.ExitApplication(this);

            this.FormClosing += (s, e) => A_Panel.ClearPanel(shop_Panel);


            if (User.Privilege != "Admin")
                addProducts_Button.Visible = false;
        }
        #region -> Private Methods

        private async void Shop_Form_Load(object sender, EventArgs e)
        {
            this.productsTableAdapter.Fill(this.e_Shop_DatabaseDataSet.Products);
            await GenerateItemWindowsAsync();
        }
        private async void SignOut_Button_Click(object sender, EventArgs e)
        {
            User.SignOut();
            SignIn_Form form = new SignIn_Form()
            {
                StartPosition = FormStartPosition.Manual,
                Location = this.Location
            };
            form.Show();
            await Task.Delay(2);
            this.Hide();
        }
        private async Task GenerateItemWindowsAsync()
        {
            var products = await Task.Run(() => GetProducts());

            int itemsPerRow = (shop_Panel.Width - _itemSpacing) / (_itemWidth + _itemSpacing);
            int x = 10, y = 10;
            int count = 0;

            shop_Panel.Controls.Clear();

            foreach (var product in products)
            {
                var itemWindow = new A_ItemWindow(product, this)
                {
                    Location = new Point(x, y)
                };

                shop_Panel.Controls.Add(itemWindow);

                count++;
                x += _itemWidth + _itemSpacing;
                if (count >= itemsPerRow)
                {
                    count = 0;
                    x = 10;
                    y += _itemHeight + _itemSpacing;
                }
            }

            shop_Panel.PerformLayout();
            shop_Panel.Refresh();
        }

        #endregion

        #region -> Data Fetching

        private List<Product> GetProducts()
        {
            var formattedProducts = new List<Product>();

            try
            {
                var table = this.e_Shop_DatabaseDataSet.Products;

                if (table == null || table.Rows.Count == 0)
                    return formattedProducts;

                foreach (DataRow row in table.Rows)
                {
                    if (row.Field<int>("Id") <= 0)
                    {
                        return new List<Product>();
                    }   

                    var product = FormAProduct(row);
                    formattedProducts.Add(product);
                    
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error fetching products: {ex.Message}");
                throw new Exception("Error fetching products", ex);
            }

            return formattedProducts;
        }

        #endregion

        #region -> Data Formatting
        private Product FormAProduct(DataRow product)
        {
            try
            {
                return new Product
                (
                    title: product["Product_Name"].ToString(),
                    description: product["Product_Description"].ToString(),
                    price: float.Parse(product["Product_Price"].ToString()),
                    image: BinaryToImage(product["Product_Image"] as Byte[])
                );
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error forming product: {ex.Message}");
                throw ex;
            }
        }

        public static Image BinaryToImage(Byte[] binaryData)
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
                Debug.WriteLine($"Error converting binary data to image: {ex.Message}");
                return null;
            }
        }
        #endregion

    }
}
