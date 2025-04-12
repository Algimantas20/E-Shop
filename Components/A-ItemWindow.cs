using E_Shop.Classes;
using E_Shop.Forms.Sub_Forms;

using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Diagnostics;


namespace E_Shop.Components
{
    public partial class A_ItemWindow : UserControl
    {
        #region -> Variables
        private Product _product;
        private Form _parentForm;

        private int _borderRadius = 15;
        private int _borderSize = 2;
        private Color _borderColor;
        #endregion

        public A_ItemWindow(Product product, Form parentForm)
        {
            _product = product;
            _parentForm = parentForm;

            InitializeComponent();

            title_label.Text = _product.Title;
            price_label.Text = $"€{_product.Price}";
            image_Box.Image = _product.Image;
            Cursor = Cursors.Hand;

            this.Resize += Window_Resize;
            this.Click += OpenProductPage;
        }

        #region -> Border
        private GraphicsPath GetFigurePath(Rectangle rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = Math.Max(0, Math.Min(radius * 2F, Math.Min(rect.Width, rect.Height)));

            if (curveSize == 0)
            {
                path.AddRectangle(rect);
                return path;
            }

            path.StartFigure();

            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90); // Top-left
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90); // Top-right

            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90); // Bottom-right
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90); // Bottom-left

            path.CloseFigure();
            return path;
        }


        private void DrawNormalWindow(PaintEventArgs pevent, Rectangle rectSurface)
        {
            pevent.Graphics.SmoothingMode = SmoothingMode.None;
            this.Region = new Region(rectSurface);

            if (_borderSize >= 1)
            {
                using (Pen penBorder = new Pen(_borderColor, _borderSize))
                {
                    penBorder.Alignment = PenAlignment.Inset;
                    pevent.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
                }
            }
        }

        private void DrawRoundedWindow(PaintEventArgs pevent, Rectangle rectSurface, Rectangle rectBorder, int smoothSize)
        {
            int safeBorderRadius = Math.Max(0, _borderRadius - _borderSize); // Prevent negative values

            using (GraphicsPath pathSurface = GetFigurePath(rectSurface, _borderRadius))
            using (GraphicsPath pathBorder = GetFigurePath(rectBorder, safeBorderRadius))
            using (Pen penSurface = new Pen(this.Parent?.BackColor ?? Color.Transparent, smoothSize))
            using (Pen penBorder = new Pen(_borderColor, _borderSize))
            {
                pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                this.Region = new Region(pathSurface);
                pevent.Graphics.DrawPath(penSurface, pathSurface);

                if (_borderSize >= 1)
                    pevent.Graphics.DrawPath(penBorder, pathBorder);
            }
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            Rectangle rectSurface = this.ClientRectangle;
            Rectangle rectBorder = Rectangle.Inflate(rectSurface, -_borderSize, -_borderSize);
            int smoothSize = Math.Max(2, _borderSize);

            if (_borderRadius > 2)
            {
                DrawRoundedWindow(pevent, rectSurface, rectBorder, smoothSize);
            }
            else
            {
                DrawNormalWindow(pevent, rectSurface);
            }
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            if (this.Parent != null)
                this.Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
        }
        #endregion

        #region -> Private Methods
        private void Container_BackColorChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }
        private void Window_Resize(object sender, EventArgs e)
        {
            if (_borderRadius > this.Height)
                _borderRadius = this.Height;
        }
        private void OpenProductPage(object sender, EventArgs e)
        {
            _parentForm.Close();
            Product_Form form = new Product_Form(_product);
            {
                form.StartPosition = FormStartPosition.Manual;
                form.Location = _parentForm.Location;
            }
            form.ShowDialog();
        }
        #endregion

        #region Properties
        public Color BackgroundColor
        {
            get { return this.BackColor; }
            set
            {
                this.BackColor = value;
                _borderColor = value;
            }
        }
        #endregion
    }
}
