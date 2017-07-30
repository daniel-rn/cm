using ClassLibrary1;
using FirebirdSql.Data.FirebirdClient;
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
    public partial class TelaExibeCadastros : Form
    {
        private Aluno aluno = new Aluno();
        public TelaExibeCadastros()
        {
            InitializeComponent();

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime agora = DateTime.Now;
            lbData.Text ="Data: "+agora.ToShortDateString()+" Hora: "+agora.ToLongTimeString();
            //lbData.Text =$"Data: {agora.ToShortDateString()} Hora: {agora.ToLongTimeString()}";
        }
        private void atualizaTable()
        {
            try
            {
                DataTable dtAlunos = new DataTable();
                FbDataReader fbReader;
                fbReader = aluno.Open(Connection.FbCnn);
                dtAlunos.Load(fbReader);
                grid.DataSource = dtAlunos;

            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
        }

        private void TelaExibeCadastros_Load(object sender, EventArgs e)
        {
            atualizaTable();
            timer1_Tick(e,e);
        }
    }
}
