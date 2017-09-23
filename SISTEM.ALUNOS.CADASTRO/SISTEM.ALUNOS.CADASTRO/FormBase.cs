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
    public partial class FormBase : Form
    {
        private string _nomeDaFuncao;

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
            timer1_Tick(e,e);
            lbNomeDaFuncao.Text = _nomeDaFuncao;
        }
    }
}
