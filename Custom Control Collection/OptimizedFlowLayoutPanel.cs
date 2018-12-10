using System.Windows.Forms;

namespace CustomControlCollection
{
    public sealed class OptimizedFlowLayoutPanel : FlowLayoutPanel
    {
        #region GLOBAL_VARIABLE
        private static readonly int Ws_Clipchildren = 0x02000000;
        #endregion

        #region CONSTRUCTOR
        public OptimizedFlowLayoutPanel()
        {
            DoubleBuffered = true;
        }
        #endregion

        #region COMPONENT_EVENT
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams createParams = base.CreateParams;

                createParams.ExStyle |= Ws_Clipchildren;

                return createParams;
            }
        }
        #endregion
    }
}
