using System;
using System.Windows.Forms;

namespace CustomControlCollection.Controls.Buttons
{
    internal class HideTextButton : Button
    {
        #region GLOBAL_VARIABLES
        private string baseText;

        private bool textVisible;
        public bool TextVisible { get { return textVisible; } set { textVisible = value; Text = (textVisible ? baseText : string.Empty); } }
        #endregion

        #region CONSTRUCTOR
        public HideTextButton()
        {
            baseText = Text;
            textVisible = true;
        }
        #endregion

        #region CONTROL_EVENT
        protected override void OnTextChanged(EventArgs e)
        {
            if (textVisible)
            {
                baseText = Text;               
            }

            base.OnTextChanged(e);
        }
        #endregion
    }
}
