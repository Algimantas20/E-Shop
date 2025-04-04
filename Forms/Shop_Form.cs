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
        public Shop_Form()
        {
            InitializeComponent();

            new A_Form(this).Apply(shop_Panel, side_Panel);
            this.addProducts_Button.Click += (s, e) => A_Button.OpenForm<AddProducts_Form>(this);
            this.exitButton.Click += (s, e) => A_Button.ExitApplication(this);

            if (User.Privilege != "Admin")
                addProducts_Button.Visible = false;
        }
        #region -> Private Methods
        private void Shop_Form_Load(object sender, EventArgs e)
        {
            this.productsTableAdapter.Fill(this.e_Shop_DatabaseDataSet.Products);
            GenerateItemWindows();
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

        private void GenerateItemWindows()
        {
            List<Product> products = GetProducts();

            int x = 10, y = 10;
            int itemWidth = 250;
            int itemHeight = 300;
            int spacing = 10;
            int itemsPerRow = (shop_Panel.Width - spacing) / (itemWidth + spacing);
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
                x += itemWidth + spacing;
                if (count >= itemsPerRow)
                {
                    count = 0;
                    x = 10;
                    y += itemHeight + spacing;
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
                    if (row.Field<int>("Id") > 0)
                    {
                        var product = FormAProduct(row);
                        formattedProducts.Add(product);
                    }
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
