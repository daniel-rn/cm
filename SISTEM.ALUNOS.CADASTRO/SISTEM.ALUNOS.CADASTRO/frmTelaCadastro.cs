using System;
using System.Windows.Forms;
using CORE;

namespace CORUJA
{
    public partial class frmTelaCadastro : FormBase
    {
        private MapeadorDeAluno _alunoDao;
        private Aluno _aluno;

        public frmTelaCadastro():base("Cadastro de pessoas")
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _alunoDao = new MapeadorDeAluno();
            _aluno = new Aluno
            {
                Nome = txtNome.Text,
                Telefone = txtTelefone.Text,
                Email = txtEmail.Text
            };
            try
            {
                _alunoDao.InsereAluno(_aluno);
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
