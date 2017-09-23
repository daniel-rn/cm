using System;
using System.Windows.Forms;
using CORE;


namespace CORUJA
{
    public partial class TelaExibeCadastros : FormBase
    {
        private readonly Aluno _aluno = new Aluno();

        public TelaExibeCadastros() : base("Exibe Cadastros")
        {
            InitializeComponent();
        }

        private void AtualizaTable()
        {
            try
            {
                var fbReader = _aluno.Open(Connection.FbCnn);
                var bsAlunos = new BindingSource {DataSource = fbReader};
                grid.DataSource = bsAlunos;
            }
            catch (Exception erroException)
            {
                MessageBox.Show(erroException.Message);
            }
        }
        private void TelaExibeCadastros_Load(object sender, EventArgs e)
        {
            AtualizaTable();
        }
    }
}
