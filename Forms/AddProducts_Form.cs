﻿using E_Shop.Classes;
using E_Shop.Components;
using E_Shop.Database;
using E_Shop.Forms.Sub_Forms;

using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Shop.Forms
{
    public partial class AddProducts_Form : Form
    {
        private byte[] _binaryImage;
        private string _filePath;
        public AddProducts_Form()
        {
            InitializeComponent();

            new A_Form(this).Apply(addProduct_Panel, side_Panel);
            this.shop_Button.Click += (s, e) => A_Button.OpenForm<Shop_Form>(this);
            this.exitButton.Click += async (s, e) => await A_Button.ExitApplication(this);
        }

        #region -> Private Methods
        private void Shop_Form_Load(object sender, EventArgs e)
        {
            this.productsTableAdapter.Fill(this.e_Shop_DatabaseDataSet.Products);
        }
        private void ConverImageToBinary(string filePath, ref byte[] binaryImage)
        {
            binaryImage = File.ReadAllBytes(filePath);
        }
        #endregion

        private void Picture_Button_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog
                {
                    Filter = "Image Files|*.jpg;*.jpeg;*.png;",
                    Title = "Select an Image",
                    Multiselect = false
                };

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    _filePath = dialog.FileName;
                    picture_Button.Text = Path.GetFileName(dialog.FileName);
                    ConverImageToBinary(_filePath, ref _binaryImage);
                }
            }
            catch (Exception ex)
            {
                MessageHelper.PrintOutMessage(ex.Message, error_Label, MessageType.Error);
            }
        }
        private void Upload_Button_Click(object sender, EventArgs e)
        {
            string productName = productName_TextBox.Texts;
            string productDescription = description_TextBox.Texts;

            string productPrice = price_TextBox.Texts;
            bool isValidPrice = float.TryParse(productPrice, out float price);
            if (!isValidPrice)
            {
                MessageHelper.PrintOutMessage("Invalid Price", error_Label, MessageType.Error);
                return;
            }

            try
            {
                E_Shop_DatabaseDataSet.ProductsRow newProductRow;
                newProductRow = e_Shop_DatabaseDataSet.Products.NewProductsRow();

                newProductRow.Product_Name = productName;
                newProductRow.Product_Description = productDescription;
                newProductRow.Product_Price = price;
                newProductRow.Product_Image = _binaryImage;

                this.e_Shop_DatabaseDataSet.Products.Rows.Add(newProductRow);
                newProductRow.EndEdit();
                int rowsAffected = this.productsTableAdapter.Update(e_Shop_DatabaseDataSet.Products);

                this.e_Shop_DatabaseDataSet.AcceptChanges();

                MessageHelper.PrintOutMessage("Product uploaded successfully!", error_Label, MessageType.Success);
            }
            catch
            {
                MessageHelper.PrintOutMessage("An error occured while uploading the product", error_Label, MessageType.Error);
                e_Shop_DatabaseDataSet.RejectChanges();
                return;
            }
            finally
            {
               productName_TextBox.Texts = null;
               description_TextBox.Texts = null;
               price_TextBox.Texts = null;
               picture_Button.Text = "File";

               _binaryImage = null;
            }
        }

        private void Preview_Button_Click(object sender, EventArgs e)
        {
            try
            {
                PicturePreview_Form form = new PicturePreview_Form(_filePath);
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening the preview form: " + ex.Message);
            }
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

