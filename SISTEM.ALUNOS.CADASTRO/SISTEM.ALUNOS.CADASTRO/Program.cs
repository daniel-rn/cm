using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;

namespace CORUJA
{
    internal static class Program
    {
        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new frmLoginForm());
            }
#if DEBUG
            else
            {
                ExecuteAplicacao(args);
            }
#endif
        }

        private static void ExecuteAplicacao(IReadOnlyList<string> args)
        {
            var idFormulario = args[0];
            var ass = Assembly.GetExecutingAssembly();

            if (!(ass.CreateInstance($"CORUJA.{idFormulario}") is Form frm))
            {
                MessageBox.Show($@"Formulário não encontrado: {idFormulario}", @"Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            Application.Run(frm);
        }
    }
}