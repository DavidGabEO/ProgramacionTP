using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Net.Http;

namespace Carreras5
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void PanelTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //private void btnRegistrar_Click(object sender, EventArgs e)
        //{
        //    FrmRegistrarUsuario frmRegistrar = new FrmRegistrarUsuario();
        //    frmRegistrar.StartPosition = FormStartPosition.CenterScreen;
        //    frmRegistrar.Location = this.Location;
        //    frmRegistrar.ShowDialog();
        //}


        private async Task<bool> Login(string usuario, string contrasenia)
        { //https://localhost:44311/api/Carreras/Login/usuario/contrasenia
            string url = "https://localhost:44311/api/Carreras/Login";
            url += "/"+usuario+"/";
            url += contrasenia;
            using (HttpClient client = new HttpClient())
            {
                /*   StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
                   var result = await client.PostAsync(url, content);
                   client.GetAsync(url,)
                   string response = await result.Content.ReadAsStringAsync();
                   return response.Equals("Ok"); */

                var result = await client.GetAsync(url);

                string response = await result.Content.ReadAsStringAsync();
                return response.Equals("Ok");

            }
        }



        private async void btnIngresar_ClickAsync(object sender, EventArgs e)
        {

            bool success = await Login(txtUsuario.Text, txtContrasenia.Text);

            if (success)
            {
                FrmMenu frmPrin = new FrmMenu();
                frmPrin.StartPosition = FormStartPosition.CenterScreen;
                frmPrin.Location = this.Location;
                frmPrin.Show();
                this.Close();
            }

            else
            {
                MessageBox.Show("Error");
            }

        }

    }
}
