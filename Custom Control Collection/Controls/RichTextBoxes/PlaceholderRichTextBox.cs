using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace CustomControlCollection.Controls.RichTextBoxes
{
    internal sealed class PlaceholderRichTextBox : RichTextBox
    {
        #region GLOBAL_VARIABLES
        [DefaultValue("")]
        public string PlaceholderText { get; set; }

        [DefaultValue(typeof(Font), "Microsoft Sans Serif, 8.25")]
        public Font PlaceholerFont { get; set; }

        [DefaultValue(typeof(Color), "DimGray")]
        public Color PlaceholderForeColor { get; set; }

        [DefaultValue(typeof(Color), "Window")]
        public Color PlaceholderBackColor { get; set; }
        #endregion

        #region CONSTRUCTOR
        public PlaceholderRichTextBox()
        {
            DoubleBuffered = true;

            PlaceholderText = string.Empty;
            PlaceholerFont = SystemFonts.DefaultFont;
            PlaceholderForeColor = Color.DimGray;
            PlaceholderBackColor = SystemColors.Window;
        }
        #endregion

        #region CONTROL_EVENTS
        protected override void OnCreateControl()
        {
            ManagePlaceholderChanges();

            base.OnCreateControl();
        }

        protected override void OnTextChanged(EventArgs e)
        {
            ManagePlaceholderChanges();

            base.OnTextChanged(e);
        }

        protected override void OnGotFocus(EventArgs e)
        {
            ManagePlaceholderChanges();

            base.OnGotFocus(e);
        }

        protected override void OnLostFocus(EventArgs e)
        {
            ManagePlaceholderChanges();

            base.OnLostFocus(e);
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }

            base.OnKeyDown(e);
        }

        protected override void OnFontChanged(EventArgs e)
        {
            PlaceholerFont = new Font(PlaceholerFont.FontFamily, Font.Size, PlaceholerFont.Style, PlaceholerFont.Unit, PlaceholerFont.GdiCharSet);

            base.OnFontChanged(e);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.FillRectangle(new SolidBrush(PlaceholderBackColor), ClientRectangle);
            e.Graphics.DrawString(PlaceholderText, PlaceholerFont, new SolidBrush(PlaceholderForeColor), new PointF(0, 0));

            base.OnPaint(e);
        }
        #endregion

        #region PLACEHOLDER_MANAGER
        private void ManagePlaceholderChanges()
        {
            if (Text == string.Empty)
            {
                SetStyle(ControlStyles.UserPaint, (!Focused));

                Invalidate();
            }
        }
        #endregion
    }
}
