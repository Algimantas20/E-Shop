namespace E_Shop.Forms.Sub_Forms
{
    partial class Product_Form
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
            this.back_Button = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Label();
            this.product_Panel = new E_Shop.Components.A_Panel();
            this.addToCart_Button = new E_Shop.Components.A_Button();
            this.editProduct_Button = new E_Shop.Components.A_Button();
            this.price_label = new System.Windows.Forms.Label();
            this.description_label = new System.Windows.Forms.Label();
            this.title_Label = new System.Windows.Forms.Label();
            this.product_PictureBox = new System.Windows.Forms.PictureBox();
            this.e_Shop_DatabaseDataSet = new E_Shop.Database.E_Shop_DatabaseDataSet();
            this.cartBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cartTableAdapter = new E_Shop.Database.E_Shop_DatabaseDataSetTableAdapters.CartTableAdapter();
            this.tableAdapterManager = new E_Shop.Database.E_Shop_DatabaseDataSetTableAdapters.TableAdapterManager();
            this.product_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.product_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_Shop_DatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // back_Button
            // 
            this.back_Button.AutoSize = true;
            this.back_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_Button.Location = new System.Drawing.Point(13, 9);
            this.back_Button.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.back_Button.Name = "back_Button";
            this.back_Button.Size = new System.Drawing.Size(24, 25);
            this.back_Button.TabIndex = 5;
            this.back_Button.Text = "<";
            // 
            // exitButton
            // 
            this.exitButton.AutoSize = true;
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(961, 9);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(26, 25);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "X";
            // 
            // product_Panel
            // 
            this.product_Panel.BackColor = System.Drawing.Color.White;
            this.product_Panel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.product_Panel.BorderRadius = 15;
            this.product_Panel.BorderSize = 2;
            this.product_Panel.Controls.Add(this.addToCart_Button);
            this.product_Panel.Controls.Add(this.editProduct_Button);
            this.product_Panel.Controls.Add(this.price_label);
            this.product_Panel.Controls.Add(this.description_label);
            this.product_Panel.Controls.Add(this.title_Label);
            this.product_Panel.Controls.Add(this.product_PictureBox);
            this.product_Panel.Location = new System.Drawing.Point(16, 40);
            this.product_Panel.Margin = new System.Windows.Forms.Padding(4);
            this.product_Panel.Name = "product_Panel";
            this.product_Panel.Size = new System.Drawing.Size(971, 547);
            this.product_Panel.TabIndex = 6;
            // 
            // addToCart_Button
            // 
            this.addToCart_Button.BackColor = System.Drawing.Color.LightGray;
            this.addToCart_Button.BackgroundColor = System.Drawing.Color.LightGray;
            this.addToCart_Button.BorderColor = System.Drawing.Color.Black;
            this.addToCart_Button.BorderRadius = 10;
            this.addToCart_Button.BorderSize = 0;
            this.addToCart_Button.FlatAppearance.BorderSize = 0;
            this.addToCart_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addToCart_Button.ForeColor = System.Drawing.Color.Black;
            this.addToCart_Button.Location = new System.Drawing.Point(752, 490);
            this.addToCart_Button.Margin = new System.Windows.Forms.Padding(4);
            this.addToCart_Button.Name = "addToCart_Button";
            this.addToCart_Button.Size = new System.Drawing.Size(200, 50);
            this.addToCart_Button.TabIndex = 6;
            this.addToCart_Button.Text = "Add To Cart";
            this.addToCart_Button.TextColor = System.Drawing.Color.Black;
            this.addToCart_Button.UseVisualStyleBackColor = false;
            // 
            // editProduct_Button
            // 
            this.editProduct_Button.BackColor = System.Drawing.Color.LightGray;
            this.editProduct_Button.BackgroundColor = System.Drawing.Color.LightGray;
            this.editProduct_Button.BorderColor = System.Drawing.Color.Black;
            this.editProduct_Button.BorderRadius = 10;
            this.editProduct_Button.BorderSize = 0;
            this.editProduct_Button.FlatAppearance.BorderSize = 0;
            this.editProduct_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editProduct_Button.ForeColor = System.Drawing.Color.Black;
            this.editProduct_Button.Location = new System.Drawing.Point(20, 490);
            this.editProduct_Button.Margin = new System.Windows.Forms.Padding(4);
            this.editProduct_Button.Name = "editProduct_Button";
            this.editProduct_Button.Size = new System.Drawing.Size(200, 50);
            this.editProduct_Button.TabIndex = 5;
            this.editProduct_Button.Text = "Edit Product";
            this.editProduct_Button.TextColor = System.Drawing.Color.Black;
            this.editProduct_Button.UseVisualStyleBackColor = false;
            // 
            // price_label
            // 
            this.price_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price_label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.price_label.Location = new System.Drawing.Point(19, 369);
            this.price_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.price_label.Name = "price_label";
            this.price_label.Size = new System.Drawing.Size(350, 27);
            this.price_label.TabIndex = 3;
            this.price_label.Text = "Price";
            // 
            // description_label
            // 
            this.description_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description_label.Location = new System.Drawing.Point(381, 79);
            this.description_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.description_label.Name = "description_label";
            this.description_label.Size = new System.Drawing.Size(522, 286);
            this.description_label.TabIndex = 2;
            this.description_label.Text = "Description";
            // 
            // title_Label
            // 
            this.title_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_Label.Location = new System.Drawing.Point(377, 15);
            this.title_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.title_Label.Name = "title_Label";
            this.title_Label.Size = new System.Drawing.Size(526, 62);
            this.title_Label.TabIndex = 1;
            this.title_Label.Text = "Title";
            this.title_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // product_PictureBox
            // 
            this.product_PictureBox.BackColor = System.Drawing.Color.Transparent;
            this.product_PictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.product_PictureBox.Location = new System.Drawing.Point(19, 15);
            this.product_PictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.product_PictureBox.Name = "product_PictureBox";
            this.product_PictureBox.Size = new System.Drawing.Size(350, 350);
            this.product_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.product_PictureBox.TabIndex = 0;
            this.product_PictureBox.TabStop = false;
            // 
            // e_Shop_DatabaseDataSet
            // 
            this.e_Shop_DatabaseDataSet.DataSetName = "E_Shop_DatabaseDataSet";
            this.e_Shop_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cartBindingSource
            // 
            this.cartBindingSource.DataMember = "Cart";
            this.cartBindingSource.DataSource = this.e_Shop_DatabaseDataSet;
            // 
            // cartTableAdapter
            // 
            this.cartTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CartTableAdapter = this.cartTableAdapter;
            this.tableAdapterManager.OrdersTableAdapter = null;
            this.tableAdapterManager.ProductsTableAdapter = null;
            this.tableAdapterManager.QuantityTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = E_Shop.Database.E_Shop_DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // Product_Form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.product_Panel);
            this.Controls.Add(this.back_Button);
            this.Controls.Add(this.exitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Product_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Product_Form";
            this.Load += new System.EventHandler(this.Product_Form_Load);
            this.product_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.product_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_Shop_DatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label back_Button;
        private System.Windows.Forms.Label exitButton;
        private Components.A_Panel product_Panel;
        private System.Windows.Forms.Label price_label;
        private System.Windows.Forms.Label description_label;
        private System.Windows.Forms.Label title_Label;
        private System.Windows.Forms.PictureBox product_PictureBox;
        private Components.A_Button editProduct_Button;
        private Components.A_Button addToCart_Button;
        private Database.E_Shop_DatabaseDataSet e_Shop_DatabaseDataSet;
        private System.Windows.Forms.BindingSource cartBindingSource;
        private Database.E_Shop_DatabaseDataSetTableAdapters.CartTableAdapter cartTableAdapter;
        private Database.E_Shop_DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}