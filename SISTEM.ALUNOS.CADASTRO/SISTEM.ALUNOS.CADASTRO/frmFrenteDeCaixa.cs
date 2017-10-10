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

        private void button1_Click(object sender, EventArgs e)
        {
            
            

            //_bs.Add(frm);
            AjustaTotal();
        }

        private void AjustaTotal()
        {
            txtTotal.Text = _bs.ObtenhaTodos().Sum(c => c.Preco).ToString(CultureInfo.InvariantCulture);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_bs.Current != null) _bs.RemoveCurrent();
           
            AjustaTotal();
        }
    }
}
