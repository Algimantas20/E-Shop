using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

[ToolboxItem(false)]
public class A_Form : Component
{
    #region -> Variables
    private Form _form;

    private Point _dragCursorPoint;
    private Point _dragFormPoint;

    private double _originalOpacity = 1.0;
    private int _cornerRadius = 20;
    private bool _dragging = false;
    #endregion

    #region -> Imports
    [DllImport("dwmapi.dll")]
    private static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS margins);

    [DllImport("user32.dll", SetLastError = true)]
    private static extern int SetWindowRgn(IntPtr hWnd, IntPtr hRgn, bool bRedraw);

    [DllImport("gdi32.dll")]
    private static extern IntPtr CreateRoundRectRgn(int left, int top, int right, int bottom, int width, int height);
    #endregion

    #region -> Enums
    [StructLayout(LayoutKind.Sequential)]
    private struct MARGINS
    {
        public int Left, Right, Top, Bottom;
    }
    #endregion

    public A_Form(Form form) { _form = form; }

    #region -> Properties
    public int CornerRadius
    {
        get { return _cornerRadius; }
        set
        {
            _cornerRadius = value;
            if (_form != null)
            {
                ApplyRoundedCorners();
            }
        }
    }
    #endregion

    #region Public Methods
    public void Apply(params Panel[] panels)
    {
        _form.FormBorderStyle = FormBorderStyle.None;
        _form.StartPosition = FormStartPosition.CenterScreen;
        _form.Load += Form_Load;
        _form.Resize += (sender, e) => ApplyRoundedCorners();
        _form.MouseDown += Form_MouseDown;
        _form.MouseMove += Form_MouseMove;
        _form.MouseUp += Form_MouseUp;

        if (panels == null)
        {
            return;
        }

        foreach (Panel panel in panels)
        {
            panel.MouseDown += Form_MouseDown;
            panel.MouseMove += Form_MouseMove;
            panel.MouseUp += Form_MouseUp;
        }
    }
    #endregion 

    #region Private Methods
    private void Form_Load(object sender, EventArgs e)
    {
        ApplyRoundedCorners();
    }

    private void ApplyRoundedCorners()
    {
        if (_form != null && _form.Handle != IntPtr.Zero)
        {
            IntPtr hRgn = CreateRoundRectRgn(
                left: 0,
                top: 0,
                right: _form.Width,
                bottom: _form.Height,
                width: _cornerRadius,
                height: _cornerRadius
            );
            SetWindowRgn(hWnd: _form.Handle, hRgn: hRgn, bRedraw: true);

            MARGINS margins = new MARGINS
            {
                Left = 1,
                Right = 1,
                Top = 1,
                Bottom = 1
            };
            DwmExtendFrameIntoClientArea(hWnd: _form.Handle, margins: ref margins);
        }
    }

    private void Form_MouseDown(object sender, MouseEventArgs e)
    {
        _dragging = true;
        _dragCursorPoint = Cursor.Position;
        _dragFormPoint = _form.Location;

        _originalOpacity = _form.Opacity;
        _form.Opacity = 0.7;
    }

    private void Form_MouseMove(object sender, MouseEventArgs e)
    {
        if (_dragging)
        {
            Point diff = Point.Subtract(pt: Cursor.Position, sz: new Size(_dragCursorPoint));
            _form.Location = Point.Add(pt: _dragFormPoint, sz: new Size(diff));
        }
    }

    private void Form_MouseUp(object sender, MouseEventArgs e)
    {
        _dragging = false;

        _form.Opacity = _originalOpacity;
    }
    #endregion
}
