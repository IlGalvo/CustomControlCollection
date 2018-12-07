using System.Windows.Forms;

namespace CustomControlCollection
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void hidetextButtonProva_Click(object sender, System.EventArgs e)
        {
            hidetextButtonProva.TextVisible = (!hidetextButtonProva.TextVisible);
        }

        private void resizedLabelProva_Click(object sender, System.EventArgs e)
        {
            resizedLabelProva.Text += "porgfjpifekjgorgfjgprekgfregptgijr";
        }
    }
}
