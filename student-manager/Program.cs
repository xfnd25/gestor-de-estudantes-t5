using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace student_manager
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Login_Form());
            ForminserirEstudante telaDeLogin = new ForminserirEstudante();

            if (telaDeLogin.ShowDialog() == DialogResult.OK) 
            {
                Application.Run(new FormPrincipal());
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
