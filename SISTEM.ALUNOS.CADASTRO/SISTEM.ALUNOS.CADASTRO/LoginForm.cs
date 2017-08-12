using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;

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

                if (alunoLogin._nome.Equals(txtNome.Text) && alunoLogin._telefone.Equals(txtTelefone.Text))
                {
                    new TelaCadastro().Show();
                    new TelaExibeCadastros().Show();

                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao fazer login: " + erro.Message);
            }
        }
    }
}
