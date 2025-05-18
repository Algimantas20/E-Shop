namespace E_Shop.Forms
{
    partial class UserPriviliges_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserPriviliges_Form));
            this.side_Panel = new System.Windows.Forms.Panel();
            this.orderDB_Button = new E_Shop.Components.A_SidePanelButton();
            this.userPrivilige_Button = new E_Shop.Components.A_SidePanelButton();
            this.viewCart_Button = new E_Shop.Components.A_SidePanelButton();
            this.shop_Button = new E_Shop.Components.A_SidePanelButton();
            this.addProducts_Button = new E_Shop.Components.A_SidePanelButton();
            this.signOut_Button = new E_Shop.Components.A_Button();
            this.e_Shop_DatabaseDataSet = new E_Shop.Database.E_Shop_DatabaseDataSet();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new E_Shop.Database.E_Shop_DatabaseDataSetTableAdapters.UsersTableAdapter();
            this.tableAdapterManager = new E_Shop.Database.E_Shop_DatabaseDataSetTableAdapters.TableAdapterManager();
            this.exitButton = new System.Windows.Forms.Label();
            this.addProduct_Panel = new E_Shop.Components.A_Panel();
            this.userInfo_Panel = new E_Shop.Components.A_Panel();
            this.update_Button = new E_Shop.Components.A_DelayedButton();
            this.output_Label = new System.Windows.Forms.Label();
            this.privilige_Label = new System.Windows.Forms.Label();
            this.email_Label = new System.Windows.Forms.Label();
            this.fullName_Label = new System.Windows.Forms.Label();
            this.userInfo_Label = new System.Windows.Forms.Label();
            this.privilige_ComboBox = new System.Windows.Forms.ComboBox();
            this.username_Label = new System.Windows.Forms.Label();
            this.user_Panel = new E_Shop.Components.A_Panel();
            this.userPriviliges_Label = new System.Windows.Forms.Label();
            this.side_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.e_Shop_DatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.addProduct_Panel.SuspendLayout();
            this.userInfo_Panel.SuspendLayout();
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
            this.orderDB_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            this.orderDB_Button.Button_Icon = ((System.Drawing.Icon)(resources.GetObject("orderDB_Button.Button_Icon")));
            this.orderDB_Button.FlatAppearance.BorderSize = 0;
            this.orderDB_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.orderDB_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orderDB_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.orderDB_Button.ForeColor = System.Drawing.Color.Silver;
            this.orderDB_Button.IsActive = false;
            this.orderDB_Button.Location = new System.Drawing.Point(0, 346);
            this.orderDB_Button.Name = "orderDB_Button";
            this.orderDB_Button.Size = new System.Drawing.Size(183, 40);
            this.orderDB_Button.TabIndex = 11;
            this.orderDB_Button.Text = "Order Database";
            this.orderDB_Button.UseVisualStyleBackColor = false;
            // 
            // userPrivilige_Button
            // 
            this.userPrivilige_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.userPrivilige_Button.Button_Icon = ((System.Drawing.Icon)(resources.GetObject("userPrivilige_Button.Button_Icon")));
            this.userPrivilige_Button.FlatAppearance.BorderSize = 0;
            this.userPrivilige_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.userPrivilige_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userPrivilige_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.userPrivilige_Button.ForeColor = System.Drawing.Color.Silver;
            this.userPrivilige_Button.IsActive = true;
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
            // e_Shop_DatabaseDataSet
            // 
            this.e_Shop_DatabaseDataSet.DataSetName = "E_Shop_DatabaseDataSet";
            this.e_Shop_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.e_Shop_DatabaseDataSet;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CartTableAdapter = null;
            this.tableAdapterManager.OrdersTableAdapter = null;
            this.tableAdapterManager.ProductsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = E_Shop.Database.E_Shop_DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = this.usersTableAdapter;
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
            this.exitButton.TabIndex = 10;
            this.exitButton.Text = "X";
            // 
            // addProduct_Panel
            // 
            this.addProduct_Panel.BackColor = System.Drawing.Color.White;
            this.addProduct_Panel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.addProduct_Panel.BorderRadius = 25;
            this.addProduct_Panel.BorderSize = 2;
            this.addProduct_Panel.Controls.Add(this.userInfo_Panel);
            this.addProduct_Panel.Controls.Add(this.user_Panel);
            this.addProduct_Panel.Controls.Add(this.userPriviliges_Label);
            this.addProduct_Panel.Location = new System.Drawing.Point(204, 102);
            this.addProduct_Panel.Margin = new System.Windows.Forms.Padding(4);
            this.addProduct_Panel.Name = "addProduct_Panel";
            this.addProduct_Panel.Size = new System.Drawing.Size(743, 404);
            this.addProduct_Panel.TabIndex = 7;
            // 
            // userInfo_Panel
            // 
            this.userInfo_Panel.BackColor = System.Drawing.Color.White;
            this.userInfo_Panel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.userInfo_Panel.BorderRadius = 15;
            this.userInfo_Panel.BorderSize = 2;
            this.userInfo_Panel.Controls.Add(this.update_Button);
            this.userInfo_Panel.Controls.Add(this.output_Label);
            this.userInfo_Panel.Controls.Add(this.privilige_Label);
            this.userInfo_Panel.Controls.Add(this.email_Label);
            this.userInfo_Panel.Controls.Add(this.fullName_Label);
            this.userInfo_Panel.Controls.Add(this.userInfo_Label);
            this.userInfo_Panel.Controls.Add(this.privilige_ComboBox);
            this.userInfo_Panel.Controls.Add(this.username_Label);
            this.userInfo_Panel.Location = new System.Drawing.Point(287, 74);
            this.userInfo_Panel.Name = "userInfo_Panel";
            this.userInfo_Panel.Size = new System.Drawing.Size(425, 313);
            this.userInfo_Panel.TabIndex = 5;
            // 
            // update_Button
            // 
            this.update_Button.BackColor = System.Drawing.Color.LightGray;
            this.update_Button.BackgroundColor = System.Drawing.Color.LightGray;
            this.update_Button.BorderColor = System.Drawing.Color.Black;
            this.update_Button.BorderRadius = 10;
            this.update_Button.BorderSize = 0;
            this.update_Button.Delay = 2000;
            this.update_Button.FlatAppearance.BorderSize = 0;
            this.update_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update_Button.ForeColor = System.Drawing.Color.Black;
            this.update_Button.Location = new System.Drawing.Point(41, 247);
            this.update_Button.Name = "update_Button";
            this.update_Button.Size = new System.Drawing.Size(345, 40);
            this.update_Button.TabIndex = 9;
            this.update_Button.Text = "Update";
            this.update_Button.TextColor = System.Drawing.Color.Black;
            this.update_Button.UseVisualStyleBackColor = false;
            // 
            // output_Label
            // 
            this.output_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output_Label.Location = new System.Drawing.Point(38, 186);
            this.output_Label.Name = "output_Label";
            this.output_Label.Size = new System.Drawing.Size(348, 23);
            this.output_Label.TabIndex = 8;
            this.output_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // privilige_Label
            // 
            this.privilige_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.privilige_Label.Location = new System.Drawing.Point(36, 148);
            this.privilige_Label.Name = "privilige_Label";
            this.privilige_Label.Size = new System.Drawing.Size(64, 23);
            this.privilige_Label.TabIndex = 7;
            this.privilige_Label.Text = "Privilige:";
            // 
            // email_Label
            // 
            this.email_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_Label.Location = new System.Drawing.Point(36, 122);
            this.email_Label.Name = "email_Label";
            this.email_Label.Size = new System.Drawing.Size(350, 23);
            this.email_Label.TabIndex = 6;
            this.email_Label.Text = "Email:";
            // 
            // fullName_Label
            // 
            this.fullName_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullName_Label.Location = new System.Drawing.Point(36, 99);
            this.fullName_Label.Name = "fullName_Label";
            this.fullName_Label.Size = new System.Drawing.Size(350, 23);
            this.fullName_Label.TabIndex = 5;
            this.fullName_Label.Text = "Full Name:";
            // 
            // userInfo_Label
            // 
            this.userInfo_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userInfo_Label.Location = new System.Drawing.Point(35, 18);
            this.userInfo_Label.Name = "userInfo_Label";
            this.userInfo_Label.Size = new System.Drawing.Size(341, 23);
            this.userInfo_Label.TabIndex = 4;
            this.userInfo_Label.Text = "User Info";
            this.userInfo_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // privilige_ComboBox
            // 
            this.privilige_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.privilige_ComboBox.FormattingEnabled = true;
            this.privilige_ComboBox.Items.AddRange(new object[] {
            "Admin",
            "User"});
            this.privilige_ComboBox.Location = new System.Drawing.Point(106, 147);
            this.privilige_ComboBox.Name = "privilige_ComboBox";
            this.privilige_ComboBox.Size = new System.Drawing.Size(280, 21);
            this.privilige_ComboBox.TabIndex = 3;
            // 
            // username_Label
            // 
            this.username_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_Label.Location = new System.Drawing.Point(35, 73);
            this.username_Label.Name = "username_Label";
            this.username_Label.Size = new System.Drawing.Size(351, 23);
            this.username_Label.TabIndex = 2;
            this.username_Label.Text = "Username:";
            // 
            // user_Panel
            // 
            this.user_Panel.BackColor = System.Drawing.Color.White;
            this.user_Panel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.user_Panel.BorderRadius = 15;
            this.user_Panel.BorderSize = 2;
            this.user_Panel.Location = new System.Drawing.Point(28, 74);
            this.user_Panel.Name = "user_Panel";
            this.user_Panel.Size = new System.Drawing.Size(242, 313);
            this.user_Panel.TabIndex = 4;
            // 
            // userPriviliges_Label
            // 
            this.userPriviliges_Label.AutoSize = true;
            this.userPriviliges_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userPriviliges_Label.ForeColor = System.Drawing.Color.Black;
            this.userPriviliges_Label.Location = new System.Drawing.Point(224, 23);
            this.userPriviliges_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userPriviliges_Label.Name = "userPriviliges_Label";
            this.userPriviliges_Label.Size = new System.Drawing.Size(305, 33);
            this.userPriviliges_Label.TabIndex = 3;
            this.userPriviliges_Label.Text = "Update User Priviliges";
            // 
            // UserPriviliges_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.addProduct_Panel);
            this.Controls.Add(this.side_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserPriviliges_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "UserPriviliges_Form";
            this.Load += new System.EventHandler(this.UserPriviliges_Form_Load);
            this.side_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.e_Shop_DatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.addProduct_Panel.ResumeLayout(false);
            this.addProduct_Panel.PerformLayout();
            this.userInfo_Panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel side_Panel;
        private Components.A_SidePanelButton userPrivilige_Button;
        private Components.A_SidePanelButton viewCart_Button;
        private Components.A_SidePanelButton shop_Button;
        private Components.A_SidePanelButton addProducts_Button;
        private Components.A_Button signOut_Button;
        private Database.E_Shop_DatabaseDataSet e_Shop_DatabaseDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private Database.E_Shop_DatabaseDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private Database.E_Shop_DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private Components.A_Panel addProduct_Panel;
        private System.Windows.Forms.Label userPriviliges_Label;
        private Components.A_Panel userInfo_Panel;
        private Components.A_Panel user_Panel;
        private System.Windows.Forms.ComboBox privilige_ComboBox;
        private System.Windows.Forms.Label username_Label;
        private System.Windows.Forms.Label email_Label;
        private System.Windows.Forms.Label fullName_Label;
        private System.Windows.Forms.Label userInfo_Label;
        private System.Windows.Forms.Label privilige_Label;
        private System.Windows.Forms.Label exitButton;
        private System.Windows.Forms.Label output_Label;
        private Components.A_DelayedButton update_Button;
        private Components.A_SidePanelButton orderDB_Button;
    }
}