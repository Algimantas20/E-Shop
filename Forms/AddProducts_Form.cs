using E_Shop.Classes;
using E_Shop.Components;
using E_Shop.Forms.Sub_Forms;
using static E_Shop.Database.E_Shop_DatabaseDataSet;

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
            SubscribeMethods();
        }

        #region -> Event Handlers

        private void Shop_Form_Load(object sender, EventArgs e)
        {
            this.productsTableAdapter.Fill(dataTable: this.e_Shop_DatabaseDataSet.Products);
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
                    ConvertImageToBinary(filePath: _filePath, binaryImage: ref _binaryImage);
                }
            }
            catch (Exception ex)
            {
                await MessageHelper.Print(message: ex.Message, label: error_Label, type: MessageType.Error);
            }
        }

        private async void Upload_Button_Click(object sender, EventArgs e)
        {
            var (strProductName, strProductDescription, strProductPrice) = GetProductData();

            bool isValidPrice = float.TryParse(s: strProductPrice, result: out float productPrice);

            if (!isValidPrice)
            {
                await MessageHelper.Print(message: "Invalid Price", label: error_Label, type: MessageType.Error);
                return;
            }

            try
            {
                ProductsRow newProductRow = GenerateNewRow(Name: strProductName, Description: strProductDescription, Price: productPrice);

                this.e_Shop_DatabaseDataSet.Products.Rows.Add(row: newProductRow);
                this.productsTableAdapter.Update(dataTable: e_Shop_DatabaseDataSet.Products);

                this.e_Shop_DatabaseDataSet.AcceptChanges();

                await MessageHelper.Print(message: "Product uploaded successfully!", label: error_Label, type: MessageType.Success);
            }
            catch
            {
                await MessageHelper.Print(message: "An error occured while uploading the product", label: error_Label, type: MessageType.Error);
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
                using (PicturePreview_Form form = new PicturePreview_Form(filePath: _filePath))
                {
                    form.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(text: "Error opening the preview form: " + ex.Message);
                return;
            }
        }

        private async void SignOut_Button_Click(object sender, EventArgs e)
        {
            User.SignOut();
            SignIn_Form form = new SignIn_Form
            {
                StartPosition = FormStartPosition.Manual,
                Location = this.Location
            };
            form.Show();
            await Task.Delay(millisecondsDelay: 2);
            this.Hide();
        }

        #endregion

        #region -> Private Methods

        private (string Name, string Description, string Price) GetProductData()
        {
            return (Name: productName_TextBox.Texts, Description: description_TextBox.Texts, Price: price_TextBox.Texts);
        }

        private void ConvertImageToBinary(string filePath, ref byte[] binaryImage)
        {
            if (string.IsNullOrEmpty(value: filePath))
                throw new ArgumentException(message: "File path cannot be null or empty.", paramName: nameof(filePath));

            binaryImage = File.ReadAllBytes(path: filePath);
        }

        private void SubscribeMethods()
        {
            new A_Form(form: this).Apply(panels: new Panel[] { addProduct_Panel, side_Panel });
            this.shop_Button.Click += (sender, e) => A_Button.OpenForm<Shop_Form>(currentForm: this);
            this.viewCart_Button.Click += (sender, e) => A_Button.OpenForm<ViewCart_Form>(currentForm: this);
            this.exitButton.Click += async (sender, e) => await A_Button.ExitApplication(form: this);

            //this.FormClosing += (sender, e) => A_Panel.ClearPanel(panel: addProduct_Panel);
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
