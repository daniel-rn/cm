using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISTEM.ALUNOS.CADASTRO
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Connection.Active(true);
                MessageBox.Show("Sucesso na conexão !!");
            }
            catch (Exception Erro)
            {
                MessageBox.Show(Erro.Message);
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
            Connection.Active(false);
        }
    }
}
