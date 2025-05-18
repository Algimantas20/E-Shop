namespace E_Shop.Forms.SidePanelForms
{
    partial class OrderDatabase_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderDatabase_Form));
            this.side_Panel = new System.Windows.Forms.Panel();
            this.orderDB_Button = new E_Shop.Components.A_SidePanelButton();
            this.userPrivilige_Button = new E_Shop.Components.A_SidePanelButton();
            this.viewCart_Button = new E_Shop.Components.A_SidePanelButton();
            this.shop_Button = new E_Shop.Components.A_SidePanelButton();
            this.addProducts_Button = new E_Shop.Components.A_SidePanelButton();
            this.signOut_Button = new E_Shop.Components.A_Button();
            this.exitButton = new System.Windows.Forms.Label();
            this.e_Shop_DatabaseDataSet = new E_Shop.Database.E_Shop_DatabaseDataSet();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter = new E_Shop.Database.E_Shop_DatabaseDataSetTableAdapters.OrdersTableAdapter();
            this.tableAdapterManager = new E_Shop.Database.E_Shop_DatabaseDataSetTableAdapters.TableAdapterManager();
            this.ordersDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.side_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.e_Shop_DatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // side_Panel
            // 
            this.side_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            this.side_Panel.Controls.Add(this.orderDB_Button);
            this.side_Panel.Controls.Add(this.userPrivilige_Button);
            this.side_Panel.Controls.Add(this.viewCart_Button);
            this.side_Panel.Controls.Add(this.shop_Button);
            this.side_Panel.Controls.Add(this.addProducts_Button);
            this.side_Panel.Controls.Add(this.signOut_Button);
            this.side_Panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.side_Panel.Location = new System.Drawing.Point(0, 0);
            this.side_Panel.Margin = new System.Windows.Forms.Padding(4);
            this.side_Panel.Name = "side_Panel";
            this.side_Panel.Size = new System.Drawing.Size(183, 600);
            this.side_Panel.TabIndex = 6;
            // 
            // orderDB_Button
            // 
            this.orderDB_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.orderDB_Button.Button_Icon = ((System.Drawing.Icon)(resources.GetObject("orderDB_Button.Button_Icon")));
            this.orderDB_Button.FlatAppearance.BorderSize = 0;
            this.orderDB_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.orderDB_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orderDB_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.orderDB_Button.ForeColor = System.Drawing.Color.Silver;
            this.orderDB_Button.IsActive = true;
            this.orderDB_Button.Location = new System.Drawing.Point(0, 346);
            this.orderDB_Button.Name = "orderDB_Button";
            this.orderDB_Button.Size = new System.Drawing.Size(183, 40);
            this.orderDB_Button.TabIndex = 10;
            this.orderDB_Button.Text = "Order Database";
            this.orderDB_Button.UseVisualStyleBackColor = false;
            // 
            // userPrivilige_Button
            // 
            this.userPrivilige_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            this.userPrivilige_Button.Button_Icon = ((System.Drawing.Icon)(resources.GetObject("userPrivilige_Button.Button_Icon")));
            this.userPrivilige_Button.FlatAppearance.BorderSize = 0;
            this.userPrivilige_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.userPrivilige_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userPrivilige_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.userPrivilige_Button.ForeColor = System.Drawing.Color.Silver;
            this.userPrivilige_Button.IsActive = false;
            this.userPrivilige_Button.Location = new System.Drawing.Point(0, 290);
            this.userPrivilige_Button.Margin = new System.Windows.Forms.Padding(4);
            this.userPrivilige_Button.Name = "userPrivilige_Button";
            this.userPrivilige_Button.Size = new System.Drawing.Size(183, 49);
            this.userPrivilige_Button.TabIndex = 8;
            this.userPrivilige_Button.Text = "User Priviliges";
            this.userPrivilige_Button.UseVisualStyleBackColor = false;
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
            this.shop_Button.TabIndex = 8;
            this.shop_Button.Text = "Shop";
            this.shop_Button.UseVisualStyleBackColor = false;
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
            // 
            // exitButton
            // 
            this.exitButton.AutoSize = true;
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.Black;
            this.exitButton.Location = new System.Drawing.Point(968, 9);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(26, 25);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "X";
            // 
            // e_Shop_DatabaseDataSet
            // 
            this.e_Shop_DatabaseDataSet.DataSetName = "E_Shop_DatabaseDataSet";
            this.e_Shop_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CartTableAdapter = null;
            this.tableAdapterManager.OrdersTableAdapter = this.ordersTableAdapter;
            this.tableAdapterManager.ProductsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = E_Shop.Database.E_Shop_DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // ordersDataGridView
            // 
            this.ordersDataGridView.AllowUserToAddRows = false;
            this.ordersDataGridView.AllowUserToDeleteRows = false;
            this.ordersDataGridView.AutoGenerateColumns = false;
            this.ordersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ordersDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.ordersDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ordersDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.ordersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.ordersDataGridView.DataSource = this.ordersBindingSource;
            this.ordersDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.ordersDataGridView.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.ordersDataGridView.Location = new System.Drawing.Point(190, 37);
            this.ordersDataGridView.Name = "ordersDataGridView";
            this.ordersDataGridView.Size = new System.Drawing.Size(804, 551);
            this.ordersDataGridView.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "User_Id";
            this.dataGridViewTextBoxColumn2.HeaderText = "User_Id";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Product_Id";
            this.dataGridViewTextBoxColumn3.HeaderText = "Product_Id";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Order_Date";
            this.dataGridViewTextBoxColumn4.HeaderText = "Order_Date";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Order_Amount";
            this.dataGridViewTextBoxColumn5.HeaderText = "Order_Amount";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // OrderDatabase_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(1007, 600);
            this.Controls.Add(this.ordersDataGridView);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.side_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrderDatabase_Form";
            this.Text = "E-Shop";
            this.Load += new System.EventHandler(this.OrderDatabase_Form_Load);
            this.side_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.e_Shop_DatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel side_Panel;
        private Components.A_SidePanelButton orderDB_Button;
        private Components.A_SidePanelButton userPrivilige_Button;
        private Components.A_SidePanelButton viewCart_Button;
        private Components.A_SidePanelButton shop_Button;
        private Components.A_SidePanelButton addProducts_Button;
        private Components.A_Button signOut_Button;
        private System.Windows.Forms.Label exitButton;
        private Database.E_Shop_DatabaseDataSet e_Shop_DatabaseDataSet;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private Database.E_Shop_DatabaseDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private Database.E_Shop_DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView ordersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}