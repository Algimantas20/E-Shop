using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace E_Shop.Components
{
    public partial class A_PreviewButton : A_Button
    {
        private Icon _icon;

        public A_PreviewButton()
        {
            InitializeComponent();

            icon_PictureBox.Size = new Size(34, 34);
            icon_PictureBox.Location = new Point(3, 3);
            icon_PictureBox.BackColor = Color.Transparent;

            this.Size = new Size(40, 40);
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.BorderRadius = 10;

            this.BackColor = Color.LightGray;
            this.ForeColor = Color.Black;
        }

        public Icon Button_Icon
        {
            get { return _icon; }
            set
            {
                _icon = value;
                if (_icon != null)
                {
                    icon_PictureBox.Image = _icon.ToBitmap();
                    icon_PictureBox.Refresh();
                }
            }
        }

        public override string Text
        {
            get => base.Text;
            set => base.Text = "";
        }
    }
}
