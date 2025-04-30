namespace E_Shop.Forms
{
    partial class AddProducts_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProducts_Form));
            this.e_Shop_DatabaseDataSet = new E_Shop.Database.E_Shop_DatabaseDataSet();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter = new E_Shop.Database.E_Shop_DatabaseDataSetTableAdapters.ProductsTableAdapter();
            this.tableAdapterManager = new E_Shop.Database.E_Shop_DatabaseDataSetTableAdapters.TableAdapterManager();
            this.exitButton = new System.Windows.Forms.Label();
            this.addProduct_Panel = new E_Shop.Components.A_Panel();
            this.a_PreviewButton1 = new E_Shop.Components.A_PreviewButton();
            this.picture_Button = new E_Shop.Components.A_Button();
            this.label1 = new System.Windows.Forms.Label();
            this.price_TextBox = new E_Shop.Components.A_TexBox();
            this.description_TextBox = new E_Shop.Components.A_TexBox();
            this.error_Label = new System.Windows.Forms.Label();
            this.upload_Button = new E_Shop.Components.A_Button();
            this.signUp_Label = new System.Windows.Forms.Label();
            this.productName_TextBox = new E_Shop.Components.A_TexBox();
            this.side_Panel = new System.Windows.Forms.Panel();
            this.addProducts_Button = new E_Shop.Components.A_SidePanelButton();
            this.viewCart_Button = new E_Shop.Components.A_SidePanelButton();
            this.shop_Button = new E_Shop.Components.A_SidePanelButton();
            this.signOut_Button = new E_Shop.Components.A_Button();
            this.manageUserPrivilige_Button = new E_Shop.Components.A_SidePanelButton();
            ((System.ComponentModel.ISupportInitialize)(this.e_Shop_DatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            this.addProduct_Panel.SuspendLayout();
            this.side_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // e_Shop_DatabaseDataSet
            // 
            this.e_Shop_DatabaseDataSet.DataSetName = "E_Shop_DatabaseDataSet";
            this.e_Shop_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.e_Shop_DatabaseDataSet;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CartTableAdapter = null;
            this.tableAdapterManager.OrdersTableAdapter = null;
            this.tableAdapterManager.ProductsTableAdapter = this.productsTableAdapter;
            this.tableAdapterManager.UpdateOrder = E_Shop.Database.E_Shop_DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // exitButton
            // 
            this.exitButton.AutoSize = true;
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.Black;
            this.exitButton.Location = new System.Drawing.Point(961, 9);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(26, 25);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "X";
            // 
            // addProduct_Panel
            // 
            this.addProduct_Panel.BackColor = System.Drawing.Color.White;
            this.addProduct_Panel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.addProduct_Panel.BorderRadius = 25;
            this.addProduct_Panel.BorderSize = 2;
            this.addProduct_Panel.Controls.Add(this.a_PreviewButton1);
            this.addProduct_Panel.Controls.Add(this.picture_Button);
            this.addProduct_Panel.Controls.Add(this.label1);
            this.addProduct_Panel.Controls.Add(this.price_TextBox);
            this.addProduct_Panel.Controls.Add(this.description_TextBox);
            this.addProduct_Panel.Controls.Add(this.error_Label);
            this.addProduct_Panel.Controls.Add(this.upload_Button);
            this.addProduct_Panel.Controls.Add(this.signUp_Label);
            this.addProduct_Panel.Controls.Add(this.productName_TextBox);
            this.addProduct_Panel.Location = new System.Drawing.Point(204, 102);
            this.addProduct_Panel.Margin = new System.Windows.Forms.Padding(4);
            this.addProduct_Panel.Name = "addProduct_Panel";
            this.addProduct_Panel.Size = new System.Drawing.Size(743, 404);
            this.addProduct_Panel.TabIndex = 2;
            // 
            // a_PreviewButton1
            // 
            this.a_PreviewButton1.BackColor = System.Drawing.Color.LightGray;
            this.a_PreviewButton1.BackgroundColor = System.Drawing.Color.LightGray;
            this.a_PreviewButton1.BorderColor = System.Drawing.Color.Black;
            this.a_PreviewButton1.BorderRadius = 10;
            this.a_PreviewButton1.BorderSize = 0;
            this.a_PreviewButton1.Button_Icon = ((System.Drawing.Icon)(resources.GetObject("a_PreviewButton1.Button_Icon")));
            this.a_PreviewButton1.FlatAppearance.BorderSize = 0;
            this.a_PreviewButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.a_PreviewButton1.ForeColor = System.Drawing.Color.Black;
            this.a_PreviewButton1.Location = new System.Drawing.Point(670, 290);
            this.a_PreviewButton1.Margin = new System.Windows.Forms.Padding(4);
            this.a_PreviewButton1.Name = "a_PreviewButton1";
            this.a_PreviewButton1.Size = new System.Drawing.Size(40, 40);
            this.a_PreviewButton1.TabIndex = 13;
            this.a_PreviewButton1.TextColor = System.Drawing.Color.Black;
            this.a_PreviewButton1.UseVisualStyleBackColor = false;
            this.a_PreviewButton1.Click += new System.EventHandler(this.Preview_Button_Click);
            // 
            // picture_Button
            // 
            this.picture_Button.BackColor = System.Drawing.Color.LightGray;
            this.picture_Button.BackgroundColor = System.Drawing.Color.LightGray;
            this.picture_Button.BorderColor = System.Drawing.Color.Black;
            this.picture_Button.BorderRadius = 10;
            this.picture_Button.BorderSize = 0;
            this.picture_Button.FlatAppearance.BorderSize = 0;
            this.picture_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.picture_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.picture_Button.ForeColor = System.Drawing.Color.Black;
            this.picture_Button.Location = new System.Drawing.Point(146, 289);
            this.picture_Button.Margin = new System.Windows.Forms.Padding(4);
            this.picture_Button.Name = "picture_Button";
            this.picture_Button.Size = new System.Drawing.Size(516, 40);
            this.picture_Button.TabIndex = 12;
            this.picture_Button.Text = "File";
            this.picture_Button.TextColor = System.Drawing.Color.Black;
            this.picture_Button.UseVisualStyleBackColor = false;
            this.picture_Button.Click += new System.EventHandler(this.Picture_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(41, 302);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Product Picture";
            // 
            // price_TextBox
            // 
            this.price_TextBox.BackColor = System.Drawing.SystemColors.Window;
            this.price_TextBox.BorderColor = System.Drawing.Color.Black;
            this.price_TextBox.BorderFocusColor = System.Drawing.Color.Silver;
            this.price_TextBox.BorderRadius = 0;
            this.price_TextBox.BorderSize = 3;
            this.price_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price_TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.price_TextBox.Location = new System.Drawing.Point(43, 245);
            this.price_TextBox.Margin = new System.Windows.Forms.Padding(5);
            this.price_TextBox.Multiline = false;
            this.price_TextBox.Name = "price_TextBox";
            this.price_TextBox.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.price_TextBox.PasswordChar = false;
            this.price_TextBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.price_TextBox.PlaceholderText = "Product Price";
            this.price_TextBox.Size = new System.Drawing.Size(667, 35);
            this.price_TextBox.TabIndex = 10;
            this.price_TextBox.Texts = "";
            this.price_TextBox.UnderlinedStyle = true;
            // 
            // description_TextBox
            // 
            this.description_TextBox.BackColor = System.Drawing.SystemColors.Window;
            this.description_TextBox.BorderColor = System.Drawing.Color.Black;
            this.description_TextBox.BorderFocusColor = System.Drawing.Color.Silver;
            this.description_TextBox.BorderRadius = 0;
            this.description_TextBox.BorderSize = 3;
            this.description_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description_TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.description_TextBox.Location = new System.Drawing.Point(42, 128);
            this.description_TextBox.Margin = new System.Windows.Forms.Padding(5);
            this.description_TextBox.Multiline = true;
            this.description_TextBox.Name = "description_TextBox";
            this.description_TextBox.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.description_TextBox.PasswordChar = false;
            this.description_TextBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.description_TextBox.PlaceholderText = "Product Description";
            this.description_TextBox.Size = new System.Drawing.Size(668, 107);
            this.description_TextBox.TabIndex = 9;
            this.description_TextBox.Texts = "";
            this.description_TextBox.UnderlinedStyle = true;
            // 
            // error_Label
            // 
            this.error_Label.ForeColor = System.Drawing.Color.Firebrick;
            this.error_Label.Location = new System.Drawing.Point(43, 497);
            this.error_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.error_Label.Name = "error_Label";
            this.error_Label.Size = new System.Drawing.Size(497, 28);
            this.error_Label.TabIndex = 8;
            // 
            // upload_Button
            // 
            this.upload_Button.BackColor = System.Drawing.Color.LightGray;
            this.upload_Button.BackgroundColor = System.Drawing.Color.LightGray;
            this.upload_Button.BorderColor = System.Drawing.Color.Black;
            this.upload_Button.BorderRadius = 10;
            this.upload_Button.BorderSize = 0;
            this.upload_Button.FlatAppearance.BorderSize = 0;
            this.upload_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.upload_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upload_Button.ForeColor = System.Drawing.Color.Black;
            this.upload_Button.Location = new System.Drawing.Point(42, 337);
            this.upload_Button.Margin = new System.Windows.Forms.Padding(4);
            this.upload_Button.Name = "upload_Button";
            this.upload_Button.Size = new System.Drawing.Size(668, 40);
            this.upload_Button.TabIndex = 7;
            this.upload_Button.Text = "Upload";
            this.upload_Button.TextColor = System.Drawing.Color.Black;
            this.upload_Button.UseVisualStyleBackColor = false;
            this.upload_Button.Click += new System.EventHandler(this.Upload_Button_Click);
            // 
            // signUp_Label
            // 
            this.signUp_Label.AutoSize = true;
            this.signUp_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUp_Label.ForeColor = System.Drawing.Color.Black;
            this.signUp_Label.Location = new System.Drawing.Point(284, 34);
            this.signUp_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.signUp_Label.Name = "signUp_Label";
            this.signUp_Label.Size = new System.Drawing.Size(174, 33);
            this.signUp_Label.TabIndex = 3;
            this.signUp_Label.Text = "Add Product";
            // 
            // productName_TextBox
            // 
            this.productName_TextBox.BackColor = System.Drawing.SystemColors.Window;
            this.productName_TextBox.BorderColor = System.Drawing.Color.Black;
            this.productName_TextBox.BorderFocusColor = System.Drawing.Color.Silver;
            this.productName_TextBox.BorderRadius = 0;
            this.productName_TextBox.BorderSize = 3;
            this.productName_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productName_TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.productName_TextBox.Location = new System.Drawing.Point(42, 83);
            this.productName_TextBox.Margin = new System.Windows.Forms.Padding(5);
            this.productName_TextBox.Multiline = false;
            this.productName_TextBox.Name = "productName_TextBox";
            this.productName_TextBox.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.productName_TextBox.PasswordChar = false;
            this.productName_TextBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.productName_TextBox.PlaceholderText = "Product Title";
            this.productName_TextBox.Size = new System.Drawing.Size(668, 35);
            this.productName_TextBox.TabIndex = 1;
            this.productName_TextBox.Texts = "";
            this.productName_TextBox.UnderlinedStyle = true;
            // 
            // side_Panel
            // 
            this.side_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            this.side_Panel.Controls.Add(this.manageUserPrivilige_Button);
            this.side_Panel.Controls.Add(this.addProducts_Button);
            this.side_Panel.Controls.Add(this.viewCart_Button);
            this.side_Panel.Controls.Add(this.shop_Button);
            this.side_Panel.Controls.Add(this.signOut_Button);
            this.side_Panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.side_Panel.Location = new System.Drawing.Point(0, 0);
            this.side_Panel.Margin = new System.Windows.Forms.Padding(4);
            this.side_Panel.Name = "side_Panel";
            this.side_Panel.Size = new System.Drawing.Size(183, 600);
            this.side_Panel.TabIndex = 6;
            // 
            // addProducts_Button
            // 
            this.addProducts_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.addProducts_Button.Button_Icon = ((System.Drawing.Icon)(resources.GetObject("addProducts_Button.Button_Icon")));
            this.addProducts_Button.FlatAppearance.BorderSize = 0;
            this.addProducts_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.addProducts_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addProducts_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.addProducts_Button.ForeColor = System.Drawing.Color.Silver;
            this.addProducts_Button.IsActive = true;
            this.addProducts_Button.Location = new System.Drawing.Point(0, 233);
            this.addProducts_Button.Margin = new System.Windows.Forms.Padding(4);
            this.addProducts_Button.Name = "addProducts_Button";
            this.addProducts_Button.Size = new System.Drawing.Size(183, 49);
            this.addProducts_Button.TabIndex = 6;
            this.addProducts_Button.Text = "Add Products";
            this.addProducts_Button.UseVisualStyleBackColor = false;
            // 
            // viewCart_Button
            // 
            this.viewCart_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            this.viewCart_Button.Button_Icon = ((System.Drawing.Icon)(resources.GetObject("viewCart_Button.Button_Icon")));
            this.viewCart_Button.FlatAppearance.BorderSize = 0;
            this.viewCart_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.viewCart_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewCart_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.viewCart_Button.ForeColor = System.Drawing.Color.Silver;
            this.viewCart_Button.IsActive = false;
            this.viewCart_Button.Location = new System.Drawing.Point(0, 176);
            this.viewCart_Button.Margin = new System.Windows.Forms.Padding(4);
            this.viewCart_Button.Name = "viewCart_Button";
            this.viewCart_Button.Size = new System.Drawing.Size(183, 49);
            this.viewCart_Button.TabIndex = 5;
            this.viewCart_Button.Text = "View Cart";
            this.viewCart_Button.UseVisualStyleBackColor = false;
            // 
            // shop_Button
            // 
            this.shop_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            this.shop_Button.Button_Icon = ((System.Drawing.Icon)(resources.GetObject("shop_Button.Button_Icon")));
            this.shop_Button.FlatAppearance.BorderSize = 0;
            this.shop_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.shop_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shop_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.shop_Button.ForeColor = System.Drawing.Color.Silver;
            this.shop_Button.IsActive = false;
            this.shop_Button.Location = new System.Drawing.Point(0, 119);
            this.shop_Button.Margin = new System.Windows.Forms.Padding(4);
            this.shop_Button.Name = "shop_Button";
            this.shop_Button.Size = new System.Drawing.Size(183, 49);
            this.shop_Button.TabIndex = 4;
            this.shop_Button.Text = "Shop";
            this.shop_Button.UseVisualStyleBackColor = false;
            // 
            // signOut_Button
            // 
            this.signOut_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            this.signOut_Button.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            this.signOut_Button.BorderColor = System.Drawing.Color.Black;
            this.signOut_Button.BorderRadius = 0;
            this.signOut_Button.BorderSize = 0;
            this.signOut_Button.FlatAppearance.BorderSize = 0;
            this.signOut_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signOut_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.signOut_Button.ForeColor = System.Drawing.Color.Silver;
            this.signOut_Button.Location = new System.Drawing.Point(0, 538);
            this.signOut_Button.Margin = new System.Windows.Forms.Padding(4);
            this.signOut_Button.Name = "signOut_Button";
            this.signOut_Button.Size = new System.Drawing.Size(183, 49);
            this.signOut_Button.TabIndex = 3;
            this.signOut_Button.Text = "Sign out";
            this.signOut_Button.TextColor = System.Drawing.Color.Silver;
            this.signOut_Button.UseVisualStyleBackColor = false;
            this.signOut_Button.Click += new System.EventHandler(this.SignOut_Button_Click);
            // 
            // manageUserPrivilige_Button
            // 
            this.manageUserPrivilige_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            this.manageUserPrivilige_Button.Button_Icon = ((System.Drawing.Icon)(resources.GetObject("manageUserPrivilige_Button.Button_Icon")));
            this.manageUserPrivilige_Button.FlatAppearance.BorderSize = 0;
            this.manageUserPrivilige_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.manageUserPrivilige_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manageUserPrivilige_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.manageUserPrivilige_Button.ForeColor = System.Drawing.Color.Silver;
            this.manageUserPrivilige_Button.IsActive = false;
            this.manageUserPrivilige_Button.Location = new System.Drawing.Point(0, 290);
            this.manageUserPrivilige_Button.Margin = new System.Windows.Forms.Padding(4);
            this.manageUserPrivilige_Button.Name = "manageUserPrivilige_Button";
            this.manageUserPrivilige_Button.Size = new System.Drawing.Size(183, 49);
            this.manageUserPrivilige_Button.TabIndex = 7;
            this.manageUserPrivilige_Button.Text = "User Priviliges";
            this.manageUserPrivilige_Button.UseVisualStyleBackColor = false;
            // 
            // AddProducts_Form
            // 
            this.AcceptButton = this.upload_Button;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.side_Panel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.addProduct_Panel);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddProducts_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Shop_Form";
            this.Load += new System.EventHandler(this.Shop_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.e_Shop_DatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            this.addProduct_Panel.ResumeLayout(false);
            this.addProduct_Panel.PerformLayout();
            this.side_Panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Database.E_Shop_DatabaseDataSet e_Shop_DatabaseDataSet;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private Database.E_Shop_DatabaseDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private Database.E_Shop_DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private Components.A_Panel addProduct_Panel;
        private System.Windows.Forms.Label error_Label;
        private Components.A_Button upload_Button;
        private System.Windows.Forms.Label signUp_Label;
        private Components.A_TexBox productName_TextBox;
        private Components.A_TexBox description_TextBox;
        private Components.A_TexBox price_TextBox;
        private System.Windows.Forms.Label label1;
        private Components.A_Button picture_Button;
        private System.Windows.Forms.Label exitButton;
        private Components.A_PreviewButton a_PreviewButton1;
        private System.Windows.Forms.Panel side_Panel;
        private Components.A_SidePanelButton addProducts_Button;
        private Components.A_SidePanelButton viewCart_Button;
        private Components.A_SidePanelButton shop_Button;
        private Components.A_Button signOut_Button;
        private Components.A_SidePanelButton manageUserPrivilige_Button;
    }
}