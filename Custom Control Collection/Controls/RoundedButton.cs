using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace CustomControlCollection.Controls
{
    internal sealed class RoundedButton : Button
    {
        #region GLOBAL_VARIABLE
        private static readonly int DefaultSizeValue = 50;
        #endregion

        #region CONSTRUCTOR
        public RoundedButton()
        {
            DoubleBuffered = true;

            Size = new Size(DefaultSizeValue, DefaultSizeValue);
            BackColor = Color.LightGray;

            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;

            SetStyle(ControlStyles.UserPaint, true);
        }
        #endregion

        #region COMPONENT_EVENT
        protected override void OnPaint(PaintEventArgs pevent)
        {
            using (GraphicsPath graphicsPath = new GraphicsPath())
            {
                graphicsPath.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);

                Region = new Region(graphicsPath);
            }

            base.OnPaint(pevent);
        }
        #endregion
    }
}
