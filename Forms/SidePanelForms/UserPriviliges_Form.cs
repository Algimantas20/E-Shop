using E_Shop.Classes;
using E_Shop.Components;

using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;
using E_Shop.Forms.SidePanelForms;

namespace E_Shop.Forms
{
    public partial class UserPriviliges_Form : Form
    {
        private User _selectedUser;
        public UserPriviliges_Form()
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

        private void UserPriviliges_Form_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            _selectedUser = User.GetUserByUsername(username: button.Text, e_Shop_DatabaseDataSet);
            UpdateUserInfoPanel(_selectedUser);            
        }

        private void UserPriviliges_Form_Load(object sender, EventArgs e)
        {
            this.usersTableAdapter.Fill(this.e_Shop_DatabaseDataSet.Users);
            LoadUsers();
        }

        #endregion

        #region -> Private Methods

        private void UpdateUserInfoPanel(User user)
        {
            username_Label.Text = $"Username: {user.Username}";
            fullName_Label.Text = $"Full Name: {user.FirstName} {user.LastName}";
            email_Label.Text = $"Email: {user.Email}";
            privilige_ComboBox.Text = user.Privilege;
            output_Label.Text = string.Empty;
        }
        private void LoadUsers()
        {
            var users = GetUsers();
            var controls = GenerateUserButtons(users);

            user_Panel.Controls.Clear(); 

            foreach (var control in controls)
            {
                user_Panel.Controls.Add(control);
            }
        }

        private DataRow[] GetUsers()
        {
            return e_Shop_DatabaseDataSet.Users.Select("Id > -1");
        }

        private IEnumerable<A_Button> GenerateUserButtons(DataRow[] users)
        {
            return users.Select((user, index) =>
            {
                var button = new A_Button
                {
                    Text = user["UserName"].ToString(),
                    Width = 190,
                    Height = 40,
                    Left = 25,
                    Top = 25 + (index * 45)
                };
                button.Click += new EventHandler(UserPriviliges_Form_Click);
                return button;
            });
        }

        private void SubscribeMethods()
        {
            new A_Form(form: this).Apply(panels: new Panel[] { user_Panel, side_Panel });

            this.shop_Button.Click += (sender, eventArgs) => A_Button.OpenForm<Shop_Form>(currentForm: this);
            this.addProducts_Button.Click += (sender, eventArgs) => A_Button.OpenForm<AddProducts_Form>(currentForm: this);
            this.viewCart_Button.Click += (sender, eventArgs) => A_Button.OpenForm<ViewCart_Form>(currentForm: this);
            this.orderDB_Button.Click += (sender, eventArgs) => A_Button.OpenForm<OrderDatabase_Form>(currentForm: this);
            this.exitButton.Click += async (sender, eventArgs) => await A_Button.ExitApplication(form: this);
            this.signOut_Button.Click += (sender, eventArgs) => 
            {
                Session.SignOut(); 
                A_Button.OpenForm<SignIn_Form>(currentForm: this);
            };

            this.update_Button.ActionTriggered += (sender, eventArgs) => Update_Button_Click(sender, eventArgs);
        }

        private async void Update_Button_Click(object sender, EventArgs e)
        {
            if (_selectedUser == null)
            {
                await MessageHelper.Print("Please select a user first!", label: output_Label, type: MessageType.Warning);
                return;
            }

            DataRow userRow = e_Shop_DatabaseDataSet.Users.FindById(_selectedUser.Id);
            UpdatePrivilige(userRow, text: privilige_ComboBox.Text);
        }

        private async void UpdatePrivilige(DataRow userRow, string text)
        {
            try
            {
                userRow.BeginEdit();
                userRow["Privilege"] = text;
                userRow.EndEdit();

                usersTableAdapter.Update(e_Shop_DatabaseDataSet.Users);

                await MessageHelper.Print("User privilege updated successfully!", label: output_Label, type: MessageType.Success);

            } catch (Exception ex)
            {
                await MessageHelper.Print($"Error: {ex.Message}", label: output_Label, type: MessageType.Error);
            }
        }

        #endregion
    }
}
