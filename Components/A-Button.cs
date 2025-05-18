using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;

namespace E_Shop.Components
{
    public class A_Button : Button
    {
        #region -> Variables

        private int _borderSize = 0;
        private int _borderRadius = 20;
        private Color _borderColor = Color.Black;

        #endregion

        public A_Button()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.BackColor = Color.LightGray;
            this.ForeColor = Color.Black;
            this.Size = new Size(150, 40);

            this.Resize += new EventHandler(Button_Resize);
        }

        #region -> Border Methods
        private GraphicsPath GetFigurePath(Rectangle rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = Math.Max(0, radius * 2F); // Prevent negative values

            if (curveSize == 0)
            {
                path.AddRectangle(rect);
                return path;
            }

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }

        private void DrawNormalButton(PaintEventArgs pevent, Rectangle rectSurface)
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

        private void DrawRoundedButton(PaintEventArgs pevent, Rectangle rectSurface, Rectangle rectBorder, int smoothSize)
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
            int smoothSize = Math.Max(2, _borderSize); // Ensuring smoothSize is valid

            if (_borderRadius > 2)
            {
                DrawRoundedButton(pevent, rectSurface, rectBorder, smoothSize);
            }
            else
            {
                DrawNormalButton(pevent, rectSurface);
            }
        }
        #endregion

        #region -> Override Methods
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

        public async static void OpenForm<TargetForm>(Form currentForm) where TargetForm : Form, new()
        {
            TargetForm newForm = new TargetForm()
            {
                StartPosition = FormStartPosition.Manual,
                Location = currentForm.Location
            };
            newForm.Show();
            newForm.BringToFront();
            await Task.Delay(100);

            if (currentForm is SignIn_Form)
            {
                currentForm.Hide();
                return;
            }

            currentForm.Close();

            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void Button_Resize(object sender, EventArgs e)
        {
            if (_borderRadius > this.Height)
                _borderRadius = this.Height;
        }

        public static async Task ExitApplication(Form form)
        {
            form.Close();
            form.Dispose();

            await Task.Delay(5);

            Environment.Exit(0);
        }
        #endregion

        #region -> Properties

        [Category("Border")]
        public int BorderSize
        {
            get { return _borderSize; }
            set
            {
                _borderSize = Math.Max(0, value); // Prevent negative values
                this.Invalidate();
            }
        }

        [Category("Border")]
        public int BorderRadius
        {
            get { return _borderRadius; }
            set
            {
                _borderRadius = Math.Max(0, value); // Prevent negative values
                this.Invalidate();
            }
        }

        [Category("Border")]
        public Color BorderColor
        {
            get { return _borderColor; }
            set
            {
                _borderColor = value;
                this.Invalidate();
            }
        }

        [Category("Appearance")]
        public Color BackgroundColor
        {
            get { return this.BackColor; }
            set { this.BackColor = value; }
        }

        [Category("Appearance")]
        public Color TextColor
        {
            get { return this.ForeColor; }
            set { this.ForeColor = value; }
        }

        #endregion

    }
}
