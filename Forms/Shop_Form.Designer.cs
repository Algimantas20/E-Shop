namespace E_Shop.Forms
{
    partial class Shop_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Shop_Form));
            this.e_Shop_DatabaseDataSet = new E_Shop.Database.E_Shop_DatabaseDataSet();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter = new E_Shop.Database.E_Shop_DatabaseDataSetTableAdapters.ProductsTableAdapter();
            this.tableAdapterManager = new E_Shop.Database.E_Shop_DatabaseDataSetTableAdapters.TableAdapterManager();
            this.exitButton = new System.Windows.Forms.Label();
            this.shop_Panel = new E_Shop.Components.A_Panel();
            this.side_Panel = new System.Windows.Forms.Panel();
            this.addProducts_Button = new E_Shop.Components.A_SidePanelButton();
            this.signOut_Button = new E_Shop.Components.A_Button();
            this.viewCart_Button = new E_Shop.Components.A_SidePanelButton();
            this.shop_Button = new E_Shop.Components.A_SidePanelButton();
            this.manageUserPrivilige_Button = new E_Shop.Components.A_SidePanelButton();
            ((System.ComponentModel.ISupportInitialize)(this.e_Shop_DatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
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
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "X";
            // 
            // shop_Panel
            // 
            this.shop_Panel.AutoScroll = true;
            this.shop_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.shop_Panel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.shop_Panel.BorderRadius = 15;
            this.shop_Panel.BorderSize = 2;
            this.shop_Panel.Location = new System.Drawing.Point(191, 38);
            this.shop_Panel.Margin = new System.Windows.Forms.Padding(4);
            this.shop_Panel.Name = "shop_Panel";
            this.shop_Panel.Size = new System.Drawing.Size(796, 549);
            this.shop_Panel.TabIndex = 3;
            // 
            // side_Panel
            // 
            this.side_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            this.side_Panel.Controls.Add(this.manageUserPrivilige_Button);
            this.side_Panel.Controls.Add(this.viewCart_Button);
            this.side_Panel.Controls.Add(this.shop_Button);
            this.side_Panel.Controls.Add(this.addProducts_Button);
            this.side_Panel.Controls.Add(this.signOut_Button);
            this.side_Panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.side_Panel.Location = new System.Drawing.Point(0, 0);
            this.side_Panel.Margin = new System.Windows.Forms.Padding(4);
            this.side_Panel.Name = "side_Panel";
            this.side_Panel.Size = new System.Drawing.Size(183, 600);
            this.side_Panel.TabIndex = 5;
            // 
            // addProducts_Button
            // 
            this.addProducts_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            this.addProducts_Button.Button_Icon = ((System.Drawing.Icon)(resources.GetObject("addProducts_Button.Button_Icon")));
            this.addProducts_Button.FlatAppearance.BorderSize = 0;
            this.addProducts_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.addProducts_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addProducts_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.addProducts_Button.ForeColor = System.Drawing.Color.Silver;
            this.addProducts_Button.IsActive = false;
            this.addProducts_Button.Location = new System.Drawing.Point(0, 233);
            this.addProducts_Button.Margin = new System.Windows.Forms.Padding(4);
            this.addProducts_Button.Name = "addProducts_Button";
            this.addProducts_Button.Size = new System.Drawing.Size(183, 49);
            this.addProducts_Button.TabIndex = 6;
            this.addProducts_Button.Text = "Add Products";
            this.addProducts_Button.UseVisualStyleBackColor = false;
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
            this.viewCart_Button.TabIndex = 9;
            this.viewCart_Button.Text = "View Cart";
            this.viewCart_Button.UseVisualStyleBackColor = false;
            // 
            // shop_Button
            // 
            this.shop_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.shop_Button.Button_Icon = ((System.Drawing.Icon)(resources.GetObject("shop_Button.Button_Icon")));
            this.shop_Button.FlatAppearance.BorderSize = 0;
            this.shop_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.shop_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shop_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.shop_Button.ForeColor = System.Drawing.Color.Silver;
            this.shop_Button.IsActive = true;
            this.shop_Button.Location = new System.Drawing.Point(0, 119);
            this.shop_Button.Margin = new System.Windows.Forms.Padding(4);
            this.shop_Button.Name = "shop_Button";
            this.shop_Button.Size = new System.Drawing.Size(183, 49);
            this.shop_Button.TabIndex = 8;
            this.shop_Button.Text = "Shop";
            this.shop_Button.UseVisualStyleBackColor = false;
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
            this.manageUserPrivilige_Button.TabIndex = 8;
            this.manageUserPrivilige_Button.Text = "User Priviliges";
            this.manageUserPrivilige_Button.UseVisualStyleBackColor = false;
            // 
            // Shop_Form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.side_Panel);
            this.Controls.Add(this.shop_Panel);
            this.Controls.Add(this.exitButton);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Shop_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Shop_Form";
            this.Load += new System.EventHandler(this.Shop_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.e_Shop_DatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            this.side_Panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Database.E_Shop_DatabaseDataSet e_Shop_DatabaseDataSet;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private Database.E_Shop_DatabaseDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private Database.E_Shop_DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label exitButton;
        private Components.A_Panel shop_Panel;
        private System.Windows.Forms.Panel side_Panel;
        private Components.A_SidePanelButton addProducts_Button;
        private Components.A_Button signOut_Button;
        private Components.A_SidePanelButton viewCart_Button;
        private Components.A_SidePanelButton shop_Button;
        private Components.A_SidePanelButton manageUserPrivilige_Button;
    }
}