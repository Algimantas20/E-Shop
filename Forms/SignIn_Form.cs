using E_Shop.Classes;
using E_Shop.Forms;
using E_Shop.Components;

using System;
using System.Data;
using System.Windows.Forms;

namespace E_Shop
{
    public partial class SignIn_Form : Form
    {
        public SignIn_Form()
        {
            InitializeComponent();
            SubscribeMethods();
        }

        #region -> Event Handlers

        private void SignIn_Form_Load(object sender, EventArgs e)
        {
            this.usersTableAdapter.Fill(this.e_Shop_DatabaseDataSet.Users);
        }

        private async void SignIn_Button_Click(object sender, EventArgs e)
        {
            var (username, password) = GetUserData();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                await MessageHelper.Print("Please fill out all fields!", label: output_Label, type: MessageType.Warning);
                return;
            }

            try
            {
                bool isValidUser = GetAndValidateUser(username, password, out DataRow user);

                if (!isValidUser)
                {
                    await MessageHelper.Print("Invalid username or password!", label: output_Label, type: MessageType.Error);
                    return;
                }

                Session.SignIn(user);

                await MessageHelper.Print("Success", label: output_Label, type: MessageType.Success);
                A_Button.OpenForm<Shop_Form>(currentForm: this);
            }
            catch (Exception ex)
            {
                await MessageHelper.Print(ex.Message, label: output_Label, type: MessageType.Error);
            }
        }

        #endregion

        #region -> User Methods

        private (string Username, string Password) GetUserData()
        {
            return (Username: username_TextBox.Texts.Trim(), Password: password_TextBox.Texts.Trim());
        }

        private bool GetAndValidateUser(string username, string password, out DataRow user)
        {
            DataRow[] users = this.e_Shop_DatabaseDataSet.Users.Select($"Username = '{username.Replace(oldValue: "'", newValue: "''")}'");

            if (users.Length == 0)
            {
                user = null;
                return false;
            }

            user = users[0];
            string storedPassword = user["Password"].ToString().Trim();

            string enteredHashedPassword = HashHelper.HashPassword(password: password);

            return storedPassword == enteredHashedPassword;
        }

        #endregion

        #region -> Private Methods

        private void SubscribeMethods()
        {
            new A_Form(form: this).Apply(panels: new Panel[] { signIn_Panel });

            this.registerButton.Click += (sender, eventArgs) => A_Button.OpenForm<SignUp_Form>(currentForm: this);
            this.exitButton.Click += async (sender, eventArgs) => await A_Button.ExitApplication(form: this);
        }

        #endregion
    }
}
