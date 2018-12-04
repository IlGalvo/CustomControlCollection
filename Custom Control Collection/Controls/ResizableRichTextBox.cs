using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace CustomControlCollection.Controls
{
    internal sealed class ResizableRichTextBox : RichTextBox
    {
        #region GLOBAL_VARIABLES
        private int maxRows;
        [DefaultValue(1)]
        public int MaxRows { get { return maxRows; } set { int maxRows = value; if (maxRows > 0) { this.maxRows = maxRows; } } }

        private int charsPerRow;
        [DefaultValue(2147483647)]
        public int CharsPerRow
        {
            get { return charsPerRow; }
            set { int charsPerRow = value; if ((charsPerRow > 0) && (charsPerRow <= MaxLength)) { this.charsPerRow = charsPerRow; } }
        }
        #endregion

        #region CONSTRUCTOR
        public ResizableRichTextBox()
        {
            maxRows = 1;
            charsPerRow = 2147483647;
        }
        #endregion

        #region COMPONENT_EVENTS
        protected override void OnContentsResized(ContentsResizedEventArgs e)
        {
            if ((TextLength <= (CharsPerRow * MaxRows)) && (Text != string.Empty))
            {
                Width = e.NewRectangle.Width;
                Height = e.NewRectangle.Height;
            }

            base.OnContentsResized(e);
        }

        protected override void OnTextChanged(EventArgs e)
        {
            if ((TextLength > (CharsPerRow * MaxRows)) && (Text != string.Empty))
            {
                SelectionStart = TextLength;
                Focus();
            }

            base.OnTextChanged(e);
        }
        #endregion
    }
}
