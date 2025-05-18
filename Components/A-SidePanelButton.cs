using System;
using System.Drawing;
using System.Windows.Forms;

namespace E_Shop.Components
{
    public partial class A_SidePanelButton : Button
    {
        #region -> Variables
        private Icon _icon;
        private bool _isActive;
        #endregion

        public A_SidePanelButton()
        {
            InitializeComponent();

            this.BackColor = Color.FromArgb(29, 30, 33);

            this.ForeColor = Color.Silver;
            this.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold);
            
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.FlatAppearance.MouseOverBackColor = Color.FromArgb(49, 51, 56);

        }

        #region -> Properties
        public Icon Button_Icon
        {
            get { return _icon; }
            set
            {
                _icon = value;
                if(_icon == null) { return; }
                icon_PictureBox.Image = _icon.ToBitmap();
            }
        }

        public bool IsActive
        {
            get { return _isActive; }
            set
            {
                _isActive = value;
                this.BackColor = _isActive ? Color.FromArgb(49, 51, 56) : Color.FromArgb(29, 30, 33);
            }
        }

        #endregion
    }
}
