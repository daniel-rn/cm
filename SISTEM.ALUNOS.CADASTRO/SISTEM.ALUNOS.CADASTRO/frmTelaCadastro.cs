using System;
using System.Windows.Forms;
using CORE;
using CORE.Entidades;
using CORE.Mapeadores;

namespace CORUJA
{
    public partial class frmTelaCadastro : FormBase
    {
        public frmTelaCadastro() : base("Cadastro de pessoas")
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MapeadorDeAluno.InsereAluno(new Aluno
                {
                    Nome = txtNome.Text,
                    Telefone = txtTelefone.Text,
                    Email = txtEmail.Text
                });
                MessageBox.Show(@"Registro inserido com sucesso !!!");
                LimpaCampos();
            }
            catch (Exception erro)
            {
                MessageBox.Show(@"Erro ao inserir o registro !!!", erro.Message);
            }
        }

        private void LimpaCampos()
        {
            txtNome.Clear();
            txtTelefone.Clear();
            txtEmail.Clear();
            txtNome.Focus();
        }
    }
}