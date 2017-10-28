using System;
using System.Windows.Forms;
using CORE.Entidades;

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
            AdicionaItem();
            Close();
        }

        private void AdicionaItem()
        {
            if (string.IsNullOrWhiteSpace(txtDescricao.Text) && string.IsNullOrWhiteSpace(txtPreco.Text)) return;
            _itemDePedido = new ItemDePedido(txtDescricao.Text, Convert.ToDouble(txtPreco.Text));
        }

        public ItemDePedido ObtenhaItemDePedido()
        {
            return _itemDePedido;
        }
    }
}