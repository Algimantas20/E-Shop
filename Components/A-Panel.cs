using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace E_Shop.Components
{
    public partial class A_Panel : Panel
    {
        private int _borderRadius = 15;
        private int _borderSize = 2;
        private Color _borderColor = Color.FromArgb(49, 51, 56);

        [Category("Appearance")]
        public int BorderRadius
        {
            get => _borderRadius;
            set { _borderRadius = value; this.Invalidate(); }
        }

        [Category("Appearance")]
        public int BorderSize
        {
            get => _borderSize;
            set { _borderSize = value; this.Invalidate(); }
        }

        [Category("Appearance")]
        public Color BorderColor
        {
            get => _borderColor;
            set { _borderColor = value; this.Invalidate(); }
        }

        public A_Panel()
        {
            // Style settings for smooth repaint
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.UpdateStyles();

            // Example default look
            this.BackColor = Color.White;
            this.Size = new Size(100, 100);
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            // Always clear the background to avoid ghosting
            e.Graphics.Clear(this.BackColor);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Prepare rectangles
            Rectangle rectSurface = this.ClientRectangle;
            Rectangle rectBorder = Rectangle.Inflate(rectSurface, -_borderSize, -_borderSize);
            int smoothSize = Math.Max(2, _borderSize);

            // Decide whether to draw rounded or normal
            if (_borderRadius > 2)
            {
                DrawRoundedWindow(e, rectSurface, rectBorder, smoothSize);
            }
            else
            {
                DrawNormalWindow(e, rectSurface);
            }
        }

        protected override void OnScroll(ScrollEventArgs se)
        {
            base.OnScroll(se);
            this.Invalidate(); // Redraw after scrolling
        }

        private GraphicsPath GetPath(RectangleF rect, int radius)
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

        private void DrawNormalWindow(PaintEventArgs e, Rectangle rectSurface)
        {
            e.Graphics.SmoothingMode = SmoothingMode.None;
            this.Region = new Region(rectSurface);

            if (_borderSize >= 1)
            {
                using (Pen penBorder = new Pen(_borderColor, _borderSize))
                {
                    penBorder.Alignment = PenAlignment.Inset;
                    e.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
                }
            }
        }

        private void DrawRoundedWindow(PaintEventArgs e, Rectangle rectSurface, Rectangle rectBorder, int smoothSize)
        {
            int safeBorderRadius = Math.Max(0, _borderRadius - _borderSize);

            using (GraphicsPath pathSurface = GetPath(rectSurface, _borderRadius))
            using (GraphicsPath pathBorder = GetPath(rectBorder, safeBorderRadius))
            using (Pen penSurface = new Pen(this.Parent?.BackColor ?? Color.Transparent, smoothSize))
            using (Pen penBorder = new Pen(_borderColor, _borderSize))
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

                // The Region ensures the panel is clipped to rounded shape
                this.Region = new Region(pathSurface);

                // Draw "outer" path with a pen matching the parent color (smooth edges)
                e.Graphics.DrawPath(penSurface, pathSurface);

                if (_borderSize >= 1)
                {
                    // Draw the actual border
                    e.Graphics.DrawPath(penBorder, pathBorder);
                }
            }
        }
    }
}
