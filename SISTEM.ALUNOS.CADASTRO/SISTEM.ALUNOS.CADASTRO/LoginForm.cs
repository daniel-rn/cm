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
            try
            {
                AlunoDAO alDao = new AlunoDAO();
                //Aluno alunoLogin = new Aluno();

                //alunoLogin._nome = txtNome.Text;
                //alunoLogin._telefone = txtTelefone.Text;

                alDao.SelectAluno(txtNome.Text, txtTelefone.Text);

                MessageBox.Show("Sucesso !!!");

                new TelaExibeCadastros().Show();
                new TelaCadastro().Show();
            }
            catch(Exception erro)
            {
                MessageBox.Show("Erro ao fazer login: "+erro.Message);
            }
            
        }
    }
}
