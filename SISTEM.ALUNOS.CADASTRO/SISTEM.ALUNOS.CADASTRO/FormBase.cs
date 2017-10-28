using System;
using System.Windows.Forms;

namespace CORUJA
{
    public partial class FormBase : Form
    {
        private readonly string _nomeDaFuncao;

        public FormBase(string nomeDaFuncao)
        {
            InitializeComponent();
            _nomeDaFuncao = nomeDaFuncao;
        }

        public FormBase()
        {
            InitializeComponent();
        }

        private void FormBase_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var agora = DateTime.Now;
            tslHora.Text = $@"Data: {agora.ToShortDateString()} Hora: {agora.ToLongTimeString()}";
        }

        private void FormBase_Load(object sender, EventArgs e)
        {
            timer1_Tick(e, e);
            lbNomeDaFuncao.Text = _nomeDaFuncao;
        }
    }
}