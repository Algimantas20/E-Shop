using System;
using System.Drawing;
using System.Windows.Forms;

namespace E_Shop.Components
{
    public partial class A_DelayedButton : A_Button
    {
        #region -> Variables

        private Timer _animationTimer;
        private DateTime _mouseDownTime;
        private bool _isHolding = false;
        private float _fillPercentage = 0f;

        public event EventHandler ActionTriggered;

        #endregion

        public A_DelayedButton()
        {
            InitializeComponent();

            this.MouseDown += A_DelayedButton_MouseDown;
            this.MouseUp += A_DelayedButton_MouseUp;
            this.MouseLeave += A_DelayedButton_MouseUp;

            _animationTimer = new Timer
            {
                Interval = 30
            };
            _animationTimer.Tick += AnimationTimer_Tick;

            this.DoubleBuffered = true;
        }

        #region -> Private Methods

        private void A_DelayedButton_MouseDown(object sender, MouseEventArgs e)
        {
            _isHolding = true;
            _fillPercentage = 0f;
            _mouseDownTime = DateTime.Now;
            _animationTimer.Start();
        }

        private void A_DelayedButton_MouseUp(object sender, EventArgs e)
        {
            if (!_isHolding) return;

            _isHolding = false;
            _animationTimer.Stop();
            _fillPercentage = 0f;
            this.Invalidate();
        }

        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            if (!_isHolding) return;

            double elapsed = (DateTime.Now - _mouseDownTime).TotalMilliseconds;
            _fillPercentage = (float)(elapsed / Delay);

            if (_fillPercentage >= 1f)
            {
                _fillPercentage = 1f;
                _isHolding = false;
                _animationTimer.Stop();

                ActionTriggered?.Invoke(sender: this, EventArgs.Empty);

                _fillPercentage = 0f;
                this.Invalidate();
            }

            this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);

            if (_fillPercentage > 0f)
            {
                int fillWidth = (int)(this.Width * _fillPercentage);
                using (Brush fillBrush = new SolidBrush(Color.FromArgb(100, Color.Gray)))
                {
                    pevent.Graphics.FillRectangle(fillBrush, 0, 0, fillWidth, this.Height);
                }
            }
        }

        #endregion

        #region -> Properties

        public int Delay { get; set; } = 2000;

        #endregion

    }
}
