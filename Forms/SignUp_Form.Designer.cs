namespace E_Shop.Forms
{
    partial class SignUp_Form
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
            this.signUp_Panel = new E_Shop.Components.A_Panel();
            this.error_Label = new System.Windows.Forms.Label();
            this.signUp_Button = new E_Shop.Components.A_Button();
            this.email_TextBox = new E_Shop.Components.A_TexBox();
            this.lastName_TextBox = new E_Shop.Components.A_TexBox();
            this.firstName_TextBox = new E_Shop.Components.A_TexBox();
            this.signUp_Label = new System.Windows.Forms.Label();
            this.password_TextBox = new E_Shop.Components.A_TexBox();
            this.username_TextBox = new E_Shop.Components.A_TexBox();
            this.exitButton = new System.Windows.Forms.Label();
            this.back_Button = new System.Windows.Forms.Label();
            this.e_Shop_DatabaseDataSet = new E_Shop.Database.E_Shop_DatabaseDataSet();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new E_Shop.Database.E_Shop_DatabaseDataSetTableAdapters.UsersTableAdapter();
            this.tableAdapterManager = new E_Shop.Database.E_Shop_DatabaseDataSetTableAdapters.TableAdapterManager();
            this.signUp_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.e_Shop_DatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // signUp_Panel
            // 
            this.signUp_Panel.BackColor = System.Drawing.Color.White;
            this.signUp_Panel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.signUp_Panel.BorderRadius = 25;
            this.signUp_Panel.BorderSize = 2;
            this.signUp_Panel.Controls.Add(this.error_Label);
            this.signUp_Panel.Controls.Add(this.signUp_Button);
            this.signUp_Panel.Controls.Add(this.email_TextBox);
            this.signUp_Panel.Controls.Add(this.lastName_TextBox);
            this.signUp_Panel.Controls.Add(this.firstName_TextBox);
            this.signUp_Panel.Controls.Add(this.signUp_Label);
            this.signUp_Panel.Controls.Add(this.password_TextBox);
            this.signUp_Panel.Controls.Add(this.username_TextBox);
            this.signUp_Panel.Location = new System.Drawing.Point(160, 55);
            this.signUp_Panel.Margin = new System.Windows.Forms.Padding(4);
            this.signUp_Panel.Name = "signUp_Panel";
            this.signUp_Panel.Size = new System.Drawing.Size(675, 500);
            this.signUp_Panel.TabIndex = 1;
            // 
            // error_Label
            // 
            this.error_Label.ForeColor = System.Drawing.Color.Firebrick;
            this.error_Label.Location = new System.Drawing.Point(65, 406);
            this.error_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.error_Label.Name = "error_Label";
            this.error_Label.Size = new System.Drawing.Size(565, 28);
            this.error_Label.TabIndex = 8;
            // 
            // signUp_Button
            // 
            this.signUp_Button.BackColor = System.Drawing.Color.LightGray;
            this.signUp_Button.BackgroundColor = System.Drawing.Color.LightGray;
            this.signUp_Button.BorderColor = System.Drawing.Color.Black;
            this.signUp_Button.BorderRadius = 10;
            this.signUp_Button.BorderSize = 0;
            this.signUp_Button.FlatAppearance.BorderSize = 0;
            this.signUp_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signUp_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUp_Button.ForeColor = System.Drawing.Color.Black;
            this.signUp_Button.Location = new System.Drawing.Point(65, 367);
            this.signUp_Button.Margin = new System.Windows.Forms.Padding(4);
            this.signUp_Button.Name = "signUp_Button";
            this.signUp_Button.Size = new System.Drawing.Size(548, 49);
            this.signUp_Button.TabIndex = 7;
            this.signUp_Button.Text = "Sign up";
            this.signUp_Button.TextColor = System.Drawing.Color.Black;
            this.signUp_Button.UseVisualStyleBackColor = false;
            this.signUp_Button.Click += new System.EventHandler(this.SignIn_Button_Click);
            // 
            // email_TextBox
            // 
            this.email_TextBox.BackColor = System.Drawing.SystemColors.Window;
            this.email_TextBox.BorderColor = System.Drawing.Color.Black;
            this.email_TextBox.BorderFocusColor = System.Drawing.Color.Silver;
            this.email_TextBox.BorderRadius = 0;
            this.email_TextBox.BorderSize = 3;
            this.email_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.email_TextBox.Location = new System.Drawing.Point(65, 320);
            this.email_TextBox.Margin = new System.Windows.Forms.Padding(5);
            this.email_TextBox.Multiline = false;
            this.email_TextBox.Name = "email_TextBox";
            this.email_TextBox.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.email_TextBox.PasswordChar = false;
            this.email_TextBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.email_TextBox.PlaceholderText = "Email";
            this.email_TextBox.Size = new System.Drawing.Size(548, 35);
            this.email_TextBox.TabIndex = 6;
            this.email_TextBox.Texts = "";
            this.email_TextBox.UnderlinedStyle = true;
            // 
            // lastName_TextBox
            // 
            this.lastName_TextBox.BackColor = System.Drawing.SystemColors.Window;
            this.lastName_TextBox.BorderColor = System.Drawing.Color.Black;
            this.lastName_TextBox.BorderFocusColor = System.Drawing.Color.Silver;
            this.lastName_TextBox.BorderRadius = 0;
            this.lastName_TextBox.BorderSize = 3;
            this.lastName_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastName_TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lastName_TextBox.Location = new System.Drawing.Point(65, 272);
            this.lastName_TextBox.Margin = new System.Windows.Forms.Padding(5);
            this.lastName_TextBox.Multiline = false;
            this.lastName_TextBox.Name = "lastName_TextBox";
            this.lastName_TextBox.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.lastName_TextBox.PasswordChar = false;
            this.lastName_TextBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.lastName_TextBox.PlaceholderText = "Last Name";
            this.lastName_TextBox.Size = new System.Drawing.Size(548, 35);
            this.lastName_TextBox.TabIndex = 5;
            this.lastName_TextBox.Texts = "";
            this.lastName_TextBox.UnderlinedStyle = true;
            // 
            // firstName_TextBox
            // 
            this.firstName_TextBox.BackColor = System.Drawing.SystemColors.Window;
            this.firstName_TextBox.BorderColor = System.Drawing.Color.Black;
            this.firstName_TextBox.BorderFocusColor = System.Drawing.Color.Silver;
            this.firstName_TextBox.BorderRadius = 0;
            this.firstName_TextBox.BorderSize = 3;
            this.firstName_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstName_TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.firstName_TextBox.Location = new System.Drawing.Point(65, 224);
            this.firstName_TextBox.Margin = new System.Windows.Forms.Padding(5);
            this.firstName_TextBox.Multiline = false;
            this.firstName_TextBox.Name = "firstName_TextBox";
            this.firstName_TextBox.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.firstName_TextBox.PasswordChar = false;
            this.firstName_TextBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.firstName_TextBox.PlaceholderText = "First Name";
            this.firstName_TextBox.Size = new System.Drawing.Size(548, 35);
            this.firstName_TextBox.TabIndex = 4;
            this.firstName_TextBox.Texts = "";
            this.firstName_TextBox.UnderlinedStyle = true;
            // 
            // signUp_Label
            // 
            this.signUp_Label.AutoSize = true;
            this.signUp_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUp_Label.Location = new System.Drawing.Point(277, 82);
            this.signUp_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.signUp_Label.Name = "signUp_Label";
            this.signUp_Label.Size = new System.Drawing.Size(113, 33);
            this.signUp_Label.TabIndex = 3;
            this.signUp_Label.Text = "Sign up";
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
            this.password_TextBox.Location = new System.Drawing.Point(65, 176);
            this.password_TextBox.Margin = new System.Windows.Forms.Padding(5);
            this.password_TextBox.Multiline = false;
            this.password_TextBox.Name = "password_TextBox";
            this.password_TextBox.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.password_TextBox.PasswordChar = true;
            this.password_TextBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.password_TextBox.PlaceholderText = "Password";
            this.password_TextBox.Size = new System.Drawing.Size(548, 35);
            this.password_TextBox.TabIndex = 2;
            this.password_TextBox.Texts = "";
            this.password_TextBox.UnderlinedStyle = true;
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
            this.username_TextBox.Location = new System.Drawing.Point(65, 128);
            this.username_TextBox.Margin = new System.Windows.Forms.Padding(5);
            this.username_TextBox.Multiline = false;
            this.username_TextBox.Name = "username_TextBox";
            this.username_TextBox.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.username_TextBox.PasswordChar = false;
            this.username_TextBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.username_TextBox.PlaceholderText = "Username";
            this.username_TextBox.Size = new System.Drawing.Size(548, 35);
            this.username_TextBox.TabIndex = 1;
            this.username_TextBox.Texts = "";
            this.username_TextBox.UnderlinedStyle = true;
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
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "X";
            this.exitButton.Click += new System.EventHandler(this.Exit_Button_Click);
            // 
            // back_Button
            // 
            this.back_Button.AutoSize = true;
            this.back_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_Button.Location = new System.Drawing.Point(16, 11);
            this.back_Button.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.back_Button.Name = "back_Button";
            this.back_Button.Size = new System.Drawing.Size(24, 25);
            this.back_Button.TabIndex = 3;
            this.back_Button.Text = "<";
            this.back_Button.Click += new System.EventHandler(this.Back_Button_Click);
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
            // SignUp_Form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.back_Button);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.signUp_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SignUp_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "SignUp_Form";
            this.Load += new System.EventHandler(this.SignUp_Form_Load);
            this.signUp_Panel.ResumeLayout(false);
            this.signUp_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.e_Shop_DatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Components.A_Panel signUp_Panel;
        private System.Windows.Forms.Label signUp_Label;
        private Components.A_TexBox password_TextBox;
        private Components.A_TexBox username_TextBox;
        private Components.A_TexBox email_TextBox;
        private Components.A_TexBox lastName_TextBox;
        private Components.A_TexBox firstName_TextBox;
        private System.Windows.Forms.Label exitButton;
        private Components.A_Button signUp_Button;
        private System.Windows.Forms.Label error_Label;
        private System.Windows.Forms.Label back_Button;
        private Database.E_Shop_DatabaseDataSet e_Shop_DatabaseDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private Database.E_Shop_DatabaseDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private Database.E_Shop_DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}