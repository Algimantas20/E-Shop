using E_Shop.Classes;
using E_Shop.Components;
using E_Shop.Forms;
using System;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Shop
{
    public partial class SignIn_Form : Form
    {
        public SignIn_Form()
        {
            InitializeComponent();

            new A_Form(this).Apply(signIn_Panel);

            this.registerButton.Click += (s, e) => A_Button.OpenForm<SignUp_Form>(this);
            this.exitButton.Click += (s, e) => A_Button.ExitApplication(this);

        }
        #region -> Private Methods
        private void SignIn_Form_Load(object sender, EventArgs e)
        {
            this.usersTableAdapter.Fill(this.e_Shop_DatabaseDataSet.Users);
        }

        private void SignIn_Button_Click(object sender, EventArgs e)
        {
            string username = username_TextBox.Texts;
            string password = password_TextBox.Texts;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageHelper.PrintOutMessage("Please fill out all fields!", output_Label, MessageType.Warning);
                return;
            }

            try
            {
                DataRow[] users = this.e_Shop_DatabaseDataSet.Users.Select($"Username = '{username}'");
                DataRow user = users[0];

                string realPassword = user["Password"].ToString();

                if (realPassword != password)
                {
                    MessageHelper.PrintOutMessage("Incorrect password", output_Label, MessageType.Error);
                    return;
                }

                User.Id = Convert.ToInt32(user["Id"]);
                User.Username = user["Username"].ToString();
                User.First_Name = user["First_Name"].ToString();
                User.Last_Name = user["Last_Name"].ToString();
                User.Privilege = user["Privilege"].ToString();

                MessageHelper.PrintOutMessage("Success", output_Label, MessageType.Success);
                A_Button.OpenForm<Shop_Form>(this);
            }
            catch (Exception ex)
            {
                MessageHelper.PrintOutMessage(ex.Message, output_Label, MessageType.Error);
            }
        }
        #endregion
    }
}

