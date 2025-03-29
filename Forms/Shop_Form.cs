using E_Shop.Classes;
using E_Shop.Components;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Shop.Forms
{
    public partial class Shop_Form : Form
    {
        public Shop_Form()
        {
            InitializeComponent();
            new A_Form(this).Apply(shop_Panel, side_Panel);
            if(User.Privilege != "Admin")
                addProducts_Button.Visible = false;
        }

        private void Shop_Form_Load(object sender, EventArgs e)
        {
            this.productsTableAdapter.Fill(this.e_Shop_DatabaseDataSet.Products);
            GenerateItemWindows();
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

        private List<Product> GetProducts()
        {
            try
            {
                if (this.e_Shop_DatabaseDataSet.Products.Rows.Count == 0)
                {
                    throw new Exception("The dataset is empty.");
                }

                DataRow[] products = this.e_Shop_DatabaseDataSet.Products.Select("Id > 0");
                var formattedProducts = new List<Product>();

                foreach (var row in products)
                {
                    var product = FormAProduct(row);
                    formattedProducts.Add(product);
                }

                return formattedProducts;
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error fetching products: {ex.Message}");
                return new List<Product>();
            }
        }


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



        private async void AddProducts_Button_Click(object sender, EventArgs e)
        {
            AddProducts_Form form = new AddProducts_Form
            {
                StartPosition = FormStartPosition.Manual,
                Location = Location
            };
            form.Show();
            form.BringToFront();
            await Task.Delay(3);
            this.Close();
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
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
    }
}
