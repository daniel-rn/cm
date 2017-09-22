using System;
using System.Windows.Forms;
using Biblioteca;

namespace SISTEM.ALUNOS.CADASTRO
{
    public partial class LoginForm : Form
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
            }
            catch (Exception erro)
            {
                MessageBox.Show(@"Erro ao fazer login: " + erro.Message);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
