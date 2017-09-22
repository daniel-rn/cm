using System;
using System.Data;
using System.Windows.Forms;
using Biblioteca;


namespace SISTEM.ALUNOS.CADASTRO
{
    public partial class TelaExibeCadastros : FormBase
    {
        private readonly Aluno aluno = new Aluno();

        public TelaExibeCadastros()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var agora = DateTime.Now;
            lbData.Text = $@"Data: {agora.ToShortDateString()} Hora: {agora.ToLongTimeString()}";
            tslHora = lbData;
        }

        private void AtualizaTable()
        {
            try
            {
                var fbReader = aluno.Open(Connection.FbCnn);
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
            timer1_Tick(e,e);
        }
    }
}
