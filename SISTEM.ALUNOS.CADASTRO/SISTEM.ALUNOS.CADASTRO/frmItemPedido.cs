using System;
using System.Windows.Forms;
using CORE;

namespace CORUJA
{
    public partial class frmItemPedido : Form
    {
        private ItemDePedido _itemDePedido;
        public frmItemPedido()
        {
            InitializeComponent();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            _itemDePedido = new ItemDePedido(txtDescricao.Text,Convert.ToDouble(txtPreco.Text));

            Close();
        }

        public ItemDePedido ObtenhaItemDePedido() => _itemDePedido;
    }
}
