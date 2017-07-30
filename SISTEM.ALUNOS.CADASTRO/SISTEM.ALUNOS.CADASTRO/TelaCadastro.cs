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
        AlunoDAL alDAO ;
        Aluno al;
        public TelaCadastro()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            alDAO = new AlunoDAL();
            al = new Aluno()
            {
                _nome = txtNome.Text,
                _telefone = txtTelefone.Text,
                _email = txtEmail.Text
            };
            try
            {
                alDAO.InsereAluno(al);
                MessageBox.Show("Registro inserido com sucesso !!!");
                txtNome.Clear();
                txtTelefone.Clear();
                txtEmail.Clear();
                txtNome.Focus();

            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao inserir o registro !!!",erro.Message);
            }

        }
    }
}
