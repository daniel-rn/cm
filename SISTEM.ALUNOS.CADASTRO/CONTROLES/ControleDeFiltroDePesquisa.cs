using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CONTROLES
{
    public partial class ControleDeFiltroDePesquisa : UserControl
    {
        public ControleDeFiltroDePesquisa()
        {
            InitializeComponent();
        }

        public void NaoExibaFiltroNenhum()
        {
            rbNenhum.Visible = false;
            txtNenhum.Visible = false;
        }
    }
}
