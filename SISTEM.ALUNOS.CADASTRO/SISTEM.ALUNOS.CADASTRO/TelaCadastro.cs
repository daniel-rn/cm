using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca;

namespace SISTEM.ALUNOS.CADASTRO
{
    public partial class TelaCadastro : Form
    {
        private AlunoDAL AlunoDAO;
        private Aluno _aluno;

        public TelaCadastro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AlunoDAO = new AlunoDAL();
            _aluno = new Aluno
            {
                Nome = txtNome.Text,
                Telefone = txtTelefone.Text,
                Email = txtEmail.Text
            };
            try
            {
                AlunoDAO.InsereAluno(_aluno);
                MessageBox.Show(@"Registro inserido com sucesso !!!");
                LimpaCampos();
            }
            catch (Exception erro)
            {
                MessageBox.Show(@"Erro ao inserir o registro !!!",erro.Message);
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
