using E_Shop.Classes;
using E_Shop.Forms;
using E_Shop.Components;

using System;
using System.Data;
using System.Windows.Forms;
using System.Threading.Tasks;
using E_Shop.Forms.Sub_Forms;

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
            this.usersTableAdapter.Fill(dataTable: this.e_Shop_DatabaseDataSet.Users);
        }

        private async void SignIn_Button_Click(object sender, EventArgs e)
        {
            (string username, string password) = GetUserData();

            if (string.IsNullOrEmpty(value: username) || string.IsNullOrEmpty(value: password))
            {
                await MessageHelper.Print(message: "Please fill out all fields!", label: output_Label, type: MessageType.Warning);
                return;
            }

            try
            {
                bool isValidUser = GetAndValidateUser(username: username, password: password, user: out DataRow user);

                if (!isValidUser)
                {
                    await MessageHelper.Print(message: "Invalid username or password!", label: output_Label, type: MessageType.Error);
                    return;
                }

                LogInUser(user: user);

                await MessageHelper.Print(message: "Success", label: output_Label, type: MessageType.Success);
                A_Button.OpenForm<Shop_Form>(currentForm: this);
            }
            catch (Exception ex)
            {
                await MessageHelper.Print(message: ex.Message, label: output_Label, type: MessageType.Error);
            }
        }

        #endregion

        #region -> User Methods

        private static void LogInUser(DataRow user)
        {
            User.Id = Convert.ToInt32(value: user["Id"]);
            User.Username = user["Username"].ToString();
            User.First_Name = user["First_Name"].ToString();
            User.Last_Name = user["Last_Name"].ToString();
            User.Privilege = user["Privilege"].ToString();
        }

        private (string Username, string Password) GetUserData()
        {
            return (Username: username_TextBox.Texts.Trim(), Password: password_TextBox.Texts.Trim());
        }

        private bool GetAndValidateUser(string username, string password, out DataRow user)
        {
            DataRow[] users = this.e_Shop_DatabaseDataSet.Users.Select(filterExpression: $"Username = '{username.Replace(oldValue: "'", newValue: "''")}'");

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
