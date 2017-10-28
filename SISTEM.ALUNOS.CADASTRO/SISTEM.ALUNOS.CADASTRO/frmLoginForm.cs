using System;
using System.Windows.Forms;
using CORE;
using CORE.Mapeadores;

namespace CORUJA
{
    public partial class frmLoginForm : FormBase
    {
        public frmLoginForm() : base("Login") => InitializeComponent();

        private void btnEntrar_Click(object sender, EventArgs e) => Login();

        private void Login()
        {
            try
            {
                var alunoLogin = new MapeadorDeAluno().ObtenhaAluno(txtNome.Text, txtTelefone.Text);

                if (!alunoLogin.Nome.Equals(txtNome.Text) || !alunoLogin.Telefone.Equals(txtTelefone.Text)) return;
                //new frmTelaCadastro().Show();
                //new frmTelaExibeCadastros().Show();
                new frmPrincipal().Show();
                Hide();
            }
            catch (Exception erro)
            {
                MessageBox.Show(MensagemDeErro(erro));
            }
        }

        private static string MensagemDeErro(Exception erro) => $"Erro ao fazer login:\nUsuário ou senha inválidos !!\n{erro}";

        private void btnSair_Click(object sender, EventArgs e) => Close();
    }
}