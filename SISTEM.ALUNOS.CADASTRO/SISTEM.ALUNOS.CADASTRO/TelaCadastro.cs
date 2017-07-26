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
            alDAO = new AlunoDAO();
            al = new Aluno();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
  
            al._nome = txtNome.Text;
            al._telefone = txtTelefone.Text;
            al._email = txtEmail.Text;

            

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
