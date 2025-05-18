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
            this.e_Shop_DatabaseDataSet = new E_Shop.Database.E_Shop_DatabaseDataSet();
            this.cartBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cartTableAdapter = new E_Shop.Database.E_Shop_DatabaseDataSetTableAdapters.CartTableAdapter();
            this.tableAdapterManager = new E_Shop.Database.E_Shop_DatabaseDataSetTableAdapters.TableAdapterManager();
            this.output_Label = new System.Windows.Forms.Label();
            this.addToCart_Button = new E_Shop.Components.A_Button();
            this.cart_Price_panel = new E_Shop.Components.A_Panel();
            this.cart_Price_Label = new System.Windows.Forms.Label();
            this.cart_Amount_Panel = new E_Shop.Components.A_Panel();
            this.cart_Amount_Label = new System.Windows.Forms.Label();
            this.description_Panel = new E_Shop.Components.A_Panel();
            this.description_Label = new System.Windows.Forms.Label();
            this.title_Panel = new E_Shop.Components.A_Panel();
            this.title_Label = new System.Windows.Forms.Label();
            this.picture_Panel = new E_Shop.Components.A_Panel();
            this.image_PictureBox = new System.Windows.Forms.PictureBox();
            this.shop_Price_Panel = new E_Shop.Components.A_Panel();
            this.shop_Price_Label = new System.Windows.Forms.Label();
            this.removeFromCart_Button = new E_Shop.Components.A_Button();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter = new E_Shop.Database.E_Shop_DatabaseDataSetTableAdapters.OrdersTableAdapter();
            this.purchase_Button = new E_Shop.Components.A_DelayedButton();
            ((System.ComponentModel.ISupportInitialize)(this.e_Shop_DatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartBindingSource)).BeginInit();
            this.cart_Price_panel.SuspendLayout();
            this.cart_Amount_Panel.SuspendLayout();
            this.description_Panel.SuspendLayout();
            this.title_Panel.SuspendLayout();
            this.picture_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image_PictureBox)).BeginInit();
            this.shop_Price_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // back_Button
            // 
            this.back_Button.AutoSize = true;
            this.back_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_Button.ForeColor = System.Drawing.Color.White;
            this.back_Button.Location = new System.Drawing.Point(13, 9);
            this.back_Button.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.back_Button.Name = "back_Button";
            this.back_Button.Size = new System.Drawing.Size(24, 25);
            this.back_Button.TabIndex = 7;
            this.back_Button.Text = "<";
            // 
            // exitButton
            // 
            this.exitButton.AutoSize = true;
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.exitButton.Location = new System.Drawing.Point(961, 9);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(26, 25);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "X";
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
            this.tableAdapterManager.UpdateOrder = E_Shop.Database.E_Shop_DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // output_Label
            // 
            this.output_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output_Label.Location = new System.Drawing.Point(32, 480);
            this.output_Label.Name = "output_Label";
            this.output_Label.Size = new System.Drawing.Size(948, 53);
            this.output_Label.TabIndex = 15;
            this.output_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.addToCart_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.addToCart_Button.ForeColor = System.Drawing.Color.Black;
            this.addToCart_Button.Location = new System.Drawing.Point(787, 537);
            this.addToCart_Button.Margin = new System.Windows.Forms.Padding(4);
            this.addToCart_Button.Name = "addToCart_Button";
            this.addToCart_Button.Size = new System.Drawing.Size(200, 50);
            this.addToCart_Button.TabIndex = 13;
            this.addToCart_Button.Text = "Add To Cart";
            this.addToCart_Button.TextColor = System.Drawing.Color.Black;
            this.addToCart_Button.UseVisualStyleBackColor = false;
            this.addToCart_Button.Click += new System.EventHandler(this.AddToCart_Button_Click);
            // 
            // cart_Price_panel
            // 
            this.cart_Price_panel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cart_Price_panel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.cart_Price_panel.BorderRadius = 15;
            this.cart_Price_panel.BorderSize = 2;
            this.cart_Price_panel.Controls.Add(this.cart_Price_Label);
            this.cart_Price_panel.Location = new System.Drawing.Point(18, 416);
            this.cart_Price_panel.Name = "cart_Price_panel";
            this.cart_Price_panel.Size = new System.Drawing.Size(480, 61);
            this.cart_Price_panel.TabIndex = 11;
            this.cart_Price_panel.Visible = false;
            // 
            // cart_Price_Label
            // 
            this.cart_Price_Label.Enabled = false;
            this.cart_Price_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cart_Price_Label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cart_Price_Label.Location = new System.Drawing.Point(14, 12);
            this.cart_Price_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cart_Price_Label.Name = "cart_Price_Label";
            this.cart_Price_Label.Size = new System.Drawing.Size(440, 38);
            this.cart_Price_Label.TabIndex = 12;
            this.cart_Price_Label.Text = "Price:";
            this.cart_Price_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cart_Amount_Panel
            // 
            this.cart_Amount_Panel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cart_Amount_Panel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.cart_Amount_Panel.BorderRadius = 15;
            this.cart_Amount_Panel.BorderSize = 2;
            this.cart_Amount_Panel.Controls.Add(this.cart_Amount_Label);
            this.cart_Amount_Panel.Location = new System.Drawing.Point(504, 416);
            this.cart_Amount_Panel.Name = "cart_Amount_Panel";
            this.cart_Amount_Panel.Size = new System.Drawing.Size(483, 61);
            this.cart_Amount_Panel.TabIndex = 10;
            this.cart_Amount_Panel.Visible = false;
            // 
            // cart_Amount_Label
            // 
            this.cart_Amount_Label.Enabled = false;
            this.cart_Amount_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cart_Amount_Label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cart_Amount_Label.Location = new System.Drawing.Point(14, 12);
            this.cart_Amount_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cart_Amount_Label.Name = "cart_Amount_Label";
            this.cart_Amount_Label.Size = new System.Drawing.Size(462, 38);
            this.cart_Amount_Label.TabIndex = 13;
            this.cart_Amount_Label.Text = "Amount:";
            this.cart_Amount_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // description_Panel
            // 
            this.description_Panel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.description_Panel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.description_Panel.BorderRadius = 15;
            this.description_Panel.BorderSize = 2;
            this.description_Panel.Controls.Add(this.description_Label);
            this.description_Panel.Location = new System.Drawing.Point(400, 104);
            this.description_Panel.Name = "description_Panel";
            this.description_Panel.Size = new System.Drawing.Size(587, 306);
            this.description_Panel.TabIndex = 10;
            // 
            // description_Label
            // 
            this.description_Label.Enabled = false;
            this.description_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description_Label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.description_Label.Location = new System.Drawing.Point(16, 13);
            this.description_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.description_Label.Name = "description_Label";
            this.description_Label.Size = new System.Drawing.Size(564, 280);
            this.description_Label.TabIndex = 14;
            this.description_Label.Text = "Description";
            // 
            // title_Panel
            // 
            this.title_Panel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.title_Panel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.title_Panel.BorderRadius = 15;
            this.title_Panel.BorderSize = 2;
            this.title_Panel.Controls.Add(this.title_Label);
            this.title_Panel.Location = new System.Drawing.Point(400, 37);
            this.title_Panel.Name = "title_Panel";
            this.title_Panel.Size = new System.Drawing.Size(587, 61);
            this.title_Panel.TabIndex = 9;
            // 
            // title_Label
            // 
            this.title_Label.Enabled = false;
            this.title_Label.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_Label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.title_Label.Location = new System.Drawing.Point(15, 13);
            this.title_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.title_Label.Name = "title_Label";
            this.title_Label.Size = new System.Drawing.Size(565, 38);
            this.title_Label.TabIndex = 13;
            this.title_Label.Text = "Title";
            this.title_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picture_Panel
            // 
            this.picture_Panel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.picture_Panel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.picture_Panel.BorderRadius = 15;
            this.picture_Panel.BorderSize = 2;
            this.picture_Panel.Controls.Add(this.image_PictureBox);
            this.picture_Panel.Location = new System.Drawing.Point(18, 37);
            this.picture_Panel.Name = "picture_Panel";
            this.picture_Panel.Size = new System.Drawing.Size(376, 373);
            this.picture_Panel.TabIndex = 8;
            // 
            // image_PictureBox
            // 
            this.image_PictureBox.BackColor = System.Drawing.Color.Transparent;
            this.image_PictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.image_PictureBox.Enabled = false;
            this.image_PictureBox.Location = new System.Drawing.Point(14, 13);
            this.image_PictureBox.Name = "image_PictureBox";
            this.image_PictureBox.Size = new System.Drawing.Size(349, 347);
            this.image_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.image_PictureBox.TabIndex = 9;
            this.image_PictureBox.TabStop = false;
            // 
            // shop_Price_Panel
            // 
            this.shop_Price_Panel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.shop_Price_Panel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.shop_Price_Panel.BorderRadius = 15;
            this.shop_Price_Panel.BorderSize = 2;
            this.shop_Price_Panel.Controls.Add(this.shop_Price_Label);
            this.shop_Price_Panel.Location = new System.Drawing.Point(18, 416);
            this.shop_Price_Panel.Name = "shop_Price_Panel";
            this.shop_Price_Panel.Size = new System.Drawing.Size(969, 61);
            this.shop_Price_Panel.TabIndex = 13;
            this.shop_Price_Panel.Visible = false;
            // 
            // shop_Price_Label
            // 
            this.shop_Price_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shop_Price_Label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.shop_Price_Label.Location = new System.Drawing.Point(14, 12);
            this.shop_Price_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.shop_Price_Label.Name = "shop_Price_Label";
            this.shop_Price_Label.Size = new System.Drawing.Size(440, 38);
            this.shop_Price_Label.TabIndex = 12;
            this.shop_Price_Label.Text = "Price:";
            this.shop_Price_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // removeFromCart_Button
            // 
            this.removeFromCart_Button.BackColor = System.Drawing.Color.LightGray;
            this.removeFromCart_Button.BackgroundColor = System.Drawing.Color.LightGray;
            this.removeFromCart_Button.BorderColor = System.Drawing.Color.Black;
            this.removeFromCart_Button.BorderRadius = 10;
            this.removeFromCart_Button.BorderSize = 0;
            this.removeFromCart_Button.FlatAppearance.BorderSize = 0;
            this.removeFromCart_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeFromCart_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.removeFromCart_Button.ForeColor = System.Drawing.Color.Black;
            this.removeFromCart_Button.Location = new System.Drawing.Point(18, 537);
            this.removeFromCart_Button.Margin = new System.Windows.Forms.Padding(4);
            this.removeFromCart_Button.Name = "removeFromCart_Button";
            this.removeFromCart_Button.Size = new System.Drawing.Size(200, 50);
            this.removeFromCart_Button.TabIndex = 12;
            this.removeFromCart_Button.Text = "Remove From Cart";
            this.removeFromCart_Button.TextColor = System.Drawing.Color.Black;
            this.removeFromCart_Button.UseVisualStyleBackColor = false;
            this.removeFromCart_Button.Visible = false;
            this.removeFromCart_Button.Click += new System.EventHandler(this.RemoveFromCart_Button_Click);
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.e_Shop_DatabaseDataSet;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // purchase_Button
            // 
            this.purchase_Button.BackColor = System.Drawing.Color.LightGray;
            this.purchase_Button.BackgroundColor = System.Drawing.Color.LightGray;
            this.purchase_Button.BorderColor = System.Drawing.Color.Black;
            this.purchase_Button.BorderRadius = 10;
            this.purchase_Button.BorderSize = 0;
            this.purchase_Button.Delay = 2000;
            this.purchase_Button.FlatAppearance.BorderSize = 0;
            this.purchase_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.purchase_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.purchase_Button.ForeColor = System.Drawing.Color.Black;
            this.purchase_Button.Location = new System.Drawing.Point(580, 537);
            this.purchase_Button.Name = "purchase_Button";
            this.purchase_Button.Size = new System.Drawing.Size(200, 50);
            this.purchase_Button.TabIndex = 16;
            this.purchase_Button.Text = "Purchase";
            this.purchase_Button.TextColor = System.Drawing.Color.Black;
            this.purchase_Button.UseVisualStyleBackColor = false;
            // 
            // Product_Form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(1007, 607);
            this.Controls.Add(this.purchase_Button);
            this.Controls.Add(this.output_Label);
            this.Controls.Add(this.addToCart_Button);
            this.Controls.Add(this.removeFromCart_Button);
            this.Controls.Add(this.cart_Price_panel);
            this.Controls.Add(this.cart_Amount_Panel);
            this.Controls.Add(this.description_Panel);
            this.Controls.Add(this.title_Panel);
            this.Controls.Add(this.picture_Panel);
            this.Controls.Add(this.back_Button);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.shop_Price_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Product_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ViewCart_Product_Form";
            this.Load += new System.EventHandler(this.Product_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.e_Shop_DatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartBindingSource)).EndInit();
            this.cart_Price_panel.ResumeLayout(false);
            this.cart_Amount_Panel.ResumeLayout(false);
            this.description_Panel.ResumeLayout(false);
            this.title_Panel.ResumeLayout(false);
            this.picture_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.image_PictureBox)).EndInit();
            this.shop_Price_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label back_Button;
        private System.Windows.Forms.Label exitButton;
        private Components.A_Panel title_Panel;
        private Components.A_Panel description_Panel;
        private Components.A_Panel cart_Amount_Panel;
        private Components.A_Panel cart_Price_panel;
        private System.Windows.Forms.Label cart_Amount_Label;
        private System.Windows.Forms.Label cart_Price_Label;
        private Components.A_Button addToCart_Button;
        private System.Windows.Forms.Label title_Label;
        private System.Windows.Forms.Label description_Label;
        private Components.A_Panel shop_Price_Panel;
        private System.Windows.Forms.Label shop_Price_Label;
        private Database.E_Shop_DatabaseDataSet e_Shop_DatabaseDataSet;
        private System.Windows.Forms.BindingSource cartBindingSource;
        private Database.E_Shop_DatabaseDataSetTableAdapters.CartTableAdapter cartTableAdapter;
        private Database.E_Shop_DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.PictureBox image_PictureBox;
        private Components.A_Panel picture_Panel;
        private System.Windows.Forms.Label output_Label;
        private Components.A_Button removeFromCart_Button;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private Database.E_Shop_DatabaseDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private Components.A_DelayedButton purchase_Button;
    }
}