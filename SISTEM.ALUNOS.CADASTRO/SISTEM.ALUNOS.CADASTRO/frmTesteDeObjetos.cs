using System;
using System.Windows.Forms;
using CORE;
using CORE.Entidades;

namespace CORUJA
{
    public partial class frmTesteDeObjetos : FormBase
    {
        public frmTesteDeObjetos() : base("Teste de objetos")
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var nome = txtNome.Text;

            var cliente = new Cliente(ObtenhaEndereco(), nome, 1);

            MessageBox.Show(cliente.ToString());
        }

        private Endereco ObtenhaEndereco()
        {
            var rua = txtRua.Text;
            var setor = txtSetor.Text;
            var numero = txtNumero.Text;
            var cep = txtCep.Text;
            var estado = textBox6.Text;

            var end = new Endereco(rua, Convert.ToInt32(numero), estado, setor, cep);
            return end;
        }
    }
}