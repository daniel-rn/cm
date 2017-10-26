using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using CORE;

namespace CORUJA
{
    public partial class frmFrenteDeCaixa : FormBase
    {
        private readonly BindingSource _bs = new BindingSource();
        public frmFrenteDeCaixa():base("Frente de Caixa")
        {
            InitializeComponent();
            dgvRelacaoDeItens.DataSource = _bs;
        }

        private void AjustaTotal()
        {
            txtTotal.Text = _bs.ObtenhaTodos().Sum(c => c.Preco).ToString(CultureInfo.InvariantCulture);
        }

        private void pbAdicionar_Click(object sender, EventArgs e)
        {
            var frm = new frmItemPedido();
            frm.ShowDialog();
            var item = frm.ObtenhaItemDePedido();
            if (item != null) _bs.Add(item);
            AjustaTotal();
        }

        private void pbExcluir_Click(object sender, EventArgs e)
        {
            if (_bs.Current != null) _bs.RemoveCurrent();
            AjustaTotal();
        }

        private void pbExcluirTodos_Click(object sender, EventArgs e)
        {
            _bs.Clear();
        }

        private void pbAdicionarTodosAoCarrinho_Click(object sender, EventArgs e)
        {
            try
            {
                var mapeadorDeItem = new MapeadorDeItens();
                mapeadorDeItem.InserirItens(_bs.ObtenhaTodos());
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }
    }
}
