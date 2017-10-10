using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CORE;

namespace CORUJA
{
    public partial class frmItemPedido : Form
    {
        public ItemDePedido _itemDePedido;
        public frmItemPedido()
        {
            InitializeComponent();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            _itemDePedido = new ItemDePedido(txtDescricao.Text,Convert.ToDouble(txtPreco.Text));

            Hide();
        }

        public ItemDePedido ResuItemDePedido()
        {
            return _itemDePedido;
        }
    }
}
