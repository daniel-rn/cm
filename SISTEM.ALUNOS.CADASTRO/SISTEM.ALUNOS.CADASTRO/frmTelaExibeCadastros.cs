using System;
using System.Windows.Forms;
using CORE;


namespace CORUJA
{
    public partial class frmTelaExibeCadastros : FormBase
    {
        private readonly Aluno _aluno = new Aluno();

        public frmTelaExibeCadastros() : base("Exibe Cadastros") => InitializeComponent();

        private void AtualizaTable()
        {
            try
            {
                grid.DataSource = new BindingSource {DataSource = MapeadorDeAluno.ObtenhaTodosOsAlunos()};
            }
            catch (Exception erroException)
            {
                MessageBox.Show(erroException.Message);
            }
        }
        private void TelaExibeCadastros_Load(object sender, EventArgs e) => AtualizaTable();
    }
}
