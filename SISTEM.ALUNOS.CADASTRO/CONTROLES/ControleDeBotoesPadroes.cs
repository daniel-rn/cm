using System;
using System.Windows.Forms;

namespace CONTROLES
{
    public partial class ControleDeBotoesPadroes : UserControl
    {
        public Func<dynamic> AoClicarNoBotaoSalvar = () => throw new NotImplementedException();
        public Func<dynamic> AoClicarNoBotaoFechar = () => throw new NotImplementedException();
        public Func<dynamic> AoClicarNoBotaoEmitir = () => throw new NotImplementedException();

        public ControleDeBotoesPadroes()
        {
            InitializeComponent();
        }

        private void btnEmitir_Click(object sender, EventArgs e)
        {
            var item = AoClicarNoBotaoEmitir();
            MessageBox.Show(item);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var item = AoClicarNoBotaoSalvar();
            MessageBox.Show(item);
        }

        private void btnFechar_Click(object sender, EventArgs e) => ((Form)AoClicarNoBotaoFechar()).Dispose();
    }
}
