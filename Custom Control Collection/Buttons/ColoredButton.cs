using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace CustomControlCollection.Buttons
{
    public sealed class ColoredButton : Button
    {
        #region GLOBAL_VARIABLES
        private Color baseColor;

        [DefaultValue(typeof(SystemColors), "ControlLight")]
        public Color ClickedColor { get; set; }

        [DefaultValue(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Browsable(false)]
        public bool Clicked { get; private set; }
        #endregion

        #region CONSTRUCTOR 
        public ColoredButton()
        {
            BackColor = SystemColors.ControlLight;

            ClickedColor = BackColor;
            Clicked = false;
        }
        #endregion

        #region CONTROL_EVENTS
        protected override void OnClick(EventArgs e)
        {
            baseColor = BackColor;

            BackColor = ClickedColor;
            Clicked = true;

            base.OnClick(e);
        }

        protected override void OnLostFocus(EventArgs e)
        {
            if (Clicked)
            {
                BackColor = baseColor;

                Clicked = false;
            }

            base.OnLostFocus(e);
        }
        #endregion
    }
}
