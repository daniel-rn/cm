using System;
using System.Reflection;
using System.Windows.Forms;

namespace SISTEM.ALUNOS.CADASTRO
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new AboutBox1());
                Application.Run(new LoginForm());
            }
#if DEBUG
            else
            {
                ExecuteAplicacao(args);
            }
#endif
        }

        private static void ExecuteAplicacao(string[] args)
        {
            var idFormulario = args[0];
            var ass = Assembly.GetExecutingAssembly();
            var frm = ass.CreateInstance(string.Concat("SISTEM.ALUNOS.CADASTRO.", idFormulario)) as Form;

            if (frm == null)
            {
                MessageBox.Show($"Formulário não encontrado: {idFormulario}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Application.Run(frm);
        }
    }
}
