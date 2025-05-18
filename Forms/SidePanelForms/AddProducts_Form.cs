using E_Shop.Classes;
using E_Shop.Components;
using E_Shop.Forms.Sub_Forms;
using static E_Shop.Database.E_Shop_DatabaseDataSet;

using System;
using System.IO;
using System.Windows.Forms;
using E_Shop.Forms.SidePanelForms;

namespace E_Shop.Forms
{
    public partial class AddProducts_Form : Form
    {
        private byte[] _binaryImage;
        private string _filePath;

        public AddProducts_Form()
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

        private void Shop_Form_Load(object sender, EventArgs e)
        {
            this.productsTableAdapter.Fill(this.e_Shop_DatabaseDataSet.Products);
        }

        private async void Picture_Button_Click(object sender, EventArgs e)
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
                    picture_Button.Text = Path.GetFileName(path: dialog.FileName);
                    ConvertImageToBinary(_filePath, ref _binaryImage);
                }
            }
            catch (Exception ex)
            {
                await MessageHelper.Print(ex.Message, label: output_Label, type: MessageType.Error);
            }
        }

        private async void Upload_Button_Click(object sender, EventArgs e)
        {
            var (strProductName, strProductDescription, strProductPrice) = GetProductData();

            bool isValidPrice = float.TryParse(strProductPrice, out float productPrice);
            if (!isValidPrice)
            {
                await MessageHelper.Print("Invalid Price", label: output_Label, type: MessageType.Error);
                return;
            }

            try
            {
                ProductsRow newProductRow = GenerateNewRow(strProductName, strProductDescription, productPrice);

                this.e_Shop_DatabaseDataSet.Products.Rows.Add(newProductRow);
                this.productsTableAdapter.Update(e_Shop_DatabaseDataSet.Products);

                this.e_Shop_DatabaseDataSet.AcceptChanges();

                await MessageHelper.Print("Product uploaded successfully!", label: output_Label, type: MessageType.Success);
            }
            catch
            {
                await MessageHelper.Print("An error occured while uploading the product", label: output_Label, type: MessageType.Error);
                e_Shop_DatabaseDataSet.RejectChanges();
                return;
            }
            finally
            {
                RefreshThePage();
            }
        }

        private void Preview_Button_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(_filePath))
                {
                    return;
                }

                using (PicturePreview_Form form = new PicturePreview_Form(_filePath))
                {
                    form.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening the preview form: " + ex.Message);
                return;
            }
        }


        #endregion

        #region -> Private Methods

        private (string Name, string Description, string Price) GetProductData()
        {
            return (Name: productName_TextBox.Texts, Description: description_TextBox.Texts, Price: price_TextBox.Texts);
        }

        private void ConvertImageToBinary(string filePath, ref byte[] binaryImage)
        {
            if (string.IsNullOrEmpty(filePath))
                throw new ArgumentException("File path cannot be null or empty.", paramName: nameof(filePath));

            binaryImage = File.ReadAllBytes(filePath);
        }

        private void SubscribeMethods()
        {
            new A_Form(form: this).Apply(panels: new Panel[] { addProduct_Panel, side_Panel });
            this.FormClosing += (sender, eventArgs) => A_Panel.ClearPanel(panel: addProduct_Panel);

            this.shop_Button.Click += (sender, v) => A_Button.OpenForm<Shop_Form>(currentForm: this);
            this.viewCart_Button.Click += (sender, eventArgs) => A_Button.OpenForm<ViewCart_Form>(currentForm: this);
            this.orderDB_Button.Click += (sender, eventArgs) => A_Button.OpenForm<OrderDatabase_Form>(currentForm: this);
            this.userPrivilige_Button.Click += (sender, eventArgs) => A_Button.OpenForm<UserPriviliges_Form>(currentForm: this);
            this.exitButton.Click += async (sender, eventArgs) => await A_Button.ExitApplication(form: this);
            this.signOut_Button.Click += (sender, eventArgs) =>
            {
                Session.SignOut();
                A_Button.OpenForm<SignIn_Form>(currentForm: this);
            };
        }

        private void RefreshThePage()
        {
            productName_TextBox.Texts = null;
            description_TextBox.Texts = null;
            price_TextBox.Texts = null;
            picture_Button.Text = "File";
            _filePath = null;
            _binaryImage = null;
        }

        private ProductsRow GenerateNewRow(string Name, string Description, float Price)
        {
            ProductsRow newProductRow = e_Shop_DatabaseDataSet.Products.NewProductsRow();

            newProductRow.Product_Name = Name;
            newProductRow.Product_Description = Description;
            newProductRow.Product_Price = Price;
            newProductRow.Product_Image = _binaryImage;
            newProductRow.EndEdit();

            return newProductRow;
        }

        #endregion
    }
}
