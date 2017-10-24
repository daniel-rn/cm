using System;
using System.Windows.Forms;
using CORE;

namespace CORUJA
{
    public partial class frmItemPedido : Form
    {
        private ItemDePedido _itemDePedido;
        public frmItemPedido() => InitializeComponent();

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            AdicionaItem();
            Close();
        }

        private void AdicionaItem()
        {
            if (string.IsNullOrEmpty(txtDescricao.Text) && string.IsNullOrEmpty(txtPreco.Text)) return;
            _itemDePedido = new ItemDePedido(txtDescricao.Text, Convert.ToDouble(txtPreco.Text));
        }

        public ItemDePedido ObtenhaItemDePedido() => _itemDePedido;
    }
}
