using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carreras5
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FrmLogin());

            FrmLogin main = new FrmLogin();
            main.FormClosed += FrmLogin_Closed;
            main.Show();
            Application.Run();
        }

        //CERRAR VENTANA DEL LOGIN
        private static void FrmLogin_Closed(object sender, FormClosedEventArgs e)
        {
            ((Form)sender).FormClosed -= FrmLogin_Closed;

            if (Application.OpenForms.Count == 0)
            {
                Application.ExitThread();
            }
            else
            {
                Application.OpenForms[0].FormClosed += FrmLogin_Closed;
            }
        }
    }
}
