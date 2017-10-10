using System.Windows.Forms;

namespace CONTROLES
{
    public partial class ControleGrid : UserControl
    {
        private BindingSource _bs;
        public ControleGrid(BindingSource bs)
        {
            _bs = bs;
            InitializeComponent();
        }
    }
}
