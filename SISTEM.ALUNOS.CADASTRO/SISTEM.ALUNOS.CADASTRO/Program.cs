using System;
using System.Windows.Forms;

namespace SISTEM.ALUNOS.CADASTRO
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AboutBox1());
            Application.Run(new LoginForm());
           
        }
    }
}
