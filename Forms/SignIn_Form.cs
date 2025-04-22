using E_Shop.Classes;
using E_Shop.Forms;
using E_Shop.Components;

using System;
using System.Data;
using System.Windows.Forms;
using System.Threading.Tasks;

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
            (string username, string password) = GetUserData();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                await MessageHelper.PrintOutMessage("Please fill out all fields!", output_Label, MessageType.Warning);
                return;
            }

            try
            {
                bool isValidUser = GetAndValidateUser(username, password, out DataRow user);

                if (!isValidUser)
                {
                    await MessageHelper.PrintOutMessage("Invalid username or password!", output_Label, MessageType.Error);
                    return;
                }

                LogInUser(user);

                await MessageHelper.PrintOutMessage("Success", output_Label, MessageType.Success);
                A_Button.OpenForm<Shop_Form>(this);
            }
            catch (Exception ex)
            {
                await MessageHelper.PrintOutMessage(ex.Message, output_Label, MessageType.Error);
            }
        }

        #endregion

        #region -> User Methods

        private static void LogInUser(DataRow user)
        {
            User.Id = Convert.ToInt32(user["Id"]);
            User.Username = user["Username"].ToString();
            User.First_Name = user["First_Name"].ToString();
            User.Last_Name = user["Last_Name"].ToString();
            User.Privilege = user["Privilege"].ToString();
        }

        private (string Username, string Password) GetUserData()
        {
            return (username_TextBox.Texts.Trim(), password_TextBox.Texts.Trim());
        }

        private bool GetAndValidateUser(string username, string password, out DataRow user)
        {
            DataRow[] users = this.e_Shop_DatabaseDataSet.Users.Select($"Username = '{username.Replace("'", "''")}'");

            if (users.Length == 0)
            {
                user = null;
                return false;
            }

            user = users[0];
            string storedPassword = user["Password"].ToString().Trim();

            string enteredHashedPassword = HashHelper.HashPassword(password);

            return storedPassword == enteredHashedPassword;
        }

        #endregion

        #region -> Private Methods

        private void SubscribeMethods()
        {
            new A_Form(this).Apply(signIn_Panel);
            this.registerButton.Click += (s, e) => A_Button.OpenForm<SignUp_Form>(this);
            this.exitButton.Click += async (s, e) => await A_Button.ExitApplication(this);
        }

        #endregion
    }
}
