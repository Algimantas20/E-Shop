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

namespace E_Shop.Forms
{
    public partial class ViewCart_Form : Form
    {
        public ViewCart_Form()
        {
            InitializeComponent();

            this.shop_Button.Click += (s, e) => A_Button.OpenForm<Shop_Form>(this);
            this.addProducts_Button.Click += (s, e) => A_Button.OpenForm<AddProducts_Form>(this);
            this.exitButton.Click += async (s, e) => await A_Button.ExitApplication(this);

            this.FormClosing += (s, e) => A_Panel.ClearPanel(viewCart_Panel);
        }

    }
}
