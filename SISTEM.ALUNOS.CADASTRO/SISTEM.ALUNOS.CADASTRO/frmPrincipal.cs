using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CORUJA
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new frmItemPedido().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new frmFrenteDeCaixa().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new frmTelaCadastro().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new frmTelaExibeCadastros().ShowDialog();
        }
    }
}
