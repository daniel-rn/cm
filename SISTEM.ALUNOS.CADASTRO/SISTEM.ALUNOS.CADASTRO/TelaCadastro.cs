using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISTEM.ALUNOS.CADASTRO
{
    public partial class TelaCadastro : Form
    {
        AlunoDAO alDAO ;
        Aluno al;
        public TelaCadastro()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            alDAO = new AlunoDAO();
            al = new Aluno()
            {
                _nome = txtNome.Text,
                _telefone = txtTelefone.Text,
                _email = txtEmail.Text
            };
            try
            {
                alDAO.InsereAluno(al);
            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }

        }
    }
}
