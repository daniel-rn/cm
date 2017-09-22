using System;
using System.Windows.Forms;
using Biblioteca;

namespace SISTEM.ALUNOS.CADASTRO
{
    public partial class LoginForm : FormBase
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Login();

        }

        private void Login()
        {
            try
            {
                var alunoLogin = new AlunoDAL().SelectAluno(txtNome.Text, txtTelefone.Text);

                if (!alunoLogin.Nome.Equals(txtNome.Text) || !alunoLogin.Telefone.Equals(txtTelefone.Text)) return;
                new TelaCadastro().Show();
                new TelaExibeCadastros().Show();
                Hide();
            }
            catch (Exception erro)
            {
                var mensagemErro = "Erro ao fazer login: \nUsuário ou senha inválidos !!\n";
                MessageBox.Show($"{mensagemErro}{erro}");
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
