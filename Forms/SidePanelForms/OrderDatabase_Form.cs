using E_Shop.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Shop.Forms.SidePanelForms
{
    public partial class OrderDatabase_Form : Form
    {
        public OrderDatabase_Form()
        {
            InitializeComponent();
            SubscribeMethods();
        }

        private void SubscribeMethods()
        {
            new A_Form(form: this).Apply();

            this.shop_Button.Click += (sender, e) => A_Button.OpenForm<Shop_Form>(currentForm: this);
            this.viewCart_Button.Click += (sender, e) => A_Button.OpenForm<ViewCart_Form>(currentForm: this);
            this.addProducts_Button.Click += (sender, e) => A_Button.OpenForm<AddProducts_Form>(currentForm: this);
            this.exitButton.Click += async (sender, e) => await A_Button.ExitApplication(form: this);
            this.userPrivilige_Button.Click += (sender, e) => A_Button.OpenForm<UserPriviliges_Form>(currentForm: this);
            this.signOut_Button.Click += (sender, eventArgs) =>
            {
                Session.SignOut();
                A_Button.OpenForm<SignIn_Form>(currentForm: this);
            };
        }

        private void OrderDatabase_Form_Load(object sender, EventArgs e)
        {
            this.ordersTableAdapter.Fill(this.e_Shop_DatabaseDataSet.Orders);

        }
    }
}
