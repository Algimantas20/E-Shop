using E_Shop.Classes;
using E_Shop.Database;
using E_Shop.Components;
using System;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Shop.Forms
{
    public partial class SignUp_Form : Form
    {
        public SignUp_Form()
        {
            InitializeComponent();
            new A_Form(this).Apply(signUp_Panel);

            this.back_Button.Click += (s, e) => A_Button.OpenForm<SignIn_Form>(this);
            this.exitButton.Click += async (s, e) => await A_Button.ExitApplication(this);
        }
        #region -> Private Methods
        private void SignUp_Form_Load(object sender, EventArgs e)
        {
            this.usersTableAdapter.Fill(this.e_Shop_DatabaseDataSet.Users);
        }
        private void SignIn_Button_Click(object sender, EventArgs e)
        {
            string username = username_TextBox.Texts;
            string password = password_TextBox.Texts;
            string first_name = firstName_TextBox.Texts;
            string last_name = lastName_TextBox.Texts;
            string email = email_TextBox.Texts;

            bool isNull = CheckIfNull(username, password, first_name, last_name, email);
            if (isNull)
                return;

            bool isValidEmail = ValidateEmail(email);
            if (!isValidEmail)
                return;

            try
            {
                E_Shop_DatabaseDataSet.UsersRow newUserRow;
                newUserRow = e_Shop_DatabaseDataSet.Users.NewUsersRow();

                newUserRow.Username = username;
                newUserRow.Password = password;
                newUserRow.First_Name = first_name;
                newUserRow.Last_Name = last_name;
                newUserRow.Email = email;
                newUserRow.Privilege = "User";

                this.e_Shop_DatabaseDataSet.Users.Rows.Add(newUserRow);
                newUserRow.EndEdit();
                int rowsAffected = this.usersTableAdapter.Update(e_Shop_DatabaseDataSet.Users);

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
        #endregion
    }
}
