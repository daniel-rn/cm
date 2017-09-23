using System;
using System.Windows.Forms;
using CORE;

namespace CORUJA
{
    public partial class LoginForm : FormBase
    {
        public LoginForm() : base("Login")
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
                MessageBox.Show(MensagemDeErro(erro));
            }
        }

        private static string MensagemDeErro(Exception erro)
        {
            return $"Erro ao fazer login:\nUsuário ou senha inválidos !!\n{erro}";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
