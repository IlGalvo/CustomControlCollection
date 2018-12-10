using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace CustomControlCollection.Buttons
{
    public sealed class ToggleButton : Control
    {
        #region GLOBAL_VARIABLES
        public delegate void ToggledChangedEventHandler(object sender, EventArgs e);
        [Category("Toggle"), DisplayName("ToggleChanged")]
        public event ToggledChangedEventHandler ToggleChanged;

        private GraphicsPath BackGraphicPath;
        private GraphicsPath ForeGraphicsPath;

        #region CONTROL_PROPERTIES
        private bool toggleState;
        [Category("States"), DisplayName("State")]
        public bool ToggleState { get { return toggleState; } set { toggleState = value; OnResize(new EventArgs()); Invalidate(); } }

        private Color onColor;
        [Category("Toggle"), DisplayName("On")]
        public Color OnColor { get { return onColor; } set { onColor = value; Invalidate(); } }

        private Color offColor;
        [Category("Toggle"), DisplayName("Off")]
        public Color OffColor { get { return offColor; } set { offColor = value; Invalidate(); } }

        private Color toggleColor;
        [Category("Toggle"), DisplayName("Color")]
        public Color ToggleColor { get { return toggleColor; } set { toggleColor = value; Invalidate(); } }
        #endregion

        #region HIDDEN_PROPERTIES
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Browsable(false)]
        public new Color BackColor { get; set; }

        [EditorBrowsable(EditorBrowsableState.Never)]
        [Browsable(false)]
        public new Color ForeColor { get; set; }

        [EditorBrowsable(EditorBrowsableState.Never)]
        [Browsable(false)]
        public new Color Font { get; set; }

        [EditorBrowsable(EditorBrowsableState.Never)]
        [Browsable(false)]
        public new string Text { get; set; }

        [EditorBrowsable(EditorBrowsableState.Never)]
        [Browsable(false)]
        public new Image BackgroundImage { get; set; }

        [EditorBrowsable(EditorBrowsableState.Never)]
        [Browsable(false)]
        public new ImageLayout BackgroundImageLayout { get; set; }
        #endregion

        #endregion

        #region CONSTRUCTOR
        public ToggleButton()
        {
            BackColor = Color.Transparent;
            ForeColor = Color.Transparent;

            ToggleState = false;

            OnColor = Color.DodgerBlue;
            OffColor = Color.Red;
            ToggleColor = Color.White;

            ControlStyles controlStyles = ControlStyles.OptimizedDoubleBuffer
                | ControlStyles.SupportsTransparentBackColor
                | ControlStyles.UserPaint
                | ControlStyles.ResizeRedraw;

            SetStyle(controlStyles, true);
        }
        #endregion

        #region CONTROL_EVENTS
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            graphics.CompositingQuality = CompositingQuality.HighQuality;
            graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
            graphics.InterpolationMode = InterpolationMode.HighQualityBilinear;

            if (BackGraphicPath != null)
            {
                graphics.FillPath(new SolidBrush((ToggleState ? OnColor : OffColor)), BackGraphicPath);
            }

            if (ForeGraphicsPath != null)
            {
                graphics.FillPath(new SolidBrush(ToggleColor), ForeGraphicsPath);
            }

            base.OnPaint(e);
        }

        protected override void OnResize(EventArgs e)
        {
            if ((Width != 0) || (Height != 0))
            {
                GraphicsPath backGraphicsPath = new GraphicsPath();
                backGraphicsPath.AddArc(0, 0, Height, Height, 90, 180);
                backGraphicsPath.AddArc((Width - Height), 0, Height, Height, 270, 180);
                backGraphicsPath.CloseFigure();

                BackGraphicPath = backGraphicsPath;

                GraphicsPath foreGraphicsPath = new GraphicsPath();
                foreGraphicsPath.StartFigure();
                foreGraphicsPath.AddArc((ToggleState ? (Width - Height + 4) : 4), 4, (Height - 8), (Height - 8), 0, 360);
                foreGraphicsPath.CloseFigure();

                ForeGraphicsPath = foreGraphicsPath;
            }

            base.OnResize(e);
        }

        protected override void OnClick(EventArgs e)
        {
            ToggleState = (!ToggleState);

            ToggleChanged?.Invoke(this, e);

            base.OnClick(e);
        }

        protected override void OnDoubleClick(EventArgs e)
        {
            OnClick(e);
        }
        #endregion
    }
}