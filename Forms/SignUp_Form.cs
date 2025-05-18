using E_Shop.Classes;
using E_Shop.Components;
using static E_Shop.Database.E_Shop_DatabaseDataSet;

using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace E_Shop.Forms
{
    public partial class SignUp_Form : Form
    {
        public SignUp_Form()
        {
            InitializeComponent();
            SubscribeMethods();
        }

        #region -> Event Handlers

        private void SignUp_Form_Load(object sender, EventArgs e)
        {
            this.usersTableAdapter.Fill(this.e_Shop_DatabaseDataSet.Users);
        }

        private async void SignIn_Button_Click(object sender, EventArgs e)
        {
             var (username, password, first_name, last_name, email) = GetUserData();

            bool isNull = await CheckIfNull(username, password, first_name, last_name, email);
            if (isNull)
                return;

            bool isValidEmail = await ValidateEmail(email);
            if (!isValidEmail)
                return;

            try
            {
                UsersRow newUserRow = GenerateNewRow(username, password, first_name, last_name, email);

                this.e_Shop_DatabaseDataSet.Users.Rows.Add(newUserRow);
                newUserRow.EndEdit();

                this.usersTableAdapter.Update(e_Shop_DatabaseDataSet.Users);
                this.e_Shop_DatabaseDataSet.AcceptChanges();

                await MessageHelper.Print("User registered successfully!", label: error_Label, type: MessageType.Success);
            }
            catch (Exception ex)
            {
                await MessageHelper.Print(ex.Message, label: error_Label, type: MessageType.Error);
                e_Shop_DatabaseDataSet.RejectChanges();
                return;
            }
        }

        #endregion

        #region -> Private Methods

        private (string Username , string Password, string First_name, string Last_name, string Email) GetUserData()
        {
            return (username_TextBox.Texts,
                    password_TextBox.Texts, 
                    firstName_TextBox.Texts,
                    lastName_TextBox.Texts,
                    email_TextBox.Texts);
        }

        private void SubscribeMethods()
        {
            new A_Form(this).Apply(panels: signUp_Panel);

            this.back_Button.Click += (s, e) => A_Button.OpenForm<SignIn_Form>(currentForm: this);
            this.exitButton.Click += async (s, e) => await A_Button.ExitApplication(form: this);
        }

        private async Task<bool> CheckIfNull(string username, string password, string first_name, string last_name, string email)
        {


            if (string.IsNullOrEmpty(username) ||
                string.IsNullOrEmpty(password) ||
                string.IsNullOrEmpty(first_name) ||
                string.IsNullOrEmpty(last_name) ||
                string.IsNullOrEmpty(email))
            {
                await MessageHelper.Print("Please fill out all boxes", label: error_Label, type: MessageType.Warning);
                return true;
            }
            else
            {
                error_Label.Text = "";
                return false;
            }
        }

        private async Task<bool> ValidateEmail(string email)
        {
            Regex validate_Email = new Regex("^\\S+@\\S+\\.\\S+$");

            bool isValidEmail = validate_Email.IsMatch(email);
            if (isValidEmail)
            {
                return true;
            }

            await MessageHelper.Print("Invalid email", label: error_Label, type: MessageType.Error);
            return false;
        }

        private UsersRow GenerateNewRow(string username, string password, string first_name, string last_name, string email)
        {
            UsersRow newUserRow = e_Shop_DatabaseDataSet.Users.NewUsersRow();

            newUserRow.Username = username;
            newUserRow.Password = HashHelper.HashPassword(password);
            newUserRow.First_Name = first_name;
            newUserRow.Last_Name = last_name;
            newUserRow.Email = email;
            newUserRow.Privilege = "User";

            return newUserRow;
        }

        #endregion
    }
}
