﻿using E_Shop.Classes;
using E_Shop.Components;

using System.Windows.Forms;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System;
using System.Diagnostics;
using System.IO;
using System.Drawing;
using System.Threading.Tasks;

namespace E_Shop.Forms
{
    public partial class ViewCart_Form : Form
    {
        #region -> Variebles
        private const int _itemWidth = 250;
        private const int _itemHeight = 300;
        private const int _itemSpacing = 10;
        #endregion
        
        public ViewCart_Form()
        {
            InitializeComponent();

            this.shop_Button.Click += (s, e) => A_Button.OpenForm<Shop_Form>(this);
            this.addProducts_Button.Click += (s, e) => A_Button.OpenForm<AddProducts_Form>(this);
            this.exitButton.Click += async (s, e) => await A_Button.ExitApplication(this);

            this.FormClosing += (s, e) => A_Panel.ClearPanel(viewCart_Panel);
        }
        #region -> Private Methods
        private async void ViewCart_Form_Load(object sender, System.EventArgs e)
        {
            this.productsTableAdapter.Fill(this.e_Shop_DatabaseDataSet.Products);
            this.cartTableAdapter.Fill(this.e_Shop_DatabaseDataSet.Cart);
            await GenerateItemWindowsAsync();
        }

        private List<Product> GetCart()
        {
            List<int> IdArray = new List<int>();
            DataRow[] cartItems = e_Shop_DatabaseDataSet.Cart.Select($"User_Id = '{User.Id}'");

            if(cartItems.Length <= 0) {
                Debug.WriteLine("Empty Cart"); 
                return new List<Product>(); 
            }

            foreach (DataRow cartItem in cartItems)
            {
                IdArray.Add(int.Parse(cartItem["Product_Id"].ToString()));
            }
            DataRow[] products = e_Shop_DatabaseDataSet.Products.Select($"Id in ({string.Join(",", IdArray)})");
            return FormProducts(products);
        }
        private List<Product> FormProducts(DataRow[] productRows)
        {
            var products = new List<Product>();
            foreach(DataRow productRow in productRows)
            {
                products.Add(new Product(
                    Id: int.Parse(productRow["Id"].ToString()),
                    title: productRow["Product_Name"].ToString(),
                    description: productRow["Product_Description"].ToString(),
                    price: float.Parse(productRow["Product_Price"].ToString()),
                    image: BinaryToImage(productRow["Product_Image"] as Byte[])
                ));
            }
            return products;
        }
        private Image BinaryToImage(Byte[] binaryData)
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
        private async Task GenerateItemWindowsAsync()
        {
            var products = await Task.Run(() => GetCart());

            int itemsPerRow = (viewCart_Panel.Width - _itemSpacing) / (_itemWidth + _itemSpacing);
            int x = 10, y = 10;
            int count = 0;

            viewCart_Panel.Controls.Clear();

            foreach (var product in products)
            {
                var itemWindow = new A_ItemWindow(product, this)
                {
                    Location = new Point(x, y)
                };

                viewCart_Panel.Controls.Add(itemWindow);

                count++;
                x += _itemWidth + _itemSpacing;
                if (count >= itemsPerRow)
                {
                    count = 0;
                    x = 10;
                    y += _itemHeight + _itemSpacing;
                }
            }

            viewCart_Panel.PerformLayout();
            viewCart_Panel.Refresh();
        }

        #endregion
    }
}
