using E_Shop.Classes;
using E_Shop.Components;
using static E_Shop.Database.E_Shop_DatabaseDataSet;

using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;

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

        private void SignIn_Button_Click(object sender, EventArgs e)
        {
            var (username, password, first_name, last_name, email) = GetUserData();

            bool isNull = CheckIfNull(username, password, first_name, last_name, email);
            if (isNull)
                return;

            bool isValidEmail = ValidateEmail(email);
            if (!isValidEmail)
                return;

            try
            {
                UsersRow newUserRow = GenerateNewRow(username, password, first_name, last_name, email);

                this.e_Shop_DatabaseDataSet.Users.Rows.Add(newUserRow);
                newUserRow.EndEdit();

                this.usersTableAdapter.Update(e_Shop_DatabaseDataSet.Users);
                this.e_Shop_DatabaseDataSet.AcceptChanges();

                MessageHelper.PrintOutMessage("User registered successfully!", error_Label, MessageType.Success);
            }
            catch (Exception ex)
            {
                MessageHelper.PrintOutMessage(ex.Message, error_Label, MessageType.Error);
                e_Shop_DatabaseDataSet.RejectChanges();
                return;
            }
        }

        #endregion

        #region -> Private Methods

        private (string Username , string password, string first_name, string last_name, string email) GetUserData()
        {
            return (username_TextBox.Texts,
                    password_TextBox.Texts, 
                    firstName_TextBox.Texts,
                    lastName_TextBox.Texts,
                    email_TextBox.Texts);
        }

        private void SubscribeMethods()
        {
            new A_Form(this).Apply(signUp_Panel);

            this.back_Button.Click += (s, e) => A_Button.OpenForm<SignIn_Form>(this);
            this.exitButton.Click += async (s, e) => await A_Button.ExitApplication(this);
        }

        private bool CheckIfNull(string username, string password, string first_name, string last_name, string email)
        {


            if (string.IsNullOrEmpty(username) ||
                string.IsNullOrEmpty(password) ||
                string.IsNullOrEmpty(first_name) ||
                string.IsNullOrEmpty(last_name) ||
                string.IsNullOrEmpty(email))
            {
                MessageHelper.PrintOutMessage("Please fill out all boxes", error_Label, MessageType.Warning);
                return true;
            }
            else
            {
                error_Label.Text = "";
                return false;
            }
        }

        private bool ValidateEmail(string email)
        {
            Regex validate_Email = new Regex("^\\S+@\\S+\\.\\S+$");
            bool isValidEmail = validate_Email.IsMatch(email);
            if (isValidEmail)
            {
                return true;
            }
            else
            {
                MessageHelper.PrintOutMessage("Invalid email", error_Label, MessageType.Error);
                return false;
            }
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
