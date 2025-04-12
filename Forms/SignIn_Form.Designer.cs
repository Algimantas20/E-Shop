namespace E_Shop
{
    partial class SignIn_Form
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
            this.exitButton = new System.Windows.Forms.Label();
            this.signIn_Panel = new E_Shop.Components.A_Panel();
            this.output_Label = new System.Windows.Forms.Label();
            this.registerButton = new System.Windows.Forms.Label();
            this.signUp_Label = new System.Windows.Forms.Label();
            this.signIn_Label = new System.Windows.Forms.Label();
            this.password_TextBox = new E_Shop.Components.A_TexBox();
            this.signIn_Button = new E_Shop.Components.A_Button();
            this.username_TextBox = new E_Shop.Components.A_TexBox();
            this.e_Shop_DatabaseDataSet = new E_Shop.Database.E_Shop_DatabaseDataSet();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new E_Shop.Database.E_Shop_DatabaseDataSetTableAdapters.UsersTableAdapter();
            this.tableAdapterManager = new E_Shop.Database.E_Shop_DatabaseDataSetTableAdapters.TableAdapterManager();
            this.signIn_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.e_Shop_DatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.AutoSize = true;
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(1071, 9);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(26, 25);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "X";
            // 
            // signIn_Panel
            // 
            this.signIn_Panel.BackColor = System.Drawing.Color.White;
            this.signIn_Panel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.signIn_Panel.BorderRadius = 25;
            this.signIn_Panel.BorderSize = 2;
            this.signIn_Panel.Controls.Add(this.output_Label);
            this.signIn_Panel.Controls.Add(this.registerButton);
            this.signIn_Panel.Controls.Add(this.signUp_Label);
            this.signIn_Panel.Controls.Add(this.signIn_Label);
            this.signIn_Panel.Controls.Add(this.password_TextBox);
            this.signIn_Panel.Controls.Add(this.signIn_Button);
            this.signIn_Panel.Controls.Add(this.username_TextBox);
            this.signIn_Panel.Location = new System.Drawing.Point(160, 87);
            this.signIn_Panel.Margin = new System.Windows.Forms.Padding(4);
            this.signIn_Panel.Name = "signIn_Panel";
            this.signIn_Panel.Size = new System.Drawing.Size(675, 400);
            this.signIn_Panel.TabIndex = 0;
            // 
            // output_Label
            // 
            this.output_Label.Location = new System.Drawing.Point(107, 330);
            this.output_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.output_Label.Name = "output_Label";
            this.output_Label.Size = new System.Drawing.Size(474, 28);
            this.output_Label.TabIndex = 6;
            // 
            // registerButton
            // 
            this.registerButton.AutoSize = true;
            this.registerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerButton.ForeColor = System.Drawing.Color.DimGray;
            this.registerButton.Location = new System.Drawing.Point(377, 304);
            this.registerButton.Margin = new System.Windows.Forms.Padding(0);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(52, 16);
            this.registerButton.TabIndex = 5;
            this.registerButton.Text = "Sign up";
            // 
            // signUp_Label
            // 
            this.signUp_Label.AutoSize = true;
            this.signUp_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUp_Label.Location = new System.Drawing.Point(231, 304);
            this.signUp_Label.Margin = new System.Windows.Forms.Padding(0);
            this.signUp_Label.Name = "signUp_Label";
            this.signUp_Label.Size = new System.Drawing.Size(146, 16);
            this.signUp_Label.TabIndex = 4;
            this.signUp_Label.Text = "Don\'t have an account?";
            // 
            // signIn_Label
            // 
            this.signIn_Label.AutoSize = true;
            this.signIn_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signIn_Label.Location = new System.Drawing.Point(275, 90);
            this.signIn_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.signIn_Label.Name = "signIn_Label";
            this.signIn_Label.Size = new System.Drawing.Size(122, 39);
            this.signIn_Label.TabIndex = 3;
            this.signIn_Label.Text = "Sign in";
            // 
            // password_TextBox
            // 
            this.password_TextBox.BackColor = System.Drawing.SystemColors.Window;
            this.password_TextBox.BorderColor = System.Drawing.Color.Black;
            this.password_TextBox.BorderFocusColor = System.Drawing.Color.Silver;
            this.password_TextBox.BorderRadius = 0;
            this.password_TextBox.BorderSize = 3;
            this.password_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.password_TextBox.Location = new System.Drawing.Point(110, 204);
            this.password_TextBox.Margin = new System.Windows.Forms.Padding(5);
            this.password_TextBox.Multiline = false;
            this.password_TextBox.Name = "password_TextBox";
            this.password_TextBox.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.password_TextBox.PasswordChar = false;
            this.password_TextBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.password_TextBox.PlaceholderText = "Password";
            this.password_TextBox.Size = new System.Drawing.Size(471, 35);
            this.password_TextBox.TabIndex = 2;
            this.password_TextBox.Texts = "";
            this.password_TextBox.UnderlinedStyle = true;
            // 
            // signIn_Button
            // 
            this.signIn_Button.BackColor = System.Drawing.Color.LightGray;
            this.signIn_Button.BackgroundColor = System.Drawing.Color.LightGray;
            this.signIn_Button.BorderColor = System.Drawing.Color.Black;
            this.signIn_Button.BorderRadius = 10;
            this.signIn_Button.BorderSize = 0;
            this.signIn_Button.FlatAppearance.BorderSize = 0;
            this.signIn_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signIn_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signIn_Button.ForeColor = System.Drawing.Color.Black;
            this.signIn_Button.Location = new System.Drawing.Point(127, 251);
            this.signIn_Button.Margin = new System.Windows.Forms.Padding(4);
            this.signIn_Button.Name = "signIn_Button";
            this.signIn_Button.Size = new System.Drawing.Size(432, 49);
            this.signIn_Button.TabIndex = 1;
            this.signIn_Button.Text = "Sign in";
            this.signIn_Button.TextColor = System.Drawing.Color.Black;
            this.signIn_Button.UseVisualStyleBackColor = false;
            this.signIn_Button.Click += new System.EventHandler(this.SignIn_Button_Click);
            // 
            // username_TextBox
            // 
            this.username_TextBox.BackColor = System.Drawing.SystemColors.Window;
            this.username_TextBox.BorderColor = System.Drawing.Color.Black;
            this.username_TextBox.BorderFocusColor = System.Drawing.Color.Silver;
            this.username_TextBox.BorderRadius = 0;
            this.username_TextBox.BorderSize = 3;
            this.username_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.username_TextBox.Location = new System.Drawing.Point(110, 156);
            this.username_TextBox.Margin = new System.Windows.Forms.Padding(5);
            this.username_TextBox.Multiline = false;
            this.username_TextBox.Name = "username_TextBox";
            this.username_TextBox.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.username_TextBox.PasswordChar = false;
            this.username_TextBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.username_TextBox.PlaceholderText = "Username";
            this.username_TextBox.Size = new System.Drawing.Size(471, 35);
            this.username_TextBox.TabIndex = 1;
            this.username_TextBox.Texts = "";
            this.username_TextBox.UnderlinedStyle = true;
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
            this.tableAdapterManager.QuantityTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = E_Shop.Database.E_Shop_DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = this.usersTableAdapter;
            // 
            // SignIn_Form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(1110, 600);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.signIn_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SignIn_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "E-Shop";
            this.Load += new System.EventHandler(this.SignIn_Form_Load);
            this.signIn_Panel.ResumeLayout(false);
            this.signIn_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.e_Shop_DatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Components.A_Panel signIn_Panel;
        private Components.A_Button signIn_Button;
        private E_Shop.Components.A_TexBox username_TextBox;
        private Components.A_TexBox password_TextBox;
        private System.Windows.Forms.Label signIn_Label;
        private System.Windows.Forms.Label registerButton;
        private System.Windows.Forms.Label signUp_Label;
        private System.Windows.Forms.Label exitButton;
        private System.Windows.Forms.Label output_Label;
        private Database.E_Shop_DatabaseDataSet e_Shop_DatabaseDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private Database.E_Shop_DatabaseDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private Database.E_Shop_DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}

