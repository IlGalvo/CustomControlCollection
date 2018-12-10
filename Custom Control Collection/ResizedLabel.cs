using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace CustomControlCollection
{
    public sealed class ResizedLabel : Label
    {
        #region GLOBAL_VARIABLES
        private static readonly int Offset = 110;

        private string text;
        [DefaultValue("optimizedLabel")]
        public override string Text { get { return base.Text; } set { text = value; WidthTrim(); } }
        #endregion

        #region CONSTRUCTOR
        public ResizedLabel()
        {
            text = "optimizedLabel";
        }
        #endregion

        #region CONTROL_EVENTS
        protected override void OnParentChanged(EventArgs e)
        {
            if (Parent != null)
            {
                Parent.SizeChanged += Parent_SizeChanged;
            }

            base.OnParentChanged(e);
        }

        private void Parent_SizeChanged(object sender, EventArgs e)
        {
            WidthTrim();
        }
        #endregion

        #region WIDTHTRIM_MANAGER
        private void WidthTrim()
        {
            string tmpText = text;

            if (Parent != null)
            {
                int currentWidth = TextRenderer.MeasureText(tmpText, Font).Width;
                double widthRatio = Math.Abs((((double)(Parent.Width - Offset))) / currentWidth);

                while (widthRatio < 1.0)
                {
                    tmpText = (tmpText.Substring(0, (((int)(tmpText.Length * widthRatio)) - 3)) + "...");

                    currentWidth = TextRenderer.MeasureText(tmpText, Font).Width;
                    widthRatio = Math.Abs((((double)(Parent.Width - Offset))) / currentWidth);
                }
            }

            base.Text = tmpText;
        }
        #endregion
    }
}
